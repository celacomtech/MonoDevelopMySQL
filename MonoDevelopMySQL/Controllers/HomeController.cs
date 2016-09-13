using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using MonoDevelopMySQL.ContextDbs;
using MonoDevelopMySQL.Models;

namespace MonoDevelopMySQL.Controllers
{
	public class HomeController : Controller
	{private PeopleContext db;

		public HomeController()
		{
			this.db = new PeopleContext ();
		}
		public ActionResult Index()
		{

			var mvcName = typeof(Controller).Assembly.GetName ();
			var isMono = Type.GetType ("Mono.Runtime") != null;

			ViewData ["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData ["Runtime"] = isMono ? "Mono" : ".NET";

			List<Person> people;
			people = this.db.People.ToList ();

			return View (people);
		}
	}
}

