using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NET6LINQImprovements.Models;

namespace NET6LINQImprovements.Controllers
{
    public class ZipController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            int[] numbers = { 1, 2, 3, 4, };
            string[] months = { "Jan", "Feb", "Mar" };
            string[] seasons = { "Winter", "Winter", "Spring" };

            var test = numbers.Zip(months).Zip(seasons);
            string Result = "";
            foreach ((int, string, string) zipped in numbers.Zip(months, seasons))
            {
                Result = Result + zipped.Item1 + ": " + zipped.Item2.ToString() + " , " + zipped.Item3.ToString() + " | ";
            }

            var viewModel = new ShowResultViewModel
            {
                Result1 = Result,


            };
            return View(viewModel);
        }


    }
}
