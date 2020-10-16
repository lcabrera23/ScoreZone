using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreZone.Web.Data.NoticiasEntities
{
    public class Team
    {
        public int id { get; set; }
        public string description { get; set; }
        public Links4 links { get; set; }
    }
}
