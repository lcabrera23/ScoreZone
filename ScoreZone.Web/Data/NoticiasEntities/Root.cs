using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreZone.Web.Data.NoticiasEntities
{
    public class Root
    {
        public string header { get; set; }
        public Link link { get; set; }
        public List<Article> articles { get; set; }
    }
}
