using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tournament.Data;

namespace Tournament.Models
{
    public class TeamSummary
    {
        public TeamSummary(Team team)
        {
            this.TeamName = team.ToString();

            CalculatePoints(team, team.HomeFixtures);
            CalculatePoints(team, team.AwayFixtures);
        }

        private void CalculatePoints(Team team, IEnumerable<Fixture> fixtures)
        {
            foreach (Fixture fixture in fixtures)
            {
                if (fixture.Result != null)
                {
                    this.GamesPlayed++;

                    if (fixture.HomeTeamID == team.TeamID)
                    {
                        // Home
                        this.GoalsFor = this.GoalsFor + fixture.Result.HomeScore;
                        this.GoalsAgainst = this.GoalsAgainst + fixture.Result.AwayScore;

                        if (fixture.Result.HomeScore > fixture.Result.AwayScore)
                        {
                            // win
                            this.GamesWon++;
                            this.Points = this.Points + 3;
                        }
                        else if (fixture.Result.HomeScore < fixture.Result.AwayScore)
                        {
                            this.GamesLost++;
                        }
                        else
                        {
                            this.GamesDrawn++;
                            this.Points = this.Points + 1;
                        }
                    }
                    else
                    {
                        // Away
                        this.GoalsFor = this.GoalsFor + fixture.Result.AwayScore;
                        this.GoalsAgainst = this.GoalsAgainst + fixture.Result.HomeScore;

                        if (fixture.Result.AwayScore > fixture.Result.HomeScore)
                        {
                            // win
                            this.GamesWon++;
                            this.Points = this.Points + 3;
                        }
                        else if (fixture.Result.AwayScore < fixture.Result.HomeScore)
                        {
                            // loss
                            this.GamesLost++;
                        }
                        else
                        {
                            this.GamesDrawn++;
                            this.Points = this.Points + 1;
                        }
                    }
                }
            }
        }

        public string TeamName { get; set; }
        public int GamesPlayed { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int GamesWon { get; set; }
        public int GamesDrawn { get; set; }
        public int GamesLost { get; set; }
        public int Points { get; set; }
    }
}
