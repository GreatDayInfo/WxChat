using Microsoft.AspNetCore.Mvc;

namespace aspnetapp.Controllers
{
    [Route("api/wechat")]
    [ApiController]
    public class WeChatController : Controller
    {
        [HttpPost("fs")]
        public async Task<object> GetToken()
        {
            return await new HttpClient().GetAsync("http://api.weixin.qq.com/wxa/getwxadevinfo");
        }
    }
    
}
