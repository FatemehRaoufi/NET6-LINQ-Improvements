using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NET6LINQImprovements.Models;
using System.Collections.Generic;

namespace NET6LINQImprovements.Controllers
{
    public class PriorityQueueController : Controller
    {
        // GET: PriorityQueueController
        public ActionResult Index()
        {


            PriorityQueue<string, int> queue = new PriorityQueue<string, int>();
            queue.Enqueue("Item A", 0);
            queue.Enqueue("Item B", 60);
            queue.Enqueue("Item C", 2);
            queue.Enqueue("Item D", 1);
            string Result = "";

            while (queue.TryDequeue(out string item, out int priority))
            {
                //Console.WriteLine($"Popped Item : {item}. Priority Was : {priority}");
                Result = Result + item + ": " + priority.ToString() + " , ";
            }
            var viewModel = new ShowResultViewModel
            {
                Result1 = Result,


            };

            return View(viewModel);
        }


    }
}
