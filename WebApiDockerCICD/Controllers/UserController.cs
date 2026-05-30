using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDockerCICD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        /// <summary>
        /// Get User Name
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetUser()
        {
            return "Hello World Get UserName 获取用户名称";
        }

        [HttpGet]
        [Route("GetUserDetails")]
        public string GetUserDetails()
        {
            return "Hello World Get User Details 获取用户详情333";
        }

        [HttpPost]
        public string GetUserDetailsById(int id)
        {
            return $"Hello World Get User Details By Id 获取用户详情通过ID: {id}";
        }
    }
}
