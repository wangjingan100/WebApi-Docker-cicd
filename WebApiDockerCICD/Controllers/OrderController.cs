using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDockerCICD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        /// <summary>
        /// Get Order Details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetOrder()
        {
            return "Hello World Get Order Details 获取订单详情";
        }

        [HttpGet]
        [Route("GetOrderDetails")]
        public string GetOrderDetails() {
            return "Hello World Get Order Details 获取订单详情";
        }
    }
}
