using System;
using Microsoft.AspNetCore.Mvc;
using CalculatorLab.Models;

namespace CalculatorLab.Controllers
{
    public class CalculatorController : Controller
    {

        public IActionResult Calculator(CalculatorViewModel model, string command)
        {
            if (command == "add")
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
