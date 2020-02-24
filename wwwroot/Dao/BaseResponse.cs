using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.Dao
{
    public interface BaseResponse
    {
         bool Succeed { get; set; }
         string ResponseCode { get; set; }
         string ErrorMessage { get; set; }
}
}
