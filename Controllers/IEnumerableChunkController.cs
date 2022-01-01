using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NET6LINQImprovements.Models;

namespace NET6LINQImprovements.Controllers
{
    public class IEnumerableChunkController : Controller
    {
        // GET: IEnumerableChunkController
        public ActionResult Index()
        {
            var list = Enumerable.Range(1, 100);
            var chunkSize = 10;
            string chunkStr = "";
         
            foreach (var chunk in list.Chunk(chunkSize)) //Returns a chunk with the correct size. 
            {
                foreach (var item in chunk)
                {
                    // Console.WriteLine(item);
                    chunkStr = chunkStr+  item.ToString()+", ";

                }
            }
            //.......................
            //Do something Parallel
            var list2 = Enumerable.Range(1, 100);
            var chunkSize2 = 10;
            string chunkStr2 = "";
            foreach (var chunk in list2.Chunk(chunkSize2))  
            {
                Parallel.ForEach(chunk, (item) =>
                {
                    //Do something Parallel here. 
                    chunkStr2 = chunkStr2 + item.ToString() + ", ";
                });
            }
            //..............................
            var viewModel = new ShowResultViewModel
            {
                Result1 = chunkStr,
                Result2 = chunkStr2,
            };
            //..........................................

            return View(viewModel);
        }

      
    }
}
