using CustomerSupportBusinessLogic.Interfaces;
using CustomerSupportBusinessLogic.Service;
using CustomerSupportModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerSupportSystem.Controllers
{
    public class UserTypeController : Controller
    {
        private IUserType UserType = new UserTypeService();
        // GET: UserType
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(UserTypeViewModel model)
        {

            return View("Index");
        }
    }
}