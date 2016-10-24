using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWeb.Models;


namespace TestWeb.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Users/
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 注册页面
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Reg()
        {
            return View();
        }


        /// <summary>
        /// 注册提交页面
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Reg(Users _users)
        {
            //验证用户名是否为空
            //验证密码长度是否足够
            //...

            //将数据提交到数据处理层
            //即 将用户信息提交到DAL

            int rows = new UserDAL().AddUsers(_users);
            if (rows > 0)
            {
                //注册成功(添加成功)
                return RedirectToAction("Login", "Users");
            }
            else
            {
                //注册失败(添加失败)
                throw new Exception("添加失败");
            }
        }


        /// <summary>
        /// 登录页面
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 登录提交页面
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(string name, string pwd)
        {
            return View();
        }
    }
}