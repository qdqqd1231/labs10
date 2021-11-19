using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigGame
{
    class Team
    {
        public string country;
        public string[] players;
        public IGame game;
        public Team(string country, string[] players, IGame game)
        {
            this.country = country;
            this.players = players;
            this.game = game;
        }
        public void PlayGame()
        {
            Console.Write($"{country} --> ");
            game.PlayGame();
        }
    }
}
