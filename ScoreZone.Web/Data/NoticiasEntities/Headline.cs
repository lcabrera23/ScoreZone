using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreZone.Web.Data.NoticiasEntities
{
    public class Headline
    {
        public List<object> keywords { get; set; }
        public string description { get; set; }
        public List<Video> video { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public string nowId { get; set; }
        public bool premium { get; set; }
        public List<Related> related { get; set; }
        public bool allowSearch { get; set; }
        public Links links { get; set; }
        public int id { get; set; }
        public List<Category> categories { get; set; }
        public string headline { get; set; }
        public string byline { get; set; }
        public DateTime originallyPosted { get; set; }
        public List<Image> images { get; set; }
        public bool allowCommerce { get; set; }
        public string linkText { get; set; }
        public bool allowAMP { get; set; }
        public DateTime published { get; set; }
        public bool allowComments { get; set; }
        public bool allowAds { get; set; }
        public DateTime lastModified { get; set; }
        public List<Metric> metrics { get; set; }
    }
}
