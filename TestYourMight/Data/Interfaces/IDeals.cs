using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestYourMight.Data.Models;

namespace TestYourMight.Data.Interfaces
{
    public interface IDeals
    {
        IEnumerable<Deal> getAll { get; }
        IEnumerable<Deal> getAllReal { get; }
        Deal getDealById(int dealId);
    }
}
