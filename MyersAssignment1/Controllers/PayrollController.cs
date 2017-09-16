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
            return View(pay);
        }
        [HttpPost]
        public ActionResult Calculate(Payroll pay)
        {
            if (ViewData.ModelState.IsValid)
            {
                pay.GrossPay = pay.Hours * pay.PayRate;

                switch(pay.MaritalStatus.ToLower())
                {
                    case "married":
                        pay.Taxes = pay.GrossPay * .1m;
                        break;
                    case "single":
                        pay.Taxes = pay.GrossPay * .2m;
                        break;
                    default:
                        pay.Taxes = pay.GrossPay * .2m;
                        break;
                }

                pay.Taxes = pay.Taxes - 10 * pay.Dependents;
                pay.NetPay = pay.GrossPay - pay.Taxes;
            }
            return View(pay);
        }
    }
}