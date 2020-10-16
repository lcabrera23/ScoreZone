using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreZone.Web.Data.NoticiasEntities
{
    public class DeviceRestrictions
    {
        public string type { get; set; }
        public List<string> devices { get; set; }
    }
}
