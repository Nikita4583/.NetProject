using CustomerSupportModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerSupportBusinessLogic.Interfaces;
using CustomerSupportBusinessLogic.Service;


namespace CustomerSupportSystem.Controllers
{
    public class SoftwareTypeController : Controller
    {
       private ISoftwareType SoftwareType = new SoftwareTypeService();
        //public SoftwareTypeController()
        //{
        //    SoftwareType
        //}
       
        // GET: SoftwareType
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(SoftwareTypeViewModel model)
        {
            SoftwareType.Insert(model);
            return View("Index");
        }
    }
}