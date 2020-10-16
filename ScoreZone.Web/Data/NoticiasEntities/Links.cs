using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreZone.Web.Data.NoticiasEntities
{
    public class Links
    {
        public Api api { get; set; }
        public Web web { get; set; }
        public Mobile mobile { get; set; }
        public Source source { get; set; }
    }
}
