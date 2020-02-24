using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PersonalBlog.Dao
{
    public class CommonResponse<T>  : BaseResponse
    {

        public T ResponseEntity { get; set; }
        public List<T> ResponseEntityList = new List<T>();
        public int? TotalCount { get; set; }
        public bool Succeed { get; set; } = true;
        public string ResponseCode { get; set; } = "200";
        public string ErrorMessage { get ; set; }
    }
}
