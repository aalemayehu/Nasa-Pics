using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NasaApp.Models;
using System.Drawing;  
using System.IO;

namespace NasaApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/Dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
