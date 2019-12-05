using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestYourMight.Data.Interfaces;
using TestYourMight.Data.Models;

namespace TestYourMight.Data.Mocks
{
    public class MockGames : IGames
    {
        public IEnumerable<Game> getAll
        {
            get
            {
                return new List<Game>
                {
                    new Game { id = 0, gameName = "Dota 2", gameImage = "/img/dota2.jpg" },
                    new Game { id = 1, gameName = "Counter-Strike: Global Offensive", gameImage = "/linkForCS:GOImage" }
                };
            }
        }
    }
}
