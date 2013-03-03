using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tournament.Data;
using Tournament.Models;

namespace Tournament.Controllers
{
    public class FixturesController : Controller
    {
        // GET: /Fixtures/
        public ActionResult Index(int id)
        {
            List<FixtureSummary> fixtures = new List<FixtureSummary>();

            using (TournamentEntities data = new TournamentEntities())
            {
                Group group = data.Groups.SingleOrDefault(g => g.GroupID == id);

                if (group != null)
                {
                    foreach (Team team in group.Teams)
                    {
                        foreach (Fixture fixture in team.HomeFixtures)
                        {
                            fixtures.Add(new FixtureSummary(fixture));
                        }
                    }
                }
            }

            ViewBag.GroupID = id;

            return View("Index", fixtures);
        }

        [HttpGet]
        public ActionResult Generate(int id)
        {
            return View("Generate", id);
        }

        [HttpPost]
        public ActionResult Generate(int id, string submit)
        {
            if (submit == "Generate")
            {
                using (TournamentEntities data = new TournamentEntities())
                {
                    Group group = data.Groups.SingleOrDefault(g => g.GroupID == id);

                    if (group != null)
                    {
                        foreach (Team team in group.Teams)
                        {
                            foreach (Team opponent in group.Teams)
                            {
                                if (opponent.TeamID != team.TeamID)
                                {
                                    Fixture fixture = new Fixture()
                                    {
                                        HomeTeamID = team.TeamID,
                                        AwayTeamID = opponent.TeamID,
                                    };

                                    data.Fixtures.AddObject(fixture);
                                }
                            }
                        }

                        data.SaveChanges();
                    }
                }
            }

            return RedirectToAction("Index", new { id = id });
        }

        [HttpPost]
        public ActionResult Update(int fixtureID, int homeScore, int awayScore)
        {
            int groupID = 0;

            using (TournamentEntities data = new TournamentEntities())
            {
                Fixture updatedFixture = data.Fixtures.SingleOrDefault(f => f.FixtureID == fixtureID);

                if (updatedFixture != null && updatedFixture.Result == null)
                {
                    groupID = updatedFixture.HomeTeam.GroupID;

                    updatedFixture.Result = new Result()
                    {
                        AwayScore = awayScore,
                        HomeScore = homeScore
                    };

                    data.SaveChanges();
                }
            }

            return RedirectToAction("Index", new { id = groupID });
        }
    }
}