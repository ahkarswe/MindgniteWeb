using Microsoft.AspNetCore.Mvc;
using MindgniteWeb.Models;
using System.Diagnostics.Eventing.Reader;
using System.Net.Http.Headers;
using System.Threading.Channels;

namespace MindgniteWeb.Controllers
{
    public class MindgniteController : Controller
    {
      private static List<LearnViewModel> learns = new List<LearnViewModel>();
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()

        {
            
            return View();
           
            }

        public IActionResult About()
        {

            
            return View(learns);
        }
        public IActionResult Learn()
        {
            var learnVm = new LearnViewModel() { Name  = "Myanmar",Channel = "You tube" };

			return View (learnVm);
        }
        
        
        
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //return View("index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult HtLearn(LearnViewModel learnViewModel)
        {
            learns.Add(learnViewModel);
            return RedirectToAction(nameof(About));
        }
            
        }
       
}

