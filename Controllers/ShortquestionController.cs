using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oe.Controllers
{
    public class ShortquestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
