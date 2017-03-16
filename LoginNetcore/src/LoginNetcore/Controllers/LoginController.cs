using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LoginNetcore.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index(string name,string pwd)
        {
            Model.user a = new Dal.userDa().login(name, pwd);
            if (a != null)
            {
                return Redirect("/Home/Index");
            }
            return View();
        }
    }
}
