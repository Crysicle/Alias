using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Alias.Utility;

namespace Alias.Models
{
    public class Word
    {
        public int WordId { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public Enums.WordType WordType {get;set;}
    }
}