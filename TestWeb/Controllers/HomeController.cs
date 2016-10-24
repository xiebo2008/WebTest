using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWeb.Models;

namespace TestWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult UserList()
        { 

            //请求打开数据库
            //增加、删除、修改、查询
            //请求关闭数据库


            //首先向数据库请求数据
            //
            List<Users> _users = new List<Users>();
            //赋值数据

            Users _u = new Users();
            _u.UserName = "张三";
            _u.Sex = "男";
            _u.IDCard = "123456";
            _users.Add(_u);

            Users _u1 = new Users();
            _u1.UserName = "李四";
            _u1.Sex = "男";
            _u1.IDCard = "123456";
            _users.Add(_u1);

            Users _u2 = new Users();
            _u2.UserName = "王五";
            _u2.Sex = "男";
            _u2.IDCard = "123456";
            _users.Add(_u2);

            ViewData["_userList"] = _users;

            return View();


            
        }


    }
}
