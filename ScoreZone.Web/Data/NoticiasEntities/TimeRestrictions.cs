using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreZone.Web.Data.NoticiasEntities
{
    public class TimeRestrictions
    {
        public string sportName { get; set; }
        public string leagueName { get; set; }
        public string coverageType { get; set; }
        public string trackingName { get; set; }
        public string trackingId { get; set; }
        public DateTime embargoDate { get; set; }
        public DateTime expirationDate { get; set; }
    }
}
