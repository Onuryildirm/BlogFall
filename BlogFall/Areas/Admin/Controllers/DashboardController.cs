using BlogFall.Areas.Admin.ViewModels;
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
            DashboardIndexViewModel model = new DashboardIndexViewModel
            {
                CategoryCount = db.Categories.Count(),
                PostCount = db.Posts.Count(),
                UserCount = db.Users.Count(),
                CommentCount = db.Comments.Count()
            };
            return View(model);
        }
    }
}