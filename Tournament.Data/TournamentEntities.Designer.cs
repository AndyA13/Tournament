﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("Tournament.Data.Models", "FK_Fixture_Team", "Team", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Tournament.Data.Team), "Fixture", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Tournament.Data.Fixture), true)]
[assembly: EdmRelationshipAttribute("Tournament.Data.Models", "FK_Fixture_Team1", "Team", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Tournament.Data.Team), "Fixture", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Tournament.Data.Fixture), true)]
[assembly: EdmRelationshipAttribute("Tournament.Data.Models", "FK_Group_Tournament", "Tournament", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Tournament.Data.Tournament), "Group", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Tournament.Data.Group), true)]
[assembly: EdmRelationshipAttribute("Tournament.Data.Models", "FK_Team_Group", "Group", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Tournament.Data.Group), "Team", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Tournament.Data.Team), true)]
[assembly: EdmRelationshipAttribute("Tournament.Data.Models", "FK_Fixture_Result", "Result", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Tournament.Data.Result), "Fixture", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Tournament.Data.Fixture), true)]

#endregion

namespace Tournament.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class TournamentEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new TournamentEntities object using the connection string found in the 'TournamentEntities' section of the application configuration file.
        /// </summary>
        public TournamentEntities() : base("name=TournamentEntities", "TournamentEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TournamentEntities object.
        /// </summary>
        public TournamentEntities(string connectionString) : base(connectionString, "TournamentEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TournamentEntities object.
        /// </summary>
        public TournamentEntities(EntityConnection connection) : base(connection, "TournamentEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Fixture> Fixtures
        {
            get
            {
                if ((_Fixtures == null))
                {
                    _Fixtures = base.CreateObjectSet<Fixture>("Fixtures");
                }
                return _Fixtures;
            }
        }
        private ObjectSet<Fixture> _Fixtures;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Group> Groups
        {
            get
            {
                if ((_Groups == null))
                {
                    _Groups = base.CreateObjectSet<Group>("Groups");
                }
                return _Groups;
            }
        }
        private ObjectSet<Group> _Groups;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Result> Results
        {
            get
            {
                if ((_Results == null))
                {
                    _Results = base.CreateObjectSet<Result>("Results");
                }
                return _Results;
            }
        }
        private ObjectSet<Result> _Results;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Team> Teams
        {
            get
            {
                if ((_Teams == null))
                {
                    _Teams = base.CreateObjectSet<Team>("Teams");
                }
                return _Teams;
            }
        }
        private ObjectSet<Team> _Teams;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Tournament> Tournaments
        {
            get
            {
                if ((_Tournaments == null))
                {
                    _Tournaments = base.CreateObjectSet<Tournament>("Tournaments");
                }
                return _Tournaments;
            }
        }
        private ObjectSet<Tournament> _Tournaments;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Fixtures EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToFixtures(Fixture fixture)
        {
            base.AddObject("Fixtures", fixture);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Groups EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToGroups(Group group)
        {
            base.AddObject("Groups", group);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Results EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToResults(Result result)
        {
            base.AddObject("Results", result);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Teams EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTeams(Team team)
        {
            base.AddObject("Teams", team);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Tournaments EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTournaments(Tournament tournament)
        {
            base.AddObject("Tournaments", tournament);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Tournament.Data.Models", Name="Fixture")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Fixture : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Fixture object.
        /// </summary>
        /// <param name="fixtureID">Initial value of the FixtureID property.</param>
        /// <param name="homeTeamID">Initial value of the HomeTeamID property.</param>
        /// <param name="awayTeamID">Initial value of the AwayTeamID property.</param>
        public static Fixture CreateFixture(global::System.Int32 fixtureID, global::System.Int32 homeTeamID, global::System.Int32 awayTeamID)
        {
            Fixture fixture = new Fixture();
            fixture.FixtureID = fixtureID;
            fixture.HomeTeamID = homeTeamID;
            fixture.AwayTeamID = awayTeamID;
            return fixture;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 FixtureID
        {
            get
            {
                return _FixtureID;
            }
            set
            {
                if (_FixtureID != value)
                {
                    OnFixtureIDChanging(value);
                    ReportPropertyChanging("FixtureID");
                    _FixtureID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("FixtureID");
                    OnFixtureIDChanged();
                }
            }
        }
        private global::System.Int32 _FixtureID;
        partial void OnFixtureIDChanging(global::System.Int32 value);
        partial void OnFixtureIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 HomeTeamID
        {
            get
            {
                return _HomeTeamID;
            }
            set
            {
                OnHomeTeamIDChanging(value);
                ReportPropertyChanging("HomeTeamID");
                _HomeTeamID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("HomeTeamID");
                OnHomeTeamIDChanged();
            }
        }
        private global::System.Int32 _HomeTeamID;
        partial void OnHomeTeamIDChanging(global::System.Int32 value);
        partial void OnHomeTeamIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AwayTeamID
        {
            get
            {
                return _AwayTeamID;
            }
            set
            {
                OnAwayTeamIDChanging(value);
                ReportPropertyChanging("AwayTeamID");
                _AwayTeamID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AwayTeamID");
                OnAwayTeamIDChanged();
            }
        }
        private global::System.Int32 _AwayTeamID;
        partial void OnAwayTeamIDChanging(global::System.Int32 value);
        partial void OnAwayTeamIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ResultID
        {
            get
            {
                return _ResultID;
            }
            set
            {
                OnResultIDChanging(value);
                ReportPropertyChanging("ResultID");
                _ResultID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ResultID");
                OnResultIDChanged();
            }
        }
        private Nullable<global::System.Int32> _ResultID;
        partial void OnResultIDChanging(Nullable<global::System.Int32> value);
        partial void OnResultIDChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Tournament.Data.Models", "FK_Fixture_Team", "Team")]
        public Team HomeTeam
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Team>("Tournament.Data.Models.FK_Fixture_Team", "Team").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Team>("Tournament.Data.Models.FK_Fixture_Team", "Team").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Team> HomeTeamReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Team>("Tournament.Data.Models.FK_Fixture_Team", "Team");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Team>("Tournament.Data.Models.FK_Fixture_Team", "Team", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Tournament.Data.Models", "FK_Fixture_Team1", "Team")]
        public Team AwayTeam
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Team>("Tournament.Data.Models.FK_Fixture_Team1", "Team").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Team>("Tournament.Data.Models.FK_Fixture_Team1", "Team").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Team> AwayTeamReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Team>("Tournament.Data.Models.FK_Fixture_Team1", "Team");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Team>("Tournament.Data.Models.FK_Fixture_Team1", "Team", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Tournament.Data.Models", "FK_Fixture_Result", "Result")]
        public Result Result
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Result>("Tournament.Data.Models.FK_Fixture_Result", "Result").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Result>("Tournament.Data.Models.FK_Fixture_Result", "Result").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Result> ResultReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Result>("Tournament.Data.Models.FK_Fixture_Result", "Result");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Result>("Tournament.Data.Models.FK_Fixture_Result", "Result", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Tournament.Data.Models", Name="Group")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Group : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Group object.
        /// </summary>
        /// <param name="groupID">Initial value of the GroupID property.</param>
        /// <param name="tournamentID">Initial value of the TournamentID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Group CreateGroup(global::System.Int32 groupID, global::System.Int32 tournamentID, global::System.String name)
        {
            Group group = new Group();
            group.GroupID = groupID;
            group.TournamentID = tournamentID;
            group.Name = name;
            return group;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 GroupID
        {
            get
            {
                return _GroupID;
            }
            set
            {
                if (_GroupID != value)
                {
                    OnGroupIDChanging(value);
                    ReportPropertyChanging("GroupID");
                    _GroupID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("GroupID");
                    OnGroupIDChanged();
                }
            }
        }
        private global::System.Int32 _GroupID;
        partial void OnGroupIDChanging(global::System.Int32 value);
        partial void OnGroupIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TournamentID
        {
            get
            {
                return _TournamentID;
            }
            set
            {
                OnTournamentIDChanging(value);
                ReportPropertyChanging("TournamentID");
                _TournamentID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TournamentID");
                OnTournamentIDChanged();
            }
        }
        private global::System.Int32 _TournamentID;
        partial void OnTournamentIDChanging(global::System.Int32 value);
        partial void OnTournamentIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Tournament.Data.Models", "FK_Group_Tournament", "Tournament")]
        public Tournament Tournament
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Tournament>("Tournament.Data.Models.FK_Group_Tournament", "Tournament").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Tournament>("Tournament.Data.Models.FK_Group_Tournament", "Tournament").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Tournament> TournamentReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Tournament>("Tournament.Data.Models.FK_Group_Tournament", "Tournament");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Tournament>("Tournament.Data.Models.FK_Group_Tournament", "Tournament", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Tournament.Data.Models", "FK_Team_Group", "Team")]
        public EntityCollection<Team> Teams
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Team>("Tournament.Data.Models.FK_Team_Group", "Team");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Team>("Tournament.Data.Models.FK_Team_Group", "Team", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Tournament.Data.Models", Name="Result")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Result : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Result object.
        /// </summary>
        /// <param name="resultID">Initial value of the ResultID property.</param>
        /// <param name="homeScore">Initial value of the HomeScore property.</param>
        /// <param name="awayScore">Initial value of the AwayScore property.</param>
        public static Result CreateResult(global::System.Int32 resultID, global::System.Int32 homeScore, global::System.Int32 awayScore)
        {
            Result result = new Result();
            result.ResultID = resultID;
            result.HomeScore = homeScore;
            result.AwayScore = awayScore;
            return result;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ResultID
        {
            get
            {
                return _ResultID;
            }
            set
            {
                if (_ResultID != value)
                {
                    OnResultIDChanging(value);
                    ReportPropertyChanging("ResultID");
                    _ResultID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ResultID");
                    OnResultIDChanged();
                }
            }
        }
        private global::System.Int32 _ResultID;
        partial void OnResultIDChanging(global::System.Int32 value);
        partial void OnResultIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 HomeScore
        {
            get
            {
                return _HomeScore;
            }
            set
            {
                OnHomeScoreChanging(value);
                ReportPropertyChanging("HomeScore");
                _HomeScore = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("HomeScore");
                OnHomeScoreChanged();
            }
        }
        private global::System.Int32 _HomeScore;
        partial void OnHomeScoreChanging(global::System.Int32 value);
        partial void OnHomeScoreChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AwayScore
        {
            get
            {
                return _AwayScore;
            }
            set
            {
                OnAwayScoreChanging(value);
                ReportPropertyChanging("AwayScore");
                _AwayScore = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AwayScore");
                OnAwayScoreChanged();
            }
        }
        private global::System.Int32 _AwayScore;
        partial void OnAwayScoreChanging(global::System.Int32 value);
        partial void OnAwayScoreChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Tournament.Data.Models", "FK_Fixture_Result", "Fixture")]
        public EntityCollection<Fixture> Fixtures
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Fixture>("Tournament.Data.Models.FK_Fixture_Result", "Fixture");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Fixture>("Tournament.Data.Models.FK_Fixture_Result", "Fixture", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Tournament.Data.Models", Name="Team")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Team : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Team object.
        /// </summary>
        /// <param name="teamID">Initial value of the TeamID property.</param>
        /// <param name="groupID">Initial value of the GroupID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="player">Initial value of the Player property.</param>
        public static Team CreateTeam(global::System.Int32 teamID, global::System.Int32 groupID, global::System.String name, global::System.String player)
        {
            Team team = new Team();
            team.TeamID = teamID;
            team.GroupID = groupID;
            team.Name = name;
            team.Player = player;
            return team;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TeamID
        {
            get
            {
                return _TeamID;
            }
            set
            {
                if (_TeamID != value)
                {
                    OnTeamIDChanging(value);
                    ReportPropertyChanging("TeamID");
                    _TeamID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("TeamID");
                    OnTeamIDChanged();
                }
            }
        }
        private global::System.Int32 _TeamID;
        partial void OnTeamIDChanging(global::System.Int32 value);
        partial void OnTeamIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 GroupID
        {
            get
            {
                return _GroupID;
            }
            set
            {
                OnGroupIDChanging(value);
                ReportPropertyChanging("GroupID");
                _GroupID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("GroupID");
                OnGroupIDChanged();
            }
        }
        private global::System.Int32 _GroupID;
        partial void OnGroupIDChanging(global::System.Int32 value);
        partial void OnGroupIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Player
        {
            get
            {
                return _Player;
            }
            set
            {
                OnPlayerChanging(value);
                ReportPropertyChanging("Player");
                _Player = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Player");
                OnPlayerChanged();
            }
        }
        private global::System.String _Player;
        partial void OnPlayerChanging(global::System.String value);
        partial void OnPlayerChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Tournament.Data.Models", "FK_Fixture_Team", "Fixture")]
        public EntityCollection<Fixture> HomeFixtures
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Fixture>("Tournament.Data.Models.FK_Fixture_Team", "Fixture");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Fixture>("Tournament.Data.Models.FK_Fixture_Team", "Fixture", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Tournament.Data.Models", "FK_Fixture_Team1", "Fixture")]
        public EntityCollection<Fixture> AwayFixtures
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Fixture>("Tournament.Data.Models.FK_Fixture_Team1", "Fixture");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Fixture>("Tournament.Data.Models.FK_Fixture_Team1", "Fixture", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Tournament.Data.Models", "FK_Team_Group", "Group")]
        public Group Group
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Group>("Tournament.Data.Models.FK_Team_Group", "Group").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Group>("Tournament.Data.Models.FK_Team_Group", "Group").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Group> GroupReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Group>("Tournament.Data.Models.FK_Team_Group", "Group");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Group>("Tournament.Data.Models.FK_Team_Group", "Group", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Tournament.Data.Models", Name="Tournament")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Tournament : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Tournament object.
        /// </summary>
        /// <param name="tournamentID">Initial value of the TournamentID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Tournament CreateTournament(global::System.Int32 tournamentID, global::System.String name)
        {
            Tournament tournament = new Tournament();
            tournament.TournamentID = tournamentID;
            tournament.Name = name;
            return tournament;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TournamentID
        {
            get
            {
                return _TournamentID;
            }
            set
            {
                if (_TournamentID != value)
                {
                    OnTournamentIDChanging(value);
                    ReportPropertyChanging("TournamentID");
                    _TournamentID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("TournamentID");
                    OnTournamentIDChanged();
                }
            }
        }
        private global::System.Int32 _TournamentID;
        partial void OnTournamentIDChanging(global::System.Int32 value);
        partial void OnTournamentIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Tournament.Data.Models", "FK_Group_Tournament", "Group")]
        public EntityCollection<Group> Groups
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Group>("Tournament.Data.Models.FK_Group_Tournament", "Group");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Group>("Tournament.Data.Models.FK_Group_Tournament", "Group", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
