﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Alias.Service;

namespace Alias.Controllers
{
    public class GameController : ApiController
    {
        // GET: api/Game
        public void Get()
        {
            Services.NewGame();
        }

        // GET: api/Game/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Game
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Game/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Game/5
        public void Delete(int id)
        {
        }
    }
}
