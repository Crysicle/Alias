using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alias.Models
{
    public class Team
    {
        public string Name { get; set; } = "default team";
        ConsoleColor Color { get; set; } = ConsoleColor.White;
        public int Score { get; set; } = 0;
    }
}