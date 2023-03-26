using Microsoft.AspNetCore.Mvc;
using SanaASP1.Models;

namespace SanaASP1.Controllers
{
    public class FirstNameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Result(UserName userName)
        {
            return View(userName);
        }
    }
}
