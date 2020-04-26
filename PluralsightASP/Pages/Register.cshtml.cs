using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PluralsightASP.Core;

namespace PluralsightASP.Pages
{
    public class Register : PageModel
    {
        [BindProperty]
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
 
        [BindProperty]
        [Required]
        //[Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }
        
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        private readonly RoleManager<IdentityRole> _roleManager;
        //private readonly RoleManager<User> _roleManager;


        public Register(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult OnGet()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToPage("Users/List");
            else
            {
                return Page();
            }
        }


        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                User user = new User { Email = Email, UserName = Email};
                // добавляем пользователя
                await _roleManager.CreateAsync(new IdentityRole("admin"));
                var result = await _userManager.CreateAsync(user, Password);
                await _userManager.AddToRoleAsync(user,"admin");
                if (result.Succeeded)
                {
                    // установка куки
                     await _signInManager.SignInAsync(user, false);
                    
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return RedirectToPage("Index");
        }
    }
}