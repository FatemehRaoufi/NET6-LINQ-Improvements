using Microsoft.AspNetCore.Mvc;
using NET6LINQImprovements.Models;

namespace NET6LINQImprovements.Controllers
{
    public class RangeInTakeController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<int> numbers = new int[] { 1, 2, 3, 4, 5 };
            var taken1 = numbers.Take(2..4);
            string Result = "";
            foreach (var item in taken1)
            {
                Result = Result + item +", ";
            }

            var viewModel = new ShowResultViewModel
            {
                Result1 = Result.ToString(),


            };
            return View(viewModel);
        }
    }
}
