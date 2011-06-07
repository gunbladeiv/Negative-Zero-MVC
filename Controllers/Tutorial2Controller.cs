using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataTableEditable.Controllers
{
    public class Tutorial2Controller : Controller
    {
        //
        // GET: /Tutorial2/

        public ActionResult Index()
        {
            ViewBag.MenuTitle = "Please Click to See Changes";
            ViewBag.SectionTitle = "Please look at the changes below";
            return View();
        }

        [HttpGet]
        public ActionResult _PartialPick(int id)
        {
            if (id.Equals(1))
            {
                return PartialView("_Partial1");
            }
            else if (id.Equals(2))
            {
                return PartialView("_Partial2");
            }
            else if (id.Equals(3))
            {
                return PartialView("_Partial3");
            }
            else
            {
                return PartialView("_Partial4");
            }
        }
    }
}
