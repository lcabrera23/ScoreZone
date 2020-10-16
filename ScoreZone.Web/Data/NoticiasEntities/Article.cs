using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreZone.Web.Data.NoticiasEntities
{
    public class Article
    {
        public List<Image> images { get; set; }
        public string description { get; set; }
        public Links links { get; set; }
        public List<Category> categories { get; set; }
        public string headline { get; set; }
    }
}
