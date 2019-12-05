using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestYourMight.Data.Interfaces;
using TestYourMight.Data.Models;

namespace TestYourMight.Data.Repository
{
    public class DealRepository : IDeals
    {
        private readonly AppDBContent appDBContent;

        public DealRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Deal> getAll => appDBContent.AllDeals.Include(c => c.Game);

        public IEnumerable<Deal> getAllReal => appDBContent.AllDeals.Where(p => p.isReal);

        public Deal getDealById(int dealId) => appDBContent.AllDeals.FirstOrDefault(p => p.id == dealId);
    }
}
