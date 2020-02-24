
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Business;
using PersonalBlog.Dao;
using PersonalBlog.Dao.response;

namespace Personal_Blog.Controllers
{
    [EnableCors]
    [Route("blog")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogBusiness _biz;
        public BlogController(IBlogBusiness biz) {
            _biz = biz;
        }
        /// <summary>
        /// 获取user的基本信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("userinfo")]
        public async  Task<CommonResponse<BaseUserInfo>> GetUserInfo()
        {
            var result =await _biz.GetUserInfo();

            return result;
        }
        [HttpGet("test")]
        public string Test()
        {
            return "test";
        }
    }
}
