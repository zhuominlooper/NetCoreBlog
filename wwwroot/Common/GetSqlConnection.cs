using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.Common
{
    public interface IGetSqlConnection
    {
        IDbConnection Connection { get; }
    }
    public class GetSqlConnection : IGetSqlConnection
    {
        private readonly IConfiguration _config;

        public GetSqlConnection(IConfiguration config)
        {
            _config = config;
        }
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("MyConnectionString"));
            }
        }
    }
}
