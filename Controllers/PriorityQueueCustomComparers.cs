using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NET6LINQImprovements.Models;

namespace NET6LINQImprovements.Controllers
{
    public class PriorityQueueCustomComparers : Controller
    {
        // GET: PriorityQueueCustomComparers
        public ActionResult Index()
        {
            PriorityQueue<string, string> bankQueue = new PriorityQueue<string, string>(new TitleComparer());
            
            bankQueue.Enqueue("John Jones", "Sir");
            bankQueue.Enqueue("Jim Smith", "Mr");
            bankQueue.Enqueue("Sam Poll", "Mr");
            bankQueue.Enqueue("Edward Jones", "Sir");
           
            //Console.WriteLine("Clearing Customers Now");

            string Result = "";
            while (bankQueue.TryDequeue(out string item, out string priority))
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

//https://dotnetcoretutorials.com/2021/03/17/priorityqueue-in-net/?series