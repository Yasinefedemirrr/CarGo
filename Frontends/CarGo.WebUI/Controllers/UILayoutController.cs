﻿using Microsoft.AspNetCore.Mvc;

namespace CarGo.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
