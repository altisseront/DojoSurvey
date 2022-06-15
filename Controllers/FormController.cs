using Microsoft.AspNetCore.Mvc;
namespace FormController.Controllers;     //be sure to use your own project's namespace!
    public class FormController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public ViewResult Index()
        {
            return View("Index");
        }
        [HttpPost]
        [Route("method")]
        public IActionResult method(string Name, string DojoLocation, string FavoriteLanguage, string Comment)
        {
            string[] inputs = {Name, DojoLocation, FavoriteLanguage, Comment};
            ViewBag.Name = Name;
            ViewBag.DojoLocation = DojoLocation;
            ViewBag.FavoriteLanguage = FavoriteLanguage;
            ViewBag.Comment = Comment;
            return View("result");
        }
        [HttpGet]       //type of request
        public ViewResult Result()
        {
            return View();
        }
    }

