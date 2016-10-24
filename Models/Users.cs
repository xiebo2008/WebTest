using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWeb.Models
{
    public class Users
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string UserName { set; get; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd { set; get; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { set; get; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string IDCard { set; get; }

        /// <summary>
        /// 学员积分
        /// </summary>
        public string Score { get; set; }
    }
}