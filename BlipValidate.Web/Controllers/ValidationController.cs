using System;
using Microsoft.AspNetCore.Mvc;
using BlipValidate.Data.ViewModels;

namespace BlipValidate.Web.Controllers
{
    public class ValidationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CustomerAdd()
        {
            var model = new CustomerAddViewModel
            {
                EarliestAudit = DateTime.Parse("2017-04-11"),
                LatestAudit = DateTime.Parse("2017-04-29")
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CustomerAdd(CustomerAddViewModel model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else return View();            
        }

        public IActionResult CustomerAddBare()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CustomerAddBare(CustomerAddBareViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else return View();
        }

        public IActionResult ValueTypesBare()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ValueTypesBare(ValueTypesBareViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else return View();
        }
        public IActionResult AnnotatedTypes()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AnnotatedTypes(AnnotatedTypesViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else return View();
        }
    }
}