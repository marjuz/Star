using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SentiosFrontEnd.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        //
        // GET: /ADMIN/
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult UsersEdit()
        {
            return View();
        }

        [Authorize]
        public ActionResult RolesEdit()
        {
            return View();
        }
	}
}