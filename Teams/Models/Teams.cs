using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Teams.Models
{
    public class LeagueTeams
    {
        public int ID { get; set; }
        public string Team { get; set; }
        public int Founded { get; set; }
       // public string Logo { get; set; }
    }

    public class LeagueContext : DbContext
    {
        public DbSet<LeagueTeams> Teams { get; set; }

        public LeagueContext() : base("TeamConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    }
}