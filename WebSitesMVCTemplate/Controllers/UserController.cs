﻿using Microsoft.AspNetCore.Mvc;

namespace WebSitesMVCTemplate.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
    }
}