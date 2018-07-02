using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;
using MySql.Data.MySqlClient;//调用MySQL动态库
using ASP_Pro.Models;
using System.Web.Security;

namespace ASP_Pro.Controllers
{
    public class HomeController : Controller
    {
        string str = "server=localhost;User Id=root;password=root;Database=movies";


        public void IsLogin() {
            if (Session["userName"] == null)
            {
                Login();
            }
        }

        public ActionResult Exit()
        {
            Session.Clear();
            return View("Login");
        }

        public ActionResult Index()
        {
            IsLogin();
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult IsAdmin(MyUserModel user)
        {
            String name = user.userName;
            String password = user.userPassword;

            try
            {
                password = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5").ToLower();
            }
            catch (Exception)
            {
                password = "0";
            }

            object n = MySqlHelper.ExecuteScalar(str, "select * from user where userName='" + name + "' and userPassword = '" + password + "'");

            if (n == null)
            {
                ViewBag.Result = "bad";
               
                return Login();
            }
            else
            {
                Session["userName"] = name;
    
                return Exercise("Index");
            }


        }


        public ActionResult Exercise(String id)
        {
            
            if (Request.IsAjaxRequest())
            {
                return PartialView(id);
            }
            else
            {
                return View(id);
            }
        }

        public ActionResult Animation2()
        {
            return View();
        }



        public ActionResult Test(String id)
        {
            IsLogin();
            DataSet ds = MySqlHelper.ExecuteDataset(str, "select * from movie");

            ViewData["getds"] = ds;
            return View(id);
        }

        public ActionResult AddMovie(Movie movie)
        {
            IsLogin();
            String type = movie.Type;
            String name = movie.Name;
            MySqlHelper.ExecuteNonQuery(str, "insert into movie(type,name) values('" + type + "','" + name+"')");
            return Test("Test");
        }
        
        public ActionResult DeleteMovie(int id)
        {
            IsLogin();
            MySqlHelper.ExecuteNonQuery(str, "delete from movie where id=" + id.ToString());
            return Test("Test");
        }
        
        public ActionResult EditMovie(int id)
        {
            IsLogin();
            DataSet ds = MySqlHelper.ExecuteDataset(str, "select * from movie where id="+id.ToString());
            ViewData["getds"] = ds;
            return View("editMovie");
        }

        
        public ActionResult UpdateMovie(Movie movie)
        {
            IsLogin();
            String type = movie.Type;
            String name = movie.Name;
            String id = movie.ID;
            MySqlHelper.ExecuteNonQuery(str, "update movie set type='"+type+"',name='"+name+"' where id="+id.ToString());
            //return Content("update movie set type='" + type + "',name='" + name + "' where id=" + ID.ToString());
            return Test("Test");
        }


        public ActionResult Interactive(MyUserModel user)
        {
            IsLogin();
            string s = "bad";

            if (Request.HttpMethod == "GET")
            {
                user = new MyUserModel();
            }
            else
            {
                if (this.ModelState.IsValid)
                {
                    string name = user.userName,password=user.userPassword, email = user.userEmail, phone = user.userPhone;
                    DateTime birth =(DateTime) user.userBirth;
                    s = string.Format("您的用户名:{0}；用户邮箱:{1};手机号码:{2};出生日期:{3}", name, email, phone, birth);
                    MySqlHelper.ExecuteNonQuery(str, "insert into user(userName,userPassword,userEmail,userPhone,userBirth) values('" + name + "',md5('" + 
                        password + "'),'"+email+"','"+phone+"','"+birth+"')");
                }
            }
            ViewBag.Result = s;
            //return PartialView(user);
            return View(user);
        }
    }
}