using Business.Concrete;
using Business.Validation;
using DataAcess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Linq;
using System.Web;

using System.Web.Mvc;

namespace KampProjemvc.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cat = new CategoryManager(new EfCategoryDal());
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var catvalue = cat.GetList();
            return View(catvalue);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator catv = new CategoryValidator();
            ValidationResult results = catv.Validate(p);//catvalısator sınıfnda olan degerlere gore dogruluk kontrolu yap.
            if (results.IsValid)
            {
                cat.CategoryAdd(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View();

        }

           
        }
    }
