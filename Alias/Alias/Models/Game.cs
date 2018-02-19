using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Alias.DAO;

namespace Alias.Models
{
    public class Game
    {
        public List<Word> Words { get; set; } = new List<Word>();
        public Settings Settings { get; set; } = new Settings();
        public List<Team> TeamList { get; set; } = new List<Team>();
    }
}