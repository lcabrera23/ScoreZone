using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreZone.Web.Data.NoticiasEntities
{
    public class Related
    {
        public List<object> images { get; set; }
        public bool premium { get; set; }
        public string description { get; set; }
        public string linkText { get; set; }
        public Links links { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string headline { get; set; }
    }
}
