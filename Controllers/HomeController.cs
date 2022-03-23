using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TempleTours.Models;
using TempleTours.Models.ViewModels;

namespace TempleTours.Controllers
{
    public class HomeController : Controller
    {

        private ApptContext aContext { get; set; }
        public HomeController(ApptContext x)
        {
            aContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            var times = aContext.ApptTimes.Where(x => x.Available == true)
                .ToList();

            return View(times);
        }

        public IActionResult ViewAppts()
        {
            var appts = aContext.Appts
                .ToList();
            return View(appts);
        }

        // ADD APPOINTMENT
        [HttpGet]
        public IActionResult ApptForm(int id)
        {
            var x = new ApptsViewModel
            {
                ApptTime = aContext.ApptTimes.Single(x => x.TimeId == id),

                ApptModel = new ApptModel()
            };

            return View(x);
        }

        [HttpPost]
        public IActionResult ApptForm(ApptsViewModel a)
        {
            if (ModelState.IsValid) 
            {
                //a.ApptTime.Available = false;

                aContext.Add(a.ApptModel);
                aContext.Add(a.ApptTime);
                aContext.SaveChanges();

                return RedirectToAction("ViewAppts");
            }
            else
            {
                ViewBag.ApptTimes = aContext.ApptTimes.ToList();
                return View(a);
            }
        }


        // EDIT APPOINTMENT
        [HttpGet]
        public IActionResult EditAppt(int id)
        {
            var x = new ApptsViewModel
            {
                ApptModel = aContext.Appts.Single(x => x.ApptId == id)
            };

            return View("ApptForm", x);
        }

        [HttpPost]
        public IActionResult EditAppt(ApptModel a)
        {
            aContext.Update(a);
            aContext.SaveChanges();

            return RedirectToAction("ViewAppts");
        }


        // DELETE APPOINTMENT
        [HttpGet]
        public IActionResult DeleteAppt(int id)
        {
            var appt = aContext.Appts.Single(x => x.ApptId == id);
            return View(appt);
        }

        [HttpPost]
        public IActionResult DeleteAppt(ApptModel a)
        {
            aContext.Appts.Remove(a);
            aContext.SaveChanges();

            return RedirectToAction("ViewAppts");
        }
    }
}
