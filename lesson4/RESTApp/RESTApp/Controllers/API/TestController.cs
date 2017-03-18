using System;
using System.Web.Http;

namespace RESTApp.Controllers.API
{
    public class TestController : ApiController
    {
        [HttpGet]
        public string GetDate()
        {
            return "Current date: " + DateTime.Now.ToString();
        }
    }
}
