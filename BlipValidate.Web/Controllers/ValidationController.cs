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
                // The model object would typically be initialized with a repository method.
                EarliestAudit = DateTime.Parse("2017-04-11"),
                LatestAudit = DateTime.Parse("2017-04-29")
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CustomerAdd(CustomerAddViewModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                // These model values need to be reset. 
                // They are not returned in the model because they are not on the form as <input> element type="hidden".
                model.EarliestAudit = DateTime.Parse("2017-04-11");
                model.LatestAudit = DateTime.Parse("2017-04-29");
                return View(model);            
            }
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
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else return View(model);
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