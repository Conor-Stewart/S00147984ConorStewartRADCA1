using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Teams.Models;

namespace Teams.Controllers
{
    public class TeamsController : ApiController
    {
        private LeagueContext db = new LeagueContext();

        // GET: api/Books
        public List<LeagueTeams> GetTeams()
        {
            List<LeagueTeams> leagueTeams = new List<LeagueTeams>();

            var teams = db.Teams.ToList();

            teams.ForEach(b => leagueTeams.Add(new LeagueTeams()
            {
                ID = b.ID,
                Team = b.Team,
                Founded = b.Founded
            }));

            return leagueTeams;
        }

        // GET: api/Books/5
        [ResponseType(typeof(LeagueTeams))]
        public IHttpActionResult GetTeam(int id)
        {
            LeagueTeams team = db.Teams.Find(id);

            if (team == null)
            {
                return NotFound();
            }

            LeagueTeams leagueTeams = new LeagueTeams()
            {
                ID = team.ID,
                Team = team.Team,
                Founded = team.Founded
            };

            return Ok(team);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TeamExists(int id)
        {
            return db.Teams.Count(e => e.ID == id) > 0;
        }
    }
}
