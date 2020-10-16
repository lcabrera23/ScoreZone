using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreZone.Web.Data.NoticiasEntities
{
    public class League
    {
        public int id { get; set; }
        public string description { get; set; }
        public Links2 links { get; set; }
    }
}
