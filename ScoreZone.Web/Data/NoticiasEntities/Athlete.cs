using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreZone.Web.Data.NoticiasEntities
{
    public class Athlete
    {
        public int id { get; set; }
        public string description { get; set; }
        public Links3 links { get; set; }
    }
}
