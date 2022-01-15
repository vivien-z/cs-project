using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cs_project.Models;
using cs_project.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cs_project.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProcessLogin(UserModel userModel)
        {
            SecurityService securityService = new SecurityService();

            if (securityService.IsValid(userModel))
            {
                return View("LoginSuccess", userModel); // ("pg goes to", data)
            } else
            {
                return View("LoginFailure", userModel);
            }
            
        }
    }
}
