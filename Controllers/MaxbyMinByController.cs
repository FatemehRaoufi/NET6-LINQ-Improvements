using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NET6LINQImprovements.Models;

namespace NET6LINQImprovements.Controllers
{
    public class MaxbyMinByController : Controller
    {
        // GET: MaxbyMinByController
        public ActionResult Index()
        {
            List<int> myList = new List<int> { 1, 2, 3 };
            myList.Max(); //Returns 3

            var group1 = new List<(string Name, int Age)>()
{
    (Name: "Vicki", Age: 24),
    (Name: "Leonard ", Age: 24),
    (Name: "Eve", Age: 29),
};
            var group2 = new List<(string Name, int Age)>()
{
    (Name: "Eric", Age: 43),
    (Name: "David", Age: 24),
    (Name: "Lucy", Age: 34),
};
            var max = group1.MaxBy(p => p.Age).Name;
            // Person with max age in group1: Eve

            var min = group1.MinBy(p => p.Age).Name;
            // Person with min age in group1: Vicki
            //.....................
            var distinct = group1
                           .DistinctBy(p => p.Age)
                           .Select(p => p.Name);
            // People with unique age in group1: Vicki, Eve

            var union = group1
                            .UnionBy(group2, p => p.Age)
                            .Select(p => p.Name);
            // Union of group1 and group2 but only one with each age: Vicki, Eve, Eric, Lucy

            var intersect = group1
                            .IntersectBy(group2.Select(p => p.Age), p => p.Age)
                            .Select(p => p.Name);
            // Unique people by age in group1 that do have a person in group2 with same age: Vicki

            var except = group1
                            .ExceptBy(group2.Select(p => p.Age), p => p.Age)
                            .Select(p => p.Name);
            // Unique people by age in group1 that do not have a person in group2 with same age: Eve




            //...................................................
            var viewModel = new ShowResultViewModel
            {
                Result1 = max.ToString(),
                Result2 = min.ToString()
            };



            return View(viewModel);
        }

        
    }
}
//https://dotnetcoretutorials.com/2021/09/09/maxby-minby-in-net-6/?series