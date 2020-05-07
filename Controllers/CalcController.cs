using System;
using Microsoft.AspNetCore.Mvc;

namespace SquareRootCalculator.Controllers
{
    public class CalcController : Controller
    {
        public ActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Compare()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Compare(double firstNumber, double secondNumber)
        {
            double firstNumberSquareRoot = Math.Sqrt(firstNumber);
            double secondNumberSquareRoot = Math.Sqrt(secondNumber);
            if (firstNumberSquareRoot > secondNumberSquareRoot)
            {
                ViewBag.Result = $"The number {firstNumber} with Square root {firstNumberSquareRoot} has a higher square root than the number {secondNumber} with square root {secondNumberSquareRoot}";
            }
            else if (firstNumberSquareRoot < secondNumberSquareRoot)
            {
                ViewBag.Result = $"The number {secondNumber} with Square root {secondNumberSquareRoot} has a higher square root than the number {firstNumber} with square root {firstNumberSquareRoot}";
            }
            else if (firstNumberSquareRoot == secondNumberSquareRoot)
            {
                ViewBag.Result = "Both Numbers have the same Square Root. Please Enter Another Value!";
            }
            else
            {
                ViewBag.Result = "This Program Only Allows Positive Whole Numbers! Please Check Your Input.";

            }
            return View();
        }


    }
}