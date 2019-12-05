using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestYourMight.Data.Models
{
    public class Game
    {
        public int id { set; get; }
        public string gameName { set; get; }
        public string gameImage { set; get; }
        public List<Deal> dealList { set; get; }
    }
}
