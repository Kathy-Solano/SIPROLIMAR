using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;
using System.Net.Http;
using AttributeRouting;
using AttributeRouting.Web.Http;

namespace SiprolimarApi.Api.v1
{

    [RoutePrefix("api/clientes")]
    public class Cliente : ApiController
    {
        [GET("cliente/{id}")]
        public string GetCliente(int id)
        {
            return "Los conejillos " + id.ToString();
        }
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}