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
        CardService wordService = new CardService();
        // GET: api/Card
        public Card Get()
        {
            Card card = wordService.DrawCard();
            return card;
        }
        
        // GET: api/Card/5
        public string Get(int id)
        {
            return "value";
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
