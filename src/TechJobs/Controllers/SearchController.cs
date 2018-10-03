using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        [HttpPost]
        public IActionResult Results(string searchType, string searchTerm)
        {
            ViewBag.searchTerm = searchTerm;
            
            if (searchType == "all")
            {
                ViewBag.jobs = JobData.FindAll();
            }
            else if (string.IsNullOrEmpty(searchTerm))
            {
                return Redirect(string.Format("/List/Values?column={0}", searchType));
            }
            else
            {
                ViewBag.jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
            }


            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View("Views/Search/Index.cshtml");
        }

    }
}
