using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PluralsightASP.Core;

namespace PluralsightASP.Pages
{
    public class Login : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

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
        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }
        
        public void OnGet()
        {
            
        }

        public Login(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        
        
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var result = 
                     await _signInManager.PasswordSignInAsync(Email, Password, RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToPage("Profile");
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный логин и (или) пароль");
                }
            }

            return RedirectToPage("../Index");
        }
 
        
        /*public void OnPost()
        {
            // удаляем аутентификационные куки
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }*/
    }
}