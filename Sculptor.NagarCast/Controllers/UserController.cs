using Sculptor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sculptor.NagarCast.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddUser(UserMaster model)
        {
            return View(model);
        }

        [HttpPost]
        public ActionResult SubmitUser(UserMaster model)
        {
            return View(model);
        }

    }
}
