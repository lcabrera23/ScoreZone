using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreZone.Web.Data.NoticiasEntities
{
    public class Image
    {
        public string name { get; set; }
        public int width { get; set; }
        public string alt { get; set; }
        public string caption { get; set; }
        public string url { get; set; }
        public int height { get; set; }
        public int? id { get; set; }
        public string credit { get; set; }
        public string type { get; set; }
    }
}
