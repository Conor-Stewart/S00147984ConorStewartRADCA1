using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Teams.Models
{
    public class LeagueTeams
    {
        [Key]
        public int ID { get; set; }
        public string Team { get; set; }
        public int Founded { get; set; }
        public string Manager { get; set; }
        public string NickNames { get; set; }
        public string Stadium { get; set; }
        public int StadiumCapacity { get; set; }
        public int ChampionsLeague { get; set; }
        public int PremierLeague { get; set; }
        public int FaCup { get; set; }
        public int LeagueCup { get; set; }
        public int CommunityShield { get; set; }
        public string HomeColours { get; set; }
        public string AwayColours { get; set; }
        public string ThirdColours { get; set; }
        public string KitMaker { get; set; }
    }

    class TeamDB : DbContext
    {
        public DbSet<LeagueTeams> Teams { get; set; }

        public TeamDB()
            : base("S00147984Database")
        { }
    } 
}