using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;
using Teams.Models;

namespace Teams.Migrations
{


    internal sealed class Configuration : DbMigrationsConfiguration<LeagueContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(LeagueContext context)
        {
            List<LeagueTeams> teams = new List<LeagueTeams>()
            {
                new LeagueTeams() {ID=1 , Team = "Leicester City", Founded = 1884},
                new LeagueTeams() {ID=2 , Team = "Tottenham Hotspurs", Founded = 1882},
                new LeagueTeams() {ID=3 , Team = "Arsenal", Founded = 1886},
                new LeagueTeams() {ID=4 , Team = "Manchester City", Founded = 1880},
                new LeagueTeams() {ID=5 , Team = "West Ham United", Founded = 1895},
                new LeagueTeams() {ID=6 , Team = "Manchester United", Founded = 1878},
                new LeagueTeams() {ID=7 , Team = "Southampton", Founded = 1885},
                new LeagueTeams() {ID=8 , Team = "Stoke City", Founded = 1863},
                new LeagueTeams() {ID=9 , Team = "Liverpool", Founded = 1892},
                new LeagueTeams() {ID=10 , Team = "Chelsea", Founded = 1905},
                new LeagueTeams() {ID=11 , Team = "West Brom", Founded = 1878},
                new LeagueTeams() {ID=12 , Team = "Everton", Founded = 1878},
                new LeagueTeams() {ID=13 , Team = "Bournemouth", Founded = 1899},
                new LeagueTeams() {ID=14 , Team = "Watford", Founded = 1881},
                new LeagueTeams() {ID=15 , Team = "Swansea City", Founded = 1912},
                new LeagueTeams() {ID=16 , Team = "Crystal Palace", Founded = 1905},
                new LeagueTeams() {ID=17 , Team = "Norwich City", Founded = 1902},
                new LeagueTeams() {ID=18 , Team = "Sunderland", Founded = 1879},
                new LeagueTeams() {ID=19 , Team = "Newcastle United", Founded = 1892},
                new LeagueTeams() {ID=20 , Team = "Aston Villa", Founded = 1874}
            };

            teams.ForEach(t => context.Teams.Add(t));
        }
    }
}