using Dapper;
using Microsoft.Extensions.Configuration;
using PersonalBlog.Common;
using PersonalBlog.Dao.response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.DataDbo
{
    public interface IBlogDataDbo {
        Task<List<BaseUserInfo>> GetBaseUserInfo();
    }
    public class BlogDataDbo : IBlogDataDbo
    {
        private readonly IGetSqlConnection _connection;

        public BlogDataDbo(IGetSqlConnection connection)
        {
            _connection = connection;
        }
        public async Task<List<BaseUserInfo>> GetBaseUserInfo()
        {
            Console.WriteLine(_connection.Connection);
            using (IDbConnection conn = _connection.Connection)
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = "select * from dbo.userinfo";
                var result= await conn.QueryAsync<BaseUserInfo>(sql);
                conn.Close();
                return result==null?new List<BaseUserInfo>():result.ToList();
            }
        }
    }

}
