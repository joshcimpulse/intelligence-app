using System;
using System.Web;
using System.Security.Principal;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using reportApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
namespace reportApp.Controllers
{
    //[Authorize(AuthenticationSchemes ="Windows")]
    public class HomeController : Controller
    {
        
        public string Name;

        //[Authorize(Roles = "Administrator")]

        public IActionResult Index()
        {

            ViewBag.idType = HttpContext.User.Identity.GetType().ToString();

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public void getContext(HttpContext context){
            /**
            var id = (WindowsIdentity)(context.User.Identity);
                        
            Console.WriteLine("User Data:");
 
            Console.WriteLine(id.Name);    
             using(var writer = new System.IO.StringWriter()){
                
                ObjectDumper.Dumper.Dump(id, "contextString", writer);
                Console.Write(writer.ToString());
            } 
    **/


        }

    }
}
