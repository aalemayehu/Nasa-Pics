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
    [Route("search")]
    public class NasaController : Controller
    {
        [HttpGet]
        [Route("{searchCritera}")]
        public IActionResult GetRandomImage(string searchCritera)
        {
            return Ok();
        }
    }
}