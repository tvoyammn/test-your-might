using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestYourMight.Data.Models;

namespace TestYourMight.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) {
        
        }

        public DbSet<Deal> AllDeals { get; set; }
        public DbSet<Game> AllGames { get; set; }
    }
}
