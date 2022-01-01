using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NET6LINQImprovements.Models;

namespace NET6LINQImprovements.Controllers
{
    public class MaxbyMinByPerson : Controller
    {
        // GET: MaxbyMinByController
        public ActionResult Index()
        {
            List<Person> people = new List<Person>
{
    new Person
    {
        Name = "John Smith",
        Age = 20
    },
    new Person
    {
        Name = "Jane Smith",
        Age = 30
    }
};
            var max = people.Max(x => x.Age);//Outputs 30
            var maxby = people.MaxBy(x => x.Age); //Outputs Person (Jane Smith)
            var viewModel = new ShowResultViewModel
            {
                Result1 = max.ToString(),
                Name = maxby.Name.ToString(),
                Age = maxby.Age.ToString()
            };



            return View(viewModel);
        }


    }
}
