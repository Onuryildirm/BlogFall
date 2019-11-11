using BlogFall.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogFall.Areas.Admin.Controllers
{
    [Breadcrumb("Anasayfa")]
    //Authorize(Roles = "Admin") miras olarak geliyor
    public class DashboardController : AdminBaseController
    {
        [Breadcrumb("İndeks")]
        // GET: Admin/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}