using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestYourMight.Data.Models;

namespace TestYourMight.ViewModels
{
    public class DealsListViewModel
    {
        public IEnumerable<Deal> AllDeals { get; set; }

        public string currGame { get; set; }
    }
}
