using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace Site.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			return View ();
		}
	}
}

