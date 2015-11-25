using MvcTest.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.tagname = "账号：";                                                    
            //ViewBag["tagname"] = "账号：";
            ViewData["tagpwd"] = "密码：";
        
            User u = new User();
            u.Id = 1;
            u.Username = "yangningyuan";
            u.Password = "123456";
            ViewBag.user = u;
            return View();
        }
        /// <summary>
        /// 登录
        /// </summary>
        public void login() 
        {
            string n = Request.Form["name"];
            string pwd = Request.Form["password"];
        }

        public ActionResult jubupage() 
        {
            return View();
        }

    }
}
