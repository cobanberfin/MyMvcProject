using Business.Concrete;
using Business.Validation;
using DataAcess.Abstract;
using DataAcess.EntityFramework;
using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KampProjemvc.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
          var catlist=  cm.GetList();
            return View(catlist);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
          CategoryValidator categoryValidator = new CategoryValidator();

            ValidationResult results = categoryValidator.Validate(category);
            if (results.IsValid)
            {
                cm.CategoryAdd(category);
                return RedirectToAction("Index");
            }
            else{
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult DeleteCategory(int id)
        {
            var catsilinen = cm.GetById(id);
            cm.Delete(catsilinen);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var x = cm.GetById(id);
            return View(x);
          
        }
        [HttpPost]
        public ActionResult EditCategory(Category category)
        {
            cm.CategoryUpdate(category);
            return RedirectToAction("Index");

        }
    }
}