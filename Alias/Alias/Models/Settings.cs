using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alias.Models
{
    public class Settings
    {
        public int CardLength { get; set; } = 4;
        public int ModeFreq { get; set; } = 1;
        public int RoundTime { get; set; } = 60;
    }
}