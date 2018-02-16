using Alias.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Alias.Context
{
    public class WordsContext : DbContext
    {
        public DbSet<Word> Words { get; set; }
    }
}