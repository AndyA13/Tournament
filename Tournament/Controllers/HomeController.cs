using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tournament.Data;

namespace Tournament.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        public ActionResult Index()
        {
            IEnumerable<Tournament.Data.Tournament> tournaments = null;

            using (TournamentEntities data = new TournamentEntities())
            {
                tournaments = data.Tournaments.ToList();
            }

            return View(tournaments);
        }

        [HttpPost]
        public ActionResult Add(Tournament.Data.Tournament tournament)
        {
            if (!String.IsNullOrEmpty(tournament.Name))
            {
                using (TournamentEntities data = new TournamentEntities())
                {
                    data.Tournaments.AddObject(tournament);
                    data.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Tournament.Data.Tournament tournament = null;

            using (TournamentEntities data = new TournamentEntities())
            {
                tournament = data.Tournaments.SingleOrDefault(t => t.TournamentID == id);
            }

            if (tournament != null)
            {
                return View("Delete", tournament);
            }

            return View("Error");
        }

        [HttpPost]
        public ActionResult Delete(int tournamentID, string submit)
        {
            if (tournamentID > 0 && submit == "Delete")
            {
                using (TournamentEntities data = new TournamentEntities())
                {
                    var tournament = data.Tournaments.SingleOrDefault(t => t.TournamentID == tournamentID);

                    if (tournament != null)
                    {
                        data.Tournaments.DeleteObject(tournament);
                        data.SaveChanges();
                    }
                }
            }

            return RedirectToAction("Index");
        }
    }
}
