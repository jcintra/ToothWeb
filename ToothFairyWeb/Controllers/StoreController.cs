using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToothFairyWeb.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Store/Details/5
        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;
            return message;
        }

        //
        // GET: /Store/Browse?genre=?Disco
        public string Browse(string genre)
        {
            string message =
            HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}