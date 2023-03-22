using Microsoft.AspNetCore.Mvc;
namespace ConsoleToWebAPI.Controller
{
    [ApiController]
    [Route("NewApi/[action]")]
    public class NewController: ControllerBase
    {
        public string Something()
        {
            return "Console Api Working";
        }
    }
}
