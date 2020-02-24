using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.Dao.response
{
    public class BaseUserInfo
{
    public string UserName { get; set; }
        public string UserPassword { get; set; }
        [System.ComponentModel.DataAnnotations.Key]
        public string UserPhone { get; set; }
        public string UserSculptrue { get; set; }
        public string LastEditUser { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }      
        public DateTime? LastEditDate { get; set; }
    }
}
