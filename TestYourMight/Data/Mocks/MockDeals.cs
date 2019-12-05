using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestYourMight.Data.Interfaces;
using TestYourMight.Data.Models;

namespace TestYourMight.Data.Mocks
{
    public class MockDeals : IDeals
    {
        private readonly IGames _game = new MockGames();

        public IEnumerable<Deal> getAll
        {
            get
            {
                return new List<Deal>
                {
                    new Deal { id = 0, name = "Zahodi Poebu", desc = "Tol'ko legend", mode = "Solo", price = 300, isReal = true, Game = _game.getAll.First() },
                    new Deal { id = 1, name = "Tol'ko ne bei", desc = "huihuihui", mode = "Team", price = 50, isReal = true, Game = _game.getAll.Last() },
                    new Deal { id = 2, name = "Tretii deal", desc = "pizdapizda", mode = "Solo", price = 400, isReal = true, Game = _game.getAll.First() },
                    new Deal { id = 3, name = "4etvertii", desc = "Tol'ko govno", mode = "Team", price = 700, isReal = true, Game = _game.getAll.Last() },
                    new Deal { id = 4, name = "Piatii Poebu", desc = "Ya legend", mode = "Solo", price = 1000, isReal = true, Game = _game.getAll.First() }

                };
            }
        }

        public IEnumerable<Deal> getAllReal => throw new NotImplementedException();

        public Deal getDealById(int dealId)
        {
            throw new NotImplementedException();
        }
    }
}
