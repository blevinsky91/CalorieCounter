using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calorie_Counter.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Calorie_Counter.Controllers
{
    public class MainController : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult CalculatorInput()
        {
            Users userModel = new Users();
            return View(userModel);
        }

        public ActionResult CalculatorResult(Users userModel)
        {
            double bmr = 0;
            if (userModel.IsMale)
            {
                bmr =
                    66 +
                    (13.7 * userModel.Weight) +
                    (5 * userModel.Height) -
                    (6.76 * userModel.Age);
            }
            if (userModel.IsFemale)
            {
                bmr =
                    655 +
                    (9.6 * userModel.Weight) +
                    (1.8 * userModel.Height) -
                    (4.7 * userModel.Age);
            }

            userModel.LifestyleRates.Clear();
            userModel.LifestyleRates.Add(
                new KeyValuePair<string, int>("Sedentry", (int)(bmr * 1.2)));
            userModel.LifestyleRates.Add(
                new KeyValuePair<string, int>("Lightly Active", (int)(bmr * 1.375)));
            userModel.LifestyleRates.Add(
                new KeyValuePair<string, int>("Moderately Active", (int)(bmr * 1.55)));
            userModel.LifestyleRates.Add(
                new KeyValuePair<string, int>("Very Active", (int)(bmr * 1.725)));
            userModel.LifestyleRates.Add(
                new KeyValuePair<string, int>("Extra Active", (int)(bmr * 1.9)));

            return View(userModel);
        }
    }
}

