using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TempManager.Models;

namespace TempManager.Controllers
{
    public class ValidationController : Controller
    {
        private readonly TempManagerContext data;

        public ValidationController(TempManagerContext context)
        {
            data = context;
        }

        public JsonResult CheckDate(string date)
        {
            DateTime parsedDate;
            bool isValid = DateTime.TryParse(date, out parsedDate);

            if (isValid)
            {
                var temp = data.Temps.FirstOrDefault(t => t.Date == parsedDate);
                isValid = temp == null; // Return false if a Temp object with the date already exists
            }
            else
            {
                isValid = false; // Invalid date format
            }

            return Json(isValid);
        }
    }
}