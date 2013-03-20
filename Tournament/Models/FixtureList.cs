using System.Collections.Generic;
using Tournament.Data;

namespace Tournament.Models
{
    public class FixtureList : List<FixtureSummary>
    {
        public string TournamentName { get; set; }
        public int TournamentID { get; set; }

        public string GroupName { get; set; }
        public int GroupID { get; set; }

        public FixtureList(Group group)
        {
            this.TournamentName = group.Tournament.Name;
            this.TournamentID = group.Tournament.TournamentID;

            this.GroupName = group.Name;
            this.GroupID = group.GroupID;

            foreach (Team team in group.Teams)
            {
                foreach (Fixture fixture in team.HomeFixtures)
                {
                    this.Add(new FixtureSummary(fixture));
                }
            }
        }
    }
}