using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using demo.Models;

namespace demo.Controllers
{
    public class HomeController : Controller
    {   
        [HttpGet("")]
        public IActionResult Index()
        {   
            Message Intro = new Message()
            {
                Text="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce congue lacinia magna, ultrices sollicitudin massa imperdiet nec. In molestie purus sit amet ipsum vehicula, quis gravida leo eleifend. Nulla turpis diam, hendrerit a neque ac, interdum mollis orci. Quisque eleifend pulvinar lacus aliquet aliquam. Nulla venenatis lectus blandit fermentum cursus. In sed mi in arcu porttitor ullamcorper. In non arcu tellus. Integer tempor, diam pulvinar malesuada hendrerit, augue nulla elementum erat, sed feugiat sapien augue ut ante. Suspendisse scelerisque lacus quis diam cursus eleifend. Proin nec porta magna. Donec accumsan turpis et nibh tempor malesuada. Aenean viverra id velit eget scelerisque. Cras a lorem viverra, dictum mauris eleifend, egestas risus. Sed arcu purus, dignissim eu pellentesque ut, viverra in neque. Nullam dictum leo eros, at vehicula mauris dapibus quis."
            };
            return View(Intro);
        }
        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] A = new int[]{1,2,3,10,43,5};
            return View(A);
        }
        
        [HttpGet("users")]
        public IActionResult Users()
        {
            List<string> Users = new List<string>
            {
                "Moose Phillips",
                "Sarah",
                "Jerry",
                "Rene Ricky",
                "Barbarah"
            };
            return View(Users);
        }
        [HttpGet]
        [Route("{name}")]
        public IActionResult Details(string name)
        {   
            List<string> Users = new List<string>
            {
                "MoosePhillips",
                "Sarah",
                "Jerry",
                "ReneRicky",
                "Barbarah"
            };
            if (Users.Contains(name))
                return View("details",name);
            return RedirectToAction("users");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
