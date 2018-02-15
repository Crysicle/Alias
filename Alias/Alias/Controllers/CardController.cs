using Alias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Alias.Controllers
{
    public class CardController : ApiController
    {
        Word enkapsuliacija = new Word { Value = "enkapsuliacija", Description = "obejktinio programavimo principas" };
        Word jura = new Word { Value = "jura", Description = "didelis suraus vandens telkinys" };
        Word apelsinas = new Word { Value = "apelsinas", Description = "oranzines spalvos vaisius" };
        Word sepuku = new Word { Value = "sepuku", Description = "japonu atliekamas ritualas/ harahiri" };
        List<Word> WordList = new List<Word>();
        // GET: api/Card
        public Card Get()
        {

            Card assholes = new Card { WordList = Atranka() };
            return assholes;
        }

        
        public List<Word> Atranka()
        {
            List<Word> neatrinkti = new List<Word> { enkapsuliacija, jura, apelsinas, sepuku };
            Random r = new Random();
            
            List<Word> Zodziai = new List<Word>();
            int p;
            for (int i = 0; i < 2; i++)
            {
                p = r.Next(0, neatrinkti.Count());
                Zodziai.Add(neatrinkti[p]);
                neatrinkti.RemoveAt(p);
            }

            return Zodziai;

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
