using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sculptor.Repository;

namespace Sculptor.NagarCast.Controllers
{
    public class BaseController : Controller
    {
        public Sculptor.Repository.NagarCast _objContext = new Sculptor.Repository.NagarCast();

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }

    }
}
