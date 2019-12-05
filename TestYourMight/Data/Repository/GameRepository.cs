using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestYourMight.Data.Interfaces;
using TestYourMight.Data.Models;

namespace TestYourMight.Data.Repository
{
    public class GameRepository : IGames
    {
        private readonly AppDBContent appDBContent;

        public GameRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Game> getAll => appDBContent.AllGames;
    }
}
