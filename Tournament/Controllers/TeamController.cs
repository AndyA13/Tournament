using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tournament.Data;
using Tournament.Models;

namespace Tournament.Controllers
{
    public class TeamController : Controller
    {
        // GET: /Team/5
        public ActionResult Index(int id)
        {
            TeamDetails teamDetails = null;

            using (TournamentEntities data = new TournamentEntities())
            {
                Team team = data.Teams.SingleOrDefault(t => t.TeamID == id);

                if (team != null)
                {
                    teamDetails = new TeamDetails(team);
                }
            }

            if (teamDetails != null)
            {
                return View("Index", teamDetails);
            }

            return View("Error");
        }

        // POST: /Team/Add
        [HttpPost]
        public ActionResult Add(Team team)
        {
            using (TournamentEntities data = new TournamentEntities())
            {
                Group group = data.Groups.SingleOrDefault(g => g.GroupID == team.GroupID);

                if (group != null)
                {
                    data.Teams.AddObject(team);
                    data.SaveChanges();
                }
            }

            return RedirectToAction("Index", "Group", new { id = team.GroupID });
        }

        // POST: /Team/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Team postedTeam)
        {
            using (TournamentEntities data = new TournamentEntities())
            {
                Team team = data.Teams.SingleOrDefault(t => t.TeamID == id);

                if (team != null)
                {
                    UpdateModel<Team>(team);

                    data.SaveChanges();
                }
            }

            return RedirectToAction("Index", new { id = id });
        }
    }
}