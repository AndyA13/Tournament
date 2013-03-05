using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tournament.Data;

namespace Tournament.Controllers
{
    public class TeamController : Controller
    {
        public ActionResult Index(int id)
        {


            return View("Index");
        }

        // GET: /Team/
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
    }
}