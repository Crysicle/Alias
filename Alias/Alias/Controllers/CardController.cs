using Alias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Alias.DAO;
using System.Web.Http.Cors;
using Alias.Service;

namespace Alias.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CardController : ApiController
    {
        // GET: api/Card
        public Card Get()
        {
            Card card = Services.DrawCard();
            return card;
        }
        
        // GET: api/Card/5
        public void Get(int id)
        {
            
        }

        // POST: api/Card
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Card/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Card/5
        public void Delete(int id)
        {
        }
    }
}
