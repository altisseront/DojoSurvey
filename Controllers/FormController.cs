using Microsoft.AspNetCore.Mvc;
namespace YourNamespace.Controllers;     //be sure to use your own project's namespace!
    public class FormController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("method")]
        public IActionResult method(string Name, string DojoLocation, string FavoriteLanguage, string Comment)
        {
            return RedirectToAction("Result", string name = Name, );
        }
    }

