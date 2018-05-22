using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
namespace reportApp.Controllers

{
 
    public class SalesReportInterfaceController : Controller
    {

        public string reportMonth;
        public string reportYear;
        public IActionResult SelectParam()
        {


            return View();
        }

        [HttpPost]
        public IActionResult Report(string reportMonth, string reportYear)
        {
            ViewData["reportMonth"] = reportMonth;
            ViewData["reportYear"] = reportYear;
            
            return View();
        }

    }
}