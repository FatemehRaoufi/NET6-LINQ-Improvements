using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NET6LINQImprovements.Models;

namespace NET6LINQImprovements.Controllers
{
    public class IndexInElementAtController : Controller
    {
        // GET: IndexInElementAtController
        public ActionResult Index()
        {
            IEnumerable<int> numbers = new int[] { 1, 2, 3, 4, 5 };
            int last = numbers.ElementAt(^1); // = last =numbers.ElementAt(movies.Count() - 1); => 5


            var viewModel = new ShowResultViewModel
            {
                Result1 = last.ToString(),


            };
            return View(viewModel);
        }


    }
}
