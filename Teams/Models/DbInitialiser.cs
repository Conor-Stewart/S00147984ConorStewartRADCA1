using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;
using Teams.Models;
using System.Data.Entity;

namespace Teams.Models
{


    class DbInitialiser : DropCreateDatabaseAlways<TeamDB>
    {

        protected override void Seed(TeamDB context)
        {
            #region Seed Teams
            var teams = new List<LeagueTeams>()
            {
                new LeagueTeams()
                {
                    ID = 1,
                    Team = "Leicester City",
                    Founded = 1884,
                    Manager = "Claudio Ranieri",
                    NickNames = "The Foxes",
                    Stadium = "King Power Stadium",
                    StadiumCapacity = 32262,
                    ChampionsLeague = 0,
                    PremierLeague = 0,
                    FaCup = 0,
                    LeagueCup = 3,
                    CommunityShield = 1,
                    HomeColours = "Blue",
                    AwayColours = "Black",
                    ThirdColours = "White",
                    KitMaker = "Puma"
                },

                new LeagueTeams()
                {
                    ID = 2,
                    Team = "Tottenham Hotspurs",
                    Founded = 1882,
                    Manager = "Mauricio Pchettino",
                    NickNames = "Yids",
                    Stadium = "White Hart Lane",
                    StadiumCapacity = 36284,
                    ChampionsLeague = 0,
                    PremierLeague = 2,
                    FaCup = 8,
                    LeagueCup = 4,
                    CommunityShield = 7,
                    HomeColours = "White & Blue",
                    AwayColours = "Blue & Black",
                    ThirdColours = "Purple",
                    KitMaker = "Under Armour"
                },

                new LeagueTeams()
                {
                    ID = 3,
                    Team = "Arsenal",
                    Founded = 1886,
                    Manager = "Arsène Wenger",
                    NickNames = "The Gunners",
                    Stadium = "Emirates Stadium",
                    StadiumCapacity = 60260,
                    ChampionsLeague = 0,
                    PremierLeague = 13,
                    FaCup = 12,
                    LeagueCup = 2,
                    CommunityShield = 14,
                    HomeColours = "Red & White",
                    AwayColours = "Gold & Blue",
                    ThirdColours = "Black",
                    KitMaker = "Nike"
                },

                new LeagueTeams()
                {
                    ID = 4,
                    Team = "Manchester City",
                    Founded = 1880,
                    Manager = "Manuel Pelligrini",
                    NickNames = "The Citizens",
                    Stadium = "The Etihad",
                    StadiumCapacity = 55097,
                    ChampionsLeague = 0,
                    PremierLeague = 4,
                    FaCup = 5,
                    LeagueCup = 4,
                    CommunityShield = 4,
                    HomeColours = "Blue & White",
                    AwayColours = "Dark Blue",
                    ThirdColours = "Yellow",
                    KitMaker = "Nike"
                },

                new LeagueTeams()
                {
                    ID = 5,
                    Team = "West Ham United",
                    Founded = 1895,
                    Manager = "Slaven Bilić",
                    NickNames = "The Hammers",
                    Stadium = "Olympic Ground",
                    StadiumCapacity = 35016,
                    ChampionsLeague = 0,
                    PremierLeague = 0,
                    FaCup = 3,
                    LeagueCup = 0,
                    CommunityShield = 1,
                    HomeColours = "Purple & White",
                    AwayColours = "Blue",
                    ThirdColours = "Dark Blue",
                    KitMaker = "Adidas"
                },

                new LeagueTeams()
                {
                    ID = 6,
                    Team = "Manchester United",
                    Founded = 1878,
                    Manager = "Louis Van Gaal",
                    NickNames = "The Red Devils",
                    Stadium = "Old Trafford",
                    StadiumCapacity = 75653,
                    ChampionsLeague = 3,
                    PremierLeague = 20,
                    FaCup = 11,
                    LeagueCup = 4,
                    CommunityShield = 20,
                    HomeColours = "Red & White",
                    AwayColours = "White & Black",
                    ThirdColours = "Black",
                    KitMaker = "Adidas"
                },
                new LeagueTeams()
                {
                    ID = 7,
                    Team = "Southampton",
                    Founded = 1885,
                    Manager = "Ronald Koeman",
                    NickNames = "The Saints",
                    Stadium = "St Mary's Stadium",
                    StadiumCapacity = 32505,
                    ChampionsLeague = 0,
                    PremierLeague = 0,
                    FaCup = 1,
                    LeagueCup = 0,
                    CommunityShield = 0,
                    HomeColours = "Red, White & Black",
                    AwayColours = "Green & Blue",
                    ThirdColours = "None",
                    KitMaker = "Adidas"
                },

                new LeagueTeams()
                {
                    ID = 8,
                    Team = "Stoke City",
                    Founded = 1863,
                    Manager = "Mark Hughes",
                    NickNames = "The Potters",
                    Stadium = "Britannia Stadium",
                    StadiumCapacity = 1,
                    ChampionsLeague = 0,
                    PremierLeague = 0,
                    FaCup = 0,
                    LeagueCup = 1,
                    CommunityShield = 0,
                    HomeColours = "Red & White",
                    AwayColours = "Black",
                    ThirdColours = "White",
                    KitMaker = "New Balance"
                },

                new LeagueTeams()
                {
                    ID = 9,
                    Team = "Liverpool",
                    Founded = 1892,
                    Manager = "Jurgen Klopp",
                    NickNames = "The Reds",
                    Stadium = "Anfield",
                    StadiumCapacity = 45276,
                    ChampionsLeague = 5,
                    PremierLeague = 18,
                    FaCup = 7,
                    LeagueCup = 8,
                    CommunityShield = 15,
                    HomeColours = "Red",
                    AwayColours = "White",
                    ThirdColours = "Black",
                    KitMaker = "Warrior"
                },

                new LeagueTeams()
                {
                    ID = 10,
                    Team = "Chelsea",
                    Founded = 1905,
                    Manager = "Guus Hiddink",
                    NickNames = "The Thugs",
                    Stadium = "Stamford Bridge",
                    StadiumCapacity = 41663,
                    ChampionsLeague = 1,
                    PremierLeague = 5,
                    FaCup = 7,
                    LeagueCup = 5,
                    CommunityShield = 4,
                    HomeColours = "Blue",
                    AwayColours = "White",
                    ThirdColours = "Black",
                    KitMaker = "Adidas"
                },

                new LeagueTeams()
                {
                    ID = 11,
                    Team = "West Brom",
                    Founded = 1878,
                    Manager = "Tony Pulis",
                    NickNames = "The Baggies",
                    Stadium = "The Hawthorns",
                    StadiumCapacity = 26850,
                    ChampionsLeague = 0,
                    PremierLeague = 1,
                    FaCup = 5,
                    LeagueCup = 1,
                    CommunityShield = 2,
                    HomeColours = "Blue & White",
                    AwayColours = "Red & Black",
                    ThirdColours = "None",
                    KitMaker = "Adidas"
                },

                new LeagueTeams()
                {
                    ID = 12,
                    Team = "Everton",
                    Founded = 1878,
                    Manager = "Roberto Martínez",
                    NickNames = "The Toffees",
                    Stadium = "Goodison Park",
                    StadiumCapacity = 40157,
                    ChampionsLeague = 0,
                    PremierLeague = 9,
                    FaCup = 5,
                    LeagueCup = 0,
                    CommunityShield = 9,
                    HomeColours = "Blue & White",
                    AwayColours = "White & Black",
                    ThirdColours = "Green & Black",
                    KitMaker = "Umbro"
                },

                new LeagueTeams()
                {
                    ID = 13,
                    Team = "AFC Bournemouth",
                    Founded = 1899,
                    Manager = "Eddie Howe",
                    NickNames = "The Cherries",
                    Stadium = "Dean Court",
                    StadiumCapacity = 11464,
                    ChampionsLeague = 0,
                    PremierLeague = 0,
                    FaCup = 0,
                    LeagueCup = 0,
                    CommunityShield = 0,
                    HomeColours = "Red & Black",
                    AwayColours = "Blue & Black",
                    ThirdColours = "Pink",
                    KitMaker = "Unknown"
                },

                new LeagueTeams()
                {
                    ID = 14,
                    Team = "Watford",
                    Founded = 1881,
                    Manager = "	Quique Sánchez Flores",
                    NickNames = "The Hornets",
                    Stadium = "Vicarage Road",
                    StadiumCapacity = 21577,
                    ChampionsLeague = 0,
                    PremierLeague = 0,
                    FaCup = 0,
                    LeagueCup = 0,
                    CommunityShield = 0,
                    HomeColours = "Yellow & Black",
                    AwayColours = "Black",
                    ThirdColours = "None",
                    KitMaker = "Puma"
                },

                new LeagueTeams()
                {
                    ID = 15,
                    Team = "Swansea City",
                    Founded = 1912,
                    Manager = "Francesco Guidolin",
                    NickNames = "The Swans",
                    Stadium = "Liverty Stadium",
                    StadiumCapacity = 20937,
                    ChampionsLeague = 0,
                    PremierLeague = 0,
                    FaCup = 0,
                    LeagueCup = 1,
                    CommunityShield = 0,
                    HomeColours = "White",
                    AwayColours = "Green & Blue",
                    ThirdColours = "None",
                    KitMaker = "Adidas"
                },

                new LeagueTeams()
                {
                    ID = 16,
                    Team = "Crystal Palace",
                    Founded = 1905,
                    Manager = "Alan Pardew",
                    NickNames = "The Eagles",
                    Stadium = "Selhurst Park",
                    StadiumCapacity = 26255,
                    ChampionsLeague = 0,
                    PremierLeague = 0,
                    FaCup = 0,
                    LeagueCup = 0,
                    CommunityShield = 0,
                    HomeColours = "Blue & Red",
                    AwayColours = "White",
                    ThirdColours = "None",
                    KitMaker = "Unknown"
                },

                new LeagueTeams()
                {
                    ID = 17,
                    Team = "Norwich City",
                    Founded = 1902,
                    Manager = "Alex Neil",
                    NickNames = "The Canaries",
                    Stadium = "Carrow Road",
                    StadiumCapacity = 27244,
                    ChampionsLeague = 0,
                    PremierLeague = 0,
                    FaCup = 0,
                    LeagueCup = 2,
                    CommunityShield = 0,
                    HomeColours = "Green & Yellow",
                    AwayColours = "Green & Yellow",
                    ThirdColours = "Green & Yellow",
                    KitMaker = "Under Armour"
                },

                new LeagueTeams()
                {
                    ID = 18,
                    Team = "Sunderland",
                    Founded = 1879,
                    Manager = "Sam Allardyce",
                    NickNames = "The Black Cats",
                    Stadium = "Stadium Of Light",
                    StadiumCapacity = 49000,
                    ChampionsLeague = 0,
                    PremierLeague = 6,
                    FaCup = 2,
                    LeagueCup = 0,
                    CommunityShield = 1,
                    HomeColours = "Red & White",
                    AwayColours = "Green",
                    ThirdColours = "None",
                    KitMaker = "Adidas"
                },

                new LeagueTeams()
                {
                    ID = 19,
                    Team = "Newcastle United",
                    Founded = 1892,
                    Manager = "Rafael Benítez",
                    NickNames = "",
                    Stadium = "St James' Park",
                    StadiumCapacity = 52405,
                    ChampionsLeague = 0,
                    PremierLeague = 4,
                    FaCup = 6,
                    LeagueCup = 0,
                    CommunityShield = 1,
                    HomeColours = "Black & White",
                    AwayColours = "White & Blue",
                    ThirdColours = "Purple",
                    KitMaker = "Puma"
                },

                new LeagueTeams()
                {
                    ID = 20,
                    Team = "Aston Villa",
                    Founded = 1874,
                    Manager = "Rémi Garde",
                    NickNames = "Villans",
                    Stadium = "Villa Park",
                    StadiumCapacity = 42682,
                    ChampionsLeague = 0,
                    PremierLeague = 7,
                    FaCup = 7,
                    LeagueCup = 5,
                    CommunityShield = 1,
                    HomeColours = "Purple & White",
                    AwayColours = "Yellow & Black",
                    ThirdColours = "None",
                    KitMaker = "Unknown"
                }

            };

            #endregion

            teams.ForEach(team => context.Teams.Add(team));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}