﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreZone.Web.Data.NoticiasEntities
{
    public class Category
    {
        public int id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public int sportId { get; set; }
        public int leagueId { get; set; }
        public League league { get; set; }
        public string uid { get; set; }
        public DateTime createDate { get; set; }
        public int? athleteId { get; set; }
        public Athlete athlete { get; set; }
        public int? teamId { get; set; }
        public Team team { get; set; }
        public int? topicId { get; set; }
        public string guid { get; set; }
    }
}
