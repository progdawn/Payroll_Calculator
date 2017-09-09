using MyersAssignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyersAssignment1.Controllers
{
    public class PayrollController : Controller
    {
        // GET: Payroll
        public ActionResult Calculate()
        {
            Payroll pay = new Payroll();
            pay.MaritalList.Add(new SelectListItem { Text = "Single", Value = "1" });
            pay.MaritalList.Add(new SelectListItem { Text = "Married", Value = "2" });
            return View(pay);
        }
        [HttpPost]
        public ActionResult Calculate(Payroll pay)
        {
            if (ViewData.ModelState.IsValid)
            {
                pay.GrossPay = pay.Hours * pay.PayRate;

                if (pay.MaritalStatus == "1")
                    pay.Taxes = pay.GrossPay * .2m;
                else if (pay.MaritalStatus == "2")
                    pay.Taxes = pay.GrossPay * .1m;
                else
                    pay.Taxes = pay.GrossPay * .1m;

                pay.Taxes = pay.Taxes - 10 * pay.Dependents;
                pay.NetPay = pay.GrossPay - pay.Taxes;
            }
            return View(pay);
        }
    }
}