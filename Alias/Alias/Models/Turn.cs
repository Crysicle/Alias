using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Alias.Utility;

namespace Alias.Models
{
    public class Turn
    {
        public int Dice { get; set; } = 1;
        public List<Card> FailedCards { get; set; } = new List<Card>();
        public Enums.WordType WordType { get; set; } = Enums.WordType.regular;
        public List<Word> UsableWords { get; set; }
        public int score { get; set; } = 0;
    }
}