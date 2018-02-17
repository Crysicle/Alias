using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Alias.Models;
using Alias.Utility;

namespace Alias.Service
{
    public class TurnService
    {
        public Turn NextTurn()
        {
            Turn turn = new Turn();
            turn.WordType = Enums.WordType.celebrity;
            return turn;
        }
    }
}