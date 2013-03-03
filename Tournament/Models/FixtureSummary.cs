using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tournament.Data;

namespace Tournament.Models
{
    public class FixtureSummary
    {
        public int FixtureID { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public bool HasResult { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }

        public FixtureSummary(Fixture fixture)
        {
            this.FixtureID = fixture.FixtureID;
            this.HomeTeam = String.Format("{0} ({1})", fixture.HomeTeam.Name, fixture.HomeTeam.Player);
            this.AwayTeam = String.Format("{0} ({1})", fixture.AwayTeam.Name, fixture.AwayTeam.Player);

            if (fixture.Result != null)
            {
                this.HasResult = true;
                this.HomeScore = fixture.Result.HomeScore;
                this.AwayScore = fixture.Result.AwayScore;
            }
            else
            {
                this.HasResult = false;
            }
        }
    }
}