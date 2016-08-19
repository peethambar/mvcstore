using BAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ViewModels;

namespace OnlineShoppingSite.Controllers
{
    public class AccountController : Controller
    {
        IUserRepository repo;
        public AccountController(IUserRepository _repo)
        {
            repo = _repo;
        }
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            UserViewModel obj = repo.ValidateUser(model);
            if (obj != null)
            {
                string str = JsonConvert.SerializeObject(obj);
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, model.Username, DateTime.Now, DateTime.Now.AddMinutes(20), false, str);

                string encTicket = FormsAuthentication.Encrypt(ticket);

                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
                Response.Cookies.Add(cookie);

                if (obj.Roles.Contains("Admin"))
                {
                    return RedirectToAction("index", "Home", new { area = "Admin" });
                }
                else if (obj.Roles.Contains("User"))
                {
                    return RedirectToAction("index", "Home", new { area = "User" });
                }
            }
            return View();
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        public ActionResult UnAuthorize()
        {
            return View();
        }
    }
}