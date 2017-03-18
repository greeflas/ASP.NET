using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Net;
using System;

namespace RESTApp.Controllers.API
{
    public class FruitController : ApiController
    {
        static List<string> _fruits = new List<string>()
        {
            "Orange",
            "Apple",
            "Lime"
        };

        public List<string> GetAll()
        {
            return _fruits;
        }

        public HttpResponseMessage Get(int id)
        {
            if (id > _fruits.Count || id < 0)
            {
                // Status code 404
                return Request.CreateResponse(HttpStatusCode.NotFound, "Fruit not found");
            }

            // Status code 200
            return Request.CreateErrorResponse(HttpStatusCode.OK, _fruits[id]);
        }

        public HttpResponseMessage Post(string fruit)
        {
            _fruits.Add(fruit);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, fruit);
            response.Headers.Location = new Uri(Request.RequestUri + "/" + (_fruits.Count - 1));

            return response;
        }
    }
}
