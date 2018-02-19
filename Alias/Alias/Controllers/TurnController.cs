using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Alias.Service;
using System.Web.Http;

namespace Alias.Controllers
{
    public class TurnController : ApiController
    {
        // GET: api/Turn
        public void Get()
        {
        }

        // GET: api/Turn/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Turn
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Turn/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Turn/5
        public void Delete(int id)
        {
        }
    }
}
