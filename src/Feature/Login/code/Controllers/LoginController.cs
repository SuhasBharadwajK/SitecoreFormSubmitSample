using SitecoreLogin.Feature.Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreLogin.Feature.Login.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index(LoginViewModel loginViewModel = null)
        {
            return View(loginViewModel ?? new LoginViewModel());
        }

        [HttpPost]
        public ActionResult LoginUser(LoginViewModel loginViewModel)
        {
            loginViewModel.IsLoginSuccess = true;
            return View("~/Views/Login/Index.cshtml", loginViewModel);
        }
    }
}