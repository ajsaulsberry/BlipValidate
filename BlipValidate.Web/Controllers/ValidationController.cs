using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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
            return View();
        }

        [HttpPost]
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
        public IActionResult ValueTypesBare(ValueTypesBareViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else return View();
        }
    }
}