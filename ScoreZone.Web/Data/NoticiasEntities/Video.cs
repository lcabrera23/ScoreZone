using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreZone.Web.Data.NoticiasEntities
{
    //public class Ad
    //{
    //    public string sport { get; set; }
    //    public string bundle { get; set; }
    //}

    //public class Tracking
    //{
    //    public string sportName { get; set; }
    //    public string leagueName { get; set; }
    //    public string coverageType { get; set; }
    //    public string trackingName { get; set; }
    //    public string trackingId { get; set; }
    //}

    //public class TimeRestrictions
    //{
    //    public DateTime embargoDate { get; set; }
    //    public DateTime expirationDate { get; set; }
    //}

    //public class DeviceRestrictions
    //{
    //    public string type { get; set; }
    //    public List<string> devices { get; set; }
    //}

    //public class GeoRestrictions
    //{
    //    public string type { get; set; }
    //    public List<string> countries { get; set; }
    //}

    //public class Leagues
    //{
    //}

    //public class Api
    //{
    //    public Leagues leagues { get; set; }
    //}

    //public class Leagues2
    //{
    //    public string href { get; set; }
    //}

    //public class Web
    //{
    //    public Leagues2 leagues { get; set; }
    //}

    //public class Leagues3
    //{
    //    public string href { get; set; }
    //}

    //public class Mobile
    //{
    //    public Leagues3 leagues { get; set; }
    //}

    //public class Links
    //{
    //    public Api api { get; set; }
    //    public Web web { get; set; }
    //    public Mobile mobile { get; set; }
    //}

    //public class League
    //{
    //    public int id { get; set; }
    //    public string description { get; set; }
    //    public Links links { get; set; }
    //}

    //public class Teams
    //{
    //}

    //public class Api2
    //{
    //    public Teams teams { get; set; }
    //}

    //public class Teams2
    //{
    //    public string href { get; set; }
    //}

    //public class Web2
    //{
    //    public Teams2 teams { get; set; }
    //}

    //public class Teams3
    //{
    //    public string href { get; set; }
    //}

    //public class Mobile2
    //{
    //    public Teams3 teams { get; set; }
    //}

    //public class Links2
    //{
    //    public Api2 api { get; set; }
    //    public Web2 web { get; set; }
    //    public Mobile2 mobile { get; set; }
    //}

    //public class Team
    //{
    //    public int id { get; set; }
    //    public string description { get; set; }
    //    public Links2 links { get; set; }
    //}

    //public class Athletes
    //{
    //}

    //public class Api3
    //{
    //    public Athletes athletes { get; set; }
    //}

    //public class Athletes2
    //{
    //    public string href { get; set; }
    //}

    //public class Web3
    //{
    //    public Athletes2 athletes { get; set; }
    //}

    //public class Athletes3
    //{
    //    public string href { get; set; }
    //}

    //public class Mobile3
    //{
    //    public Athletes3 athletes { get; set; }
    //}

    //public class Links3
    //{
    //    public Api3 api { get; set; }
    //    public Web3 web { get; set; }
    //    public Mobile3 mobile { get; set; }
    //}

    //public class Athlete
    //{
    //    public int id { get; set; }
    //    public string description { get; set; }
    //    public Links3 links { get; set; }
    //}

    //public class Category
    //{
    //    public int id { get; set; }
    //    public string description { get; set; }
    //    public string type { get; set; }
    //    public int sportId { get; set; }
    //    public int leagueId { get; set; }
    //    public League league { get; set; }
    //    public string uid { get; set; }
    //    public int? teamId { get; set; }
    //    public Team team { get; set; }
    //    public int? athleteId { get; set; }
    //    public Athlete athlete { get; set; }
    //}

    public class Default
    {
        public string href { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Full
    {
        public string href { get; set; }
    }

    public class Wide
    {
        public string href { get; set; }
    }

    public class Square
    {
        public string href { get; set; }
    }

    //public class PosterImages
    //{
    //    public Default @default { get; set; }
    //    public Full full { get; set; }
    //    public Wide wide { get; set; }
    //    public Square square { get; set; }
    //}

    //public class Image
    //{
    //    public string name { get; set; }
    //    public string url { get; set; }
    //    public string alt { get; set; }
    //    public string caption { get; set; }
    //    public string credit { get; set; }
    //    public int width { get; set; }
    //    public int height { get; set; }
    //}

    //public class Self
    //{
    //    public string href { get; set; }
    //}

    public class Artwork
    {
        public string href { get; set; }
    }

    //public class Api4
    //{
    //    public Self self { get; set; }
    //    public Artwork artwork { get; set; }
    //}

    //public class Short
    //{
    //    public string href { get; set; }
    //}

    public class Self2
    {
        public string href { get; set; }
    }

    //public class Web4
    //{
    //    public string href { get; set; }
    //    public Short @short { get; set; }
    //    public Self2 self { get; set; }
    //}

    public class Mezzanine
    {
        public string href { get; set; }
    }

    public class Flash
    {
        public string href { get; set; }
    }

    public class Hds
    {
        public string href { get; set; }
    }

    public class HD
    {
        public string href { get; set; }
    }

    public class HLS
    {
        public string href { get; set; }
        public HD HD { get; set; }
    }

    public class HD2
    {
        public string href { get; set; }
    }

    public class Full2
    {
        public string href { get; set; }
    }

    //public class Source
    //{
    //    public Mezzanine mezzanine { get; set; }
    //    public Flash flash { get; set; }
    //    public Hds hds { get; set; }
    //    public HLS HLS { get; set; }
    //    public HD2 HD { get; set; }
    //    public Full2 full { get; set; }
    //    public string href { get; set; }
    //}

    public class Alert
    {
        public string href { get; set; }
    }

    public class Source2
    {
        public string href { get; set; }
    }

    public class Streaming
    {
        public string href { get; set; }
    }

    public class ProgressiveDownload
    {
        public string href { get; set; }
    }

    //public class Mobile4
    //{
    //    public Alert alert { get; set; }
    //    public Source2 source { get; set; }
    //    public string href { get; set; }
    //    public Streaming streaming { get; set; }
    //    public ProgressiveDownload progressiveDownload { get; set; }
    //}

    //public class Links4
    //{
    //    public Api4 api { get; set; }
    //    public Web4 web { get; set; }
    //    public Source source { get; set; }
    //    public Mobile4 mobile { get; set; }
    //}

    public class Video
    {
        public string source { get; set; }
        public int id { get; set; }
        public string headline { get; set; }
        public string caption { get; set; }
        public string description { get; set; }
        public bool premium { get; set; }
        public Ad ad { get; set; }
        public Tracking tracking { get; set; }
        public string cerebroId { get; set; }
        public DateTime lastModified { get; set; }
        public DateTime originalPublishDate { get; set; }
        public TimeRestrictions timeRestrictions { get; set; }
        public DeviceRestrictions deviceRestrictions { get; set; }
        public GeoRestrictions geoRestrictions { get; set; }
        public bool syndicatable { get; set; }
        public int duration { get; set; }
        public List<Category> categories { get; set; }
        public List<object> keywords { get; set; }
        public PosterImages posterImages { get; set; }
        public List<Image> images { get; set; }
        public string thumbnail { get; set; }
        public Links4 links { get; set; }
        public string title { get; set; }
    }

}
