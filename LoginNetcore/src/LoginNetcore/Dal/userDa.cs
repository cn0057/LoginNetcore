using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace LoginNetcore.Dal
{
//hello
    public class userDa
    {
        /// <summary>
        /// 登陆账号
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Model.user login(string username, string password)
        {
            string sql = "select * from tb_user where username=@username and password=@password";
            using (var connection = Dbconnect.GetOpenConnection())
            {
                var m = connection.Query<Model.user>(sql, new { username = username, password = password }).FirstOrDefault();
                return m;
            }
        }
        
        public int register(string username,string password)
        {
            string sql = "insert into tb_user (username,password) values (@username,@password)";
            using (var connection = Dbconnect.GetOpenConnection())
            {
                if (username == null || password == null)
                {
                    return 0;
                }
                else
                {
                    var m = connection.Execute(sql, new { username = username, password = password });

                    return m;
                }
            }
        }
    }
}
