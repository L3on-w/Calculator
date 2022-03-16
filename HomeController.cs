using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CalculatorLab.Models;

namespace CalculatorLab.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculator(CalculatorViewModel model,string command)
        {
            if(command == "add")
            {
                model.Total = model.Number1 + model.Number2;
            }
            if (command == "sub")
            {
                model.Total = model.Number1 - model.Number2;
            }
            if (command == "mul")
            {
                model.Total = model.Number1 * model.Number2;
            }
            if (command == "div")
            {
                model.Total = model.Number1 / model.Number2;
            }
            return View(model);
        }
    }
}
