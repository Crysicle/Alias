using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Alias.Context;
using Alias.Models;

namespace Alias.DAO
{
    public class WordsDAO
    {
        public List<Word> Get()
        {
            using (var Context = new WordsContext())
            {
                return Context.Words.ToList();
            }
        }
    }
}