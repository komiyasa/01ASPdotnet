﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numtimes = 1)
        {
            ViewData["message"] = "Hello" + name;
            ViewData["Numtimes"] = numtimes;

            return View();
        }
    }
}