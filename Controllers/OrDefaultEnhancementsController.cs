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

        // GET: OrDefaultEnhancements/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrDefaultEnhancements/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrDefaultEnhancements/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrDefaultEnhancements/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrDefaultEnhancements/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrDefaultEnhancements/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrDefaultEnhancements/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
