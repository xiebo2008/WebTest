using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeb.Models;

namespace DAL
{

    /// <summary>
    /// 用户数据处理类
    /// </summary>
    public class UserDAL
    {
        //数据库操作对象
        SqlHelper _sqlHelper = new SqlHelper();

        //添加
        /// <summary>
        /// 添加用户
        /// </summary>
        public int AddUsers(Users _users)
        {
            //添加用户的sql语句
            string sql_add = "insert into Users values('" + _users.UserName + "','" + _users.Pwd + "','" + _users.Sex + "','" + _users.IDCard + "')";

            //调用数据库操作的方法，返回受影响行数
            int rows = _sqlHelper.ExecuteNonQuery(sql_add);

            //返回受影响行数
            return rows;


        }



        //删除
        //修改
        //查询
    }
}
