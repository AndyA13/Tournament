﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tournament.Data;

namespace Tournament.Controllers
{
    public class TeamController : Controller
    {
        // GET: /Team/
        [HttpPost]
        public ActionResult Add(Team team)
        {
            int tournamentID = 0;

            using (TournamentEntities data = new TournamentEntities())
            {
                Group group = data.Groups.SingleOrDefault(g => g.GroupID == team.GroupID);

                if (group != null)
                {
                    tournamentID = group.TournamentID;

                    data.Teams.AddObject(team);
                    data.SaveChanges();
                }
            }

            return RedirectToAction("Index", "Tournament", new { id = tournamentID });
        }
    }
}