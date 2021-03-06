﻿using System.Collections.Generic;
using System.Linq;
using Tournament.Data;

namespace Tournament.Models
{
    public class TeamDetails
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string Player { get; set; }
        
        public int GroupID { get; set; }
        public string GroupName { get; set; }

        public int TournamentID { get; set; }
        public string TournamentName { get; set; }
        
        public IEnumerable<FixtureSummary> AwayFixtures { get; set; }
        public IEnumerable<FixtureSummary> HomeFixtures { get; set; }

        public Dictionary<int, string> OtherTeams { get; set; }

        public TeamDetails(Team team)
        {
            this.TeamID = team.TeamID;
            this.TeamName = team.Name;
            this.Player = team.Player;
            this.GroupID = team.GroupID;
            this.GroupName = team.Group.Name;
            this.TournamentID = team.Group.TournamentID;
            this.TournamentName = team.Group.Tournament.Name;

            List<FixtureSummary> awayFixtures = new List<FixtureSummary>();

            foreach (Fixture fixture in team.AwayFixtures)
            {
                awayFixtures.Add(new FixtureSummary(fixture));
            }

            this.AwayFixtures = awayFixtures;

            List<FixtureSummary> homeFixtures = new List<FixtureSummary>();

            foreach (Fixture fixture in team.HomeFixtures)
            {
                homeFixtures.Add(new FixtureSummary(fixture));
            }

            this.HomeFixtures = homeFixtures;

            this.OtherTeams = new Dictionary<int, string>();

            foreach (Team otherTeam in team.Group.Teams.OrderBy(t => t.Name))
            {
                if (otherTeam.TeamID != team.TeamID)
                {
                    this.OtherTeams.Add(otherTeam.TeamID, otherTeam.ToString());
                }
            }
            
        }
    }
}