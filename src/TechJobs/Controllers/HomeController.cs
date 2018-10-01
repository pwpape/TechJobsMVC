using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TechJobs.Controllers
{
    //Action method (Index) displays the home page for the app.  View uses the Views/Index.cshtml template.
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Dictionary<string, string> actionChoices = new Dictionary<string, string>();
            actionChoices.Add("search", "Search");
            actionChoices.Add("list", "List");
            
            ViewBag.actions = actionChoices;

            return View();
        }
    }
}
