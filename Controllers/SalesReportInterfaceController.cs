using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace reportApp.Controllers
{

    public class SalesReportInterfaceController : Controller
    {


        public IActionResult SelectParam()
        {
            return View();
        }
        public IActionResult Report()
        {
            return View();
        }

    }
}