using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Alias.Models;
using Alias.DAO;
using Alias.Utility;


namespace Alias.Service
{
    public static class Services
    {
        public static Game game = new Game();
        public static Turn turn = new Turn();
        public static Card card = new Card();
        static Random r = new Random();

        public static void NewGame()
        {
            game = new Game();
            turn = new Turn();
            card = new Card();
        }//++
        
        static Enums.WordType TurnWordType()
        {
            Enums.WordType wordType = new Enums.WordType();
            if (turn.Team.Score % game.Settings.ModeFreq == 0)//&& turn.Team.Score != 0)
            {
                int number = r.Next(1, Enum.GetNames(typeof(Enums.WordType)).Length);
                wordType = (Enums.WordType)number;
            }
            else
                wordType = Enums.WordType.regular;
            return wordType;
        }//patikrinti random.next(1,1) ir (myEnum)int

        public static void NextTurn()
        {
            turn.Team.Score += turn.Score;
            turn.Order++;
            turn.Team = game.TeamList[(turn.Order) % game.TeamList.Count];
            turn.WordType = TurnWordType();
            turn.Score = 0;
            turn.Time = game.Settings.RoundTime;
            turn.WordList = game.Words.Where(w => w.WordType == turn.WordType).ToList();
            if (game.Settings.CardLength > turn.WordList.Count)
            {
                game.Words = new WordsDAO().Get();
                turn.WordList = game.Words.Where(w => w.WordType == turn.WordType).ToList();
            }
        }//++

        public static Card DrawCard()
        {
            Card Card = new Card();
            for (int i = 0; i < game.Settings.CardLength; i++)
            {
                Word word = turn.WordList[r.Next(0, turn.WordList.Count)];
                Card.WordList.Add(word);
                turn.WordList.Remove(word);
                game.Words.Remove(word);
            }
            return Card;
        }//++
    }
}