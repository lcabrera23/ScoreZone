using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreZone.Web.Data.NoticiasEntities
{
    public class Source
    {
        public Mezzanine mezzanine { get; set; }
        public Flash flash { get; set; }
        public Hds hds { get; set; }
        public HLS HLS { get; set; }
        public HD2 HD { get; set; }
        public Full full { get; set; }
        public string href { get; set; }
    }

    //public class Mezzanine
    //{
    //    public string href { get; set; }
    //}
    //public class Flash: Mezzanine { }
    //public class Hds : Mezzanine { }
    //public class HLS : Mezzanine { }
    //public class HD2 : Mezzanine { }
    //public class Full : Mezzanine { }

}
