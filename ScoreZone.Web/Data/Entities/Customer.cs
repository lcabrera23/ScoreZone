using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreZone.Web.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        public User User { get; set; }
    }
}
