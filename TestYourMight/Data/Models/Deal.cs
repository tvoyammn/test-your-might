using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestYourMight.Data.Models
{
/*    enum MatchCategory
    {
        Solo,
        Team
    }*/

    public class Deal
    {
        public int id { set; get; }
        public string name { set; get; }
        public string desc { set; get; }
        public string mode { set; get; }
        public ushort price { set; get; }
        public bool isReal { set; get; }
        public int gameID { set; get; }
        public virtual Game Game { set; get; }
    }
}
