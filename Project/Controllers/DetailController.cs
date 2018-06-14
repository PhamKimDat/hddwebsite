﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Web.Controllers
{
    public class DetailController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string ID)
        {
            ViewData["ID"] = ID;
            return View();
        }
    }
}
