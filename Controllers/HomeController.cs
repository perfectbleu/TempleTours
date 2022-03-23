﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TempleTours.Models;

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
            var times = aContext.ApptTimes
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
            ViewBag.ApptTimes = aContext.ApptTimes.ToList();
            return View(id);
        }

        [HttpPost]
        public IActionResult ApptForm(ApptModel a)
        {
            if (ModelState.IsValid)
            {
                aContext.Add(a);
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
            ViewBag.ApptTimes = aContext.ApptTimes.ToList();

            var appt = aContext.Appts.Single(x => x.ApptId == id);
            return View("ApptForm", appt);
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
