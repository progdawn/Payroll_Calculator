using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyersAssignment1.Models
{
    public class Payroll
    {
        public Payroll()
        {
            MaritalList = new List<SelectListItem>();
        }

        public decimal Hours { get; set; }
        public decimal PayRate { get; set; }
        public decimal GrossPay { get; set; }
        public decimal Taxes { get; set; }
        public decimal NetPay { get; set; }
        public string MaritalStatus { get; set; }
        public int Dependents { get; set; }
        public List<SelectListItem> MaritalList { get; set; }
    }
}