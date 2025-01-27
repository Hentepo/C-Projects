using coreFormsAndValidation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace coreFormsAndValidation.Controllers
{
    public class Account : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WeeklyTypedLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginPost(string username, string password)
        {
            ViewBag.Username = username;
            ViewBag.Password = password;
            return View();
        }
        public IActionResult StronglyTypedLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginSuccess(LoginViewModel login)
        {
            if (login.Username != null && login.Password != null)
            {
                if (login.Username.Equals("admin") && login.Password.Equals("password"))
                {
                    ViewBag.Message = "You are successfully logged in";
                    return View();
                }
            }
            ViewBag.Message = "Invalid credentials";
            return View();
        }
        //ViewBag.Username = login.Username;
        //    ViewBag.Password = login.Password;
        //    return View();
        public IActionResult UserDetail()
        {
            var user = new LoginViewModel() { Username = "HH", Password = "123456"}; 
            return View(user);            
        }
        public IActionResult UserList()
        {
            var users = new List<LoginViewModel>()
            {
                new LoginViewModel() {Username="HH", Password="1234565"},
                new LoginViewModel() {Username="HH1", Password="12345651"},
                new LoginViewModel() {Username="HH2", Password="12345651"},
            };
            return View(users);
        }
        public IActionResult GetAccount()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PostAccount(Account account)
        {
            if(ModelState.IsValid) 
            {
                return View("Success");
            }
            return RedirectToAction("GetAccount");
        }
    }
}
