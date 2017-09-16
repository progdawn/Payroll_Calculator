using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MyersAssignment1.Models
{
    public class Payroll
    {
        [Required]
        [Range(minimum: 10, maximum: 55, ErrorMessage ="Hours must be between 10 and 55")]
        public decimal Hours { get; set; }

        [Required]
        [Range(minimum: 5, maximum: 20, ErrorMessage ="Pay rate must be between 5 and 20")]
        public decimal PayRate { get; set; }

        public decimal GrossPay { get; set; }
        public decimal Taxes { get; set; }
        public decimal NetPay { get; set; }

        [RegularExpression("^(Married|Single|married|single)$", ErrorMessage ="Status not valid")] 
        public string MaritalStatus { get; set; }
        public int Dependents { get; set; }
    }
}