﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingSite.Areas.User.Controllers
{
    public class HomeController : BaseController
    {
        // GET: User/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}