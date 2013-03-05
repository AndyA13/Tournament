using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tournament.Data;

namespace Tournament.Models
{
    public class GroupTable
    {
        public int TournamentID { get; set; }
        public string TournamentName { get; set; }

        public int GroupID { get; set; }
        public string GroupName { get; set; }
        
        public IEnumerable<TeamSummary> Teams { get; set; }

        public GroupTable(Group group)
        {
            this.TournamentID = group.TournamentID;
            this.TournamentName = group.Tournament.Name;
            this.GroupID = group.GroupID;
            this.GroupName = group.Name;

            List<TeamSummary> summary = new List<TeamSummary>();

            foreach (Team team in group.Teams)
            {
                summary.Add(new TeamSummary(team));
            }

            this.Teams = summary;
        }
    }
}
