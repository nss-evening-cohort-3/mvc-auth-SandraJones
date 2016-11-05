using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_auth_SandraJones.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}