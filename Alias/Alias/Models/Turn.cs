using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Alias.Utility;

namespace Alias.Models
{
    public class Turn
    {
        public int Order { get; set; } = 0;
        public double Time { get; set; }
        public int Dice { get; set; } = 1;

        public List<Card> FailedCards { get; set; } = new List<Card>();
        public List<Card> CorrectCards { get; set; } = new List<Card>();

        public Enums.WordType WordType { get; set; } = Enums.WordType.regular;
        public List<Word> WordList { get; set; }

        public Team Team { get; set; } = new Team();
        public int Score { get; set; } = 0;
    }
}