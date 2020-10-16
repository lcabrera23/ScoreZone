using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreZone.Web.Data.NoticiasEntities
{
    public class Root2
    {
        public int resultsOffset { get; set; }
        public int resultsCount { get; set; }
        public List<Headline> headlines { get; set; }
        public int resultsLimit { get; set; }
        public DateTime timestamp { get; set; }
        public string status { get; set; }
    }
}
