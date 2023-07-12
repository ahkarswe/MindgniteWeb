using Microsoft.AspNetCore.Mvc;
using MindgniteWeb.Models;

namespace MindgniteWeb.Controllers
{
    public class MindgniteController : Controller
    {
        public IActionResult Index()

        {
            var dogVm = new DogViewModel();
            return View(dogVm);
           
            }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //return View("index");
            return RedirectToAction("Index", "Mindgnite");
        }
            
        }
       
}

