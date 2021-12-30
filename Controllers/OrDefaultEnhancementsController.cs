using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NET6LINQImprovements.Models;

namespace NET6LINQImprovements.Controllers
{
    public class OrDefaultEnhancementsController : Controller
    {
        // GET: OrDefaultEnhancements
        public ActionResult Index()
        {
            var numbers = new List<int>() { 3, 1, 4, 1, 5, 9 };
            var result = Enumerable
                            .Range(0, numbers.Count())
                            .Where(i => numbers[i] == 6)
                            .FirstOrDefault();

            var numbers1 = new List<int>() { 3, 1, 4, 1, 5, 9 };
            var resultwithDefault = Enumerable
                            .Range(0, numbers.Count())
                            .Where(i => numbers[i] == 6)
                            .FirstOrDefault(-1);



            var viewModel = new ShowResultViewModel
            {
                Result = result.ToString(),
                ResultwithDefault = resultwithDefault.ToString()
            };

            return View(viewModel);
            
        }

        
    }
}

//Resources:
//https://dotnetcoretutorials.com/2021/09/02/linq-ordefault-enhancements-in-net-6/
//https://blog.elmah.io/new-linq-extensions-in-net-6-and-benchmarks/