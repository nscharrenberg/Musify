using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Musify_Web.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        [Route("dbError")]
        public ActionResult DatabaseException()
        {
            return View();
        }

        public ActionResult SqlException(string msg)
        {
            return View((object)msg);
        }
    }
}