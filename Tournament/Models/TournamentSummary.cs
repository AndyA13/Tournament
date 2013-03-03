using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tournament.Data;

namespace Tournament.Models
{
    public class TournamentSummary
    {
        public int TournamentID { get; set; }
        public string TournamentName { get; set; }
        public IEnumerable<GroupTable> GroupTables { get; set; }

        public TournamentSummary(Tournament.Data.Tournament tournament)
        {
            this.TournamentID = tournament.TournamentID;
            this.TournamentName = tournament.Name;

            List<GroupTable> groupTables = new List<GroupTable>();

            foreach (Group group in tournament.Groups)
            {
                groupTables.Add(new GroupTable(group));
            }

            this.GroupTables = groupTables;
        }
    }
}