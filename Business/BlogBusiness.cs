using PersonalBlog.DataDbo;
using PersonalBlog.Dao;
using PersonalBlog.Dao.response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace PersonalBlog.Business
{
    public interface IBlogBusiness
    {
        Task<CommonResponse<BaseUserInfo>> GetUserInfo();
    }
    public class BlogBusiness : IBlogBusiness
    {
        private readonly IBlogDataDbo _dao;
        public BlogBusiness(IBlogDataDbo dao)
        {
            _dao = dao;
        }
        public async Task<CommonResponse<BaseUserInfo>> GetUserInfo()
        {
            CommonResponse<BaseUserInfo> commonResponse = new CommonResponse<BaseUserInfo>();
            commonResponse.ResponseEntity = new BaseUserInfo();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    Console.WriteLine("dsasdasdyashduqw3u8");
                    commonResponse.ResponseEntityList = await _dao.GetBaseUserInfo();
                    scope.Complete();
                }
            }
            catch (Exception e)
            {
                commonResponse.ErrorMessage = e.Message;
            }
            return commonResponse;
        }
    }
}
