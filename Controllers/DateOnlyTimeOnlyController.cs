using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NET6LINQImprovements.Models;

namespace NET6LINQImprovements.Controllers
{
    public class DateOnlyTimeOnlyController : Controller
    {
        // GET: DateOnlyTimeOnlyController
        public ActionResult Index()
        {
            //Using DateTime
            DateTime dateTime = DateTime.Now;//Outputs "Local"
            DateTimeKind kind = dateTime.Kind; //Outputs "Local"
            //Using DateOnly
            DateOnly date = DateOnly.MinValue;//Outputs 01/01/0001 (With no Time)
            
          
            //Using TimeOnly
            TimeOnly time = TimeOnly.MinValue;//Outputs 12:00 AM
           //-------------
            TimeOnly startTime = TimeOnly.Parse("11:00 PM");
            var hoursWorked = 2;
            var endTime = startTime.AddHours(hoursWorked);//Outputs 1:00 AM
                                                         
           //----------
            bool isBetween = TimeOnly.Parse("12:00 AM").IsBetween(startTime, endTime); //Returns true. 
            //............................
            

            var viewModel = new ShowResultViewModel
            {
                Result1 = dateTime.ToString(),
                Result2 = date.ToString(),
                Result3 = time.ToString(),
                Result4 = startTime.ToString(),
                Result5 = endTime.ToString(),
                Result6 = isBetween==true ? "Yes":"No",
              
            };
            return View(viewModel);
        }

        
    }
}

//https://dotnetcoretutorials.com/2021/09/07/dateonly-and-timeonly-types-in-net-6/?series
//https://www.infoq.com/news/2021/04/Net6-Date-Time/