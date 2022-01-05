using Microsoft.AspNetCore.Mvc;
using NET6LINQImprovements.Models;

namespace NET6LINQImprovements.Controllers
{
    public class TryGetNonEnumeratedCountController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<int> numbers = new int[] { 1, 2, 3, 4, 5 };
           string IsEnumerated = Convert.ToString( numbers.TryGetNonEnumeratedCount(out int count));
            string Result = "No";
            if (IsEnumerated=="True")
            {
                Result = "Yes";
            }
            var viewModel = new ShowResultViewModel
            {
                Result1 = Result,

            };

            return View(viewModel);
        }
    }
}
