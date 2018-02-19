using System;
using Microsoft.AspNetCore.Mvc;
using MyHowest;
using System.Collections.Generic;

namespace MVCVoorbeeld.Controllers {
    public class HomeController : Controller {

        private string[] groenten = {"Rode kool", "Spruitjes", "Wortel", "Spinazie" };
        
        // GET
        public ViewResult Index(string name) {
            ViewBag.Groet = DateTime.Now.Hour < 12 ? "Goeiemorgen" : "Goeienamiddag";
            return View();
        }
        
        public ViewResult Groenten(string zoekGroente) {
            ViewBag.Groenten = groenten;
            if (!string.IsNullOrEmpty(zoekGroente)) {
                ViewBag.Zoekresultaat =
                    $"De gezochte groente is de {Array.IndexOf(groenten, zoekGroente) + 1}e uit de lijst";
            }
            return View();
        }
        
        public ViewResult Studenten() {
            List<Student> studenten = new List<Student> {
                new Student(23,"Yern",Graad.Voldoening),
                new Student(25,"Leander",Graad.Onderscheiding)
            };
            ViewBag.Studenten = studenten;
            return View();
        }
    }
}