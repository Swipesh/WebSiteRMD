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
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [BindProperty]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

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


        public Register(UserManager<User> userManager, SignInManager<User> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult OnGet()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToPage("Profile");
            else
            {
                return Page();
            }
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                User user = new User {Email = Email, UserName = Email,FirstName =  FirstName,LastName = LastName};
                // добавляем пользователя
                var result = await _userManager.CreateAsync(user, Password);
                if (result.Succeeded)
                {
                    // установка куки
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToPage("Profile");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            return RedirectToPage("../Index");
        }
    }
}