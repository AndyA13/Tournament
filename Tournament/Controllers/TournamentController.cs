using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tournament.Data;
using Tournament.Models;

namespace Tournament.Controllers
{
    public class TournamentController : Controller
    {
        // GET: /Tournament/5
        public ActionResult Index(int id)
        {
            TournamentSummary model = null;

            using (TournamentEntities data = new TournamentEntities())
            {
                Tournament.Data.Tournament tournament = data.Tournaments.SingleOrDefault(t => t.TournamentID == id);

                if (tournament != null)
                {
                    model = new TournamentSummary(tournament);
                }
            }

            if (model != null)
            {
                return View("Index", model);
            }

            return View("Error");
        }

        [HttpPost]
        public ActionResult Add(Group group)
        {
            if (!String.IsNullOrEmpty(group.Name) && group.TournamentID > 0)
            {
                using (TournamentEntities data = new TournamentEntities())
                {
                    data.Groups.AddObject(group);
                    data.SaveChanges();
                }
            }

            return RedirectToAction("Index", new { id = group.TournamentID });
        }
    }
}
