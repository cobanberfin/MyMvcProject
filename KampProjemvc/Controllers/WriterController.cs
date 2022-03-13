using Business.Concrete;
using DataAcess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KampProjemvc.Controllers
{
    public class WriterController : Controller
    {
        //WriterManager wm = new WriterManager(new EfWriterDal);
        public ActionResult Index()
        {
            return View();
        }
    }
}