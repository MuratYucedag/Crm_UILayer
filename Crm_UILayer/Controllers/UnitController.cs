using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crm_UILayer.Controllers
{
    public class UnitController : Controller
    {
        UnitManager unitManager = new UnitManager(new EfUnitDal());
        public IActionResult Index()
        {
            var values = unitManager.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddUnit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUnit(Unit unit)
        {
            UnitValidator validationRules = new UnitValidator();
            ValidationResult result = validationRules.Validate(unit);
            if (result.IsValid)
            {
                unit.UnitStatus = true;
                unitManager.TInsert(unit);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteUnit(int id)
        {
            var values = unitManager.TGetByID(id);
            unitManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditUnit(int id)
        {
            var values = unitManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditUnit(Unit unit)
        {
            unitManager.TUpdate(unit);
            return RedirectToAction("Index");
        }
    }
}
