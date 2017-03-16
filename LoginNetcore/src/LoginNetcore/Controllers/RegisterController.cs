using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LoginNetcore.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index(string name,string pwd)
        {
            int a = new Dal.userDa().register(name, pwd);
            if (a>0)
            {
                return Redirect("/Login/Index");
            }
            return View();
        }
    }
}
