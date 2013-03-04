using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tournament.Data;
using Tournament.Models;

namespace Tournament.Controllers
{
    public class GroupController : Controller
    {
        // GET: /Group/
        public ActionResult Index(int id)
        {
            GroupTable model = null ;

            using (TournamentEntities data = new TournamentEntities())
            {
                Group group = data.Groups.SingleOrDefault(g => g.GroupID == id);

                if (group != null)
                {
                    model = new GroupTable(group);
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

            return RedirectToAction("Index", "Tournament", new { id = group.TournamentID });
        }
    }
}
