using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestYourMight.Data.Models;

namespace TestYourMight.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.AllGames.Any())
                content.AllGames.AddRange(Games.Select(c => c.Value));

            if (!content.AllDeals.Any())
            {
                content.AddRange(
                    new Deal { name = "Zahodi Poebu", desc = "Tol'ko legend", mode = "Solo", price = 300, isReal = true, Game = Games["Dota 2"] },
                    new Deal { name = "Tol'ko ne bei", desc = "huihuihui", mode = "Team", price = 50, isReal = true, Game = Games["Counter-Strike: Global Offensive"] },
                    new Deal { name = "Tretii deal", desc = "pizdapizda", mode = "Solo", price = 400, isReal = true, Game = Games["Dota 2"] },
                    new Deal { name = "4etvertii", desc = "Tol'ko govno", mode = "Team", price = 700, isReal = true, Game = Games["Counter-Strike: Global Offensive"] },
                    new Deal { name = "Piatii Poebu", desc = "Ya legend", mode = "Solo", price = 1000, isReal = true, Game = Games["Dota 2"] }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Game> game;
        public static Dictionary<string, Game> Games
        {
            get
            {
                if(game == null)
                {
                    var list = new Game[]
                    {
                        new Game { gameName = "Dota 2", gameImage = "/img/dota2.jpg" },
                        new Game { gameName = "Counter-Strike: Global Offensive", gameImage = "/linkForCS:GOImage" }
                    };

                    game = new Dictionary<string, Game>();
                    foreach (Game g in list)
                        game.Add(g.gameName, g);
                }
                return game;
            }
        }
    }
}
