using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Alias.Models;
using Alias.DAO;
using Alias.Utility;

namespace Alias.Service
{
    public class CardService
    {
        Game game = new Game();
        TurnService TurnService = new TurnService();
        Turn turn;
        public void SetTurn()
        {
            turn = TurnService.NextTurn();
        }

        public Card DrawCard()
        {
            try
            {
                turn.UsableWords = game.Words.Where(w => w.WordType == turn.WordType).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception at Service.CardService.DrawCard()"+ex.Data);
                //nieko console neatraso
                return null;
            }
            
            Card Card = new Card();
            Random r = new Random();

            int p;
            for (int i = 0; i < game.Settings.CardLength; i++)
            {
                Word word;
                word = turn.UsableWords[r.Next(0, turn.UsableWords.Count())];

                Card.WordList.Add(word);
                turn.UsableWords.Remove(word);
                game.Words.Remove(word);
            }
            
            return Card;
        }
    }
}