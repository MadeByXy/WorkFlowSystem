using System.Web.Http;

namespace WorkFlowSystem.Controllers
{
    public class DemoController : ApiController
    {
        [HttpGet]
        [HttpPost]
        public string HelloWord(string username)
        {
            return $"Hello World! {username}";
        }
    }
}