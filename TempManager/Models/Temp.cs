using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace TempManager.Models
{
    public class Temp
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [Remote(action: "CheckDate", controller: "Validation")]
        public DateTime? Date { get; set; }

        [Required(ErrorMessage = "Low temperature is required")]
        [Range(-200, 200, ErrorMessage = "Low temperature must be between -200 and 200")]
        public double? Low { get; set; }

        [Required(ErrorMessage = "High temperature is required")]
        [Range(-200, 200, ErrorMessage = "High temperature must be between -200 and 200")]
        public double? High { get; set; }
    }
}