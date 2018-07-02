using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_Pro.Areas.LX02.Models;
namespace ASP_Pro.Areas.LX02.Controllers
{
    public class Lx02Controller : Controller
    {
        // GET: LX02/Lx02
        UserInfo user = new UserInfo
        {
            UserName = "小夏",
            UserPassword = "12345",
            UserEmail = "1222@qq.com",
            UserPhone = "123254365",
            UserBirth = DateTime.Parse("1996-01-09")
        };
        public ActionResult Index(String id)
        {
            
            
            ViewBag.user = user;
            if (Request.IsAjaxRequest())
            {
                ViewBag.name = "XX";
                return PartialView(id);
            }
            else
            {
                return View(id);
            }
        }

        public RedirectResult RedirectResult()
        {
            string url = Url.Action("Index", "Lx02", new { id = "Lx3" });
            return Redirect(url);
        }

        public ActionResult MyPartialView(string id)
        {
            ViewBag.user = user;

            return PartialView(id);
        }
        public ActionResult ContentResult()
        {
            return Content("<h1>未找到网页!</h1>");
        }
    }
}