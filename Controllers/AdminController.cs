using HMS_Dotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace HMS_Dotnet.Controllers
{
    public class AdminController : Controller
    {

        public ActionResult Index()
        {
            var Admin = new Admin
            {
                Name = "Nikhil"
            };
            return View("AdminAdd", Admin);
        }
        [HttpGet("/admin/login")]
        public ActionResult AdminAdd()
        {
            return View("AdminLogin");
        }
    }
}