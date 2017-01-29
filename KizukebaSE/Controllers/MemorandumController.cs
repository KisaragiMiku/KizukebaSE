using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KizukebaSE.Controllers
{
    public class MemorandumController : Controller
    {
        // GET: Memorandum
        public ActionResult Index()
        {
            return View();
        }
    }
}