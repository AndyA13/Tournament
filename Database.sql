USE [Tournament]
GO
/****** Object:  Table [dbo].[Tournament]    Script Date: 03/03/2013 20:26:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tournament](
	[TournamentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Tournament] PRIMARY KEY CLUSTERED 
(
	[TournamentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Result]    Script Date: 03/03/2013 20:26:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Result](
	[ResultID] [int] IDENTITY(1,1) NOT NULL,
	[HomeScore] [int] NOT NULL,
	[AwayScore] [int] NOT NULL,
 CONSTRAINT [PK_Result] PRIMARY KEY CLUSTERED 
(
	[ResultID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 03/03/2013 20:26:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[GroupID] [int] IDENTITY(1,1) NOT NULL,
	[TournamentID] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[GroupID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Team]    Script Date: 03/03/2013 20:26:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Team](
	[TeamID] [int] IDENTITY(1,1) NOT NULL,
	[GroupID] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Player] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Team] PRIMARY KEY CLUSTERED 
(
	[TeamID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fixture]    Script Date: 03/03/2013 20:26:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fixture](
	[FixtureID] [int] IDENTITY(1,1) NOT NULL,
	[HomeTeamID] [int] NOT NULL,
	[AwayTeamID] [int] NOT NULL,
	[ResultID] [int] NULL,
 CONSTRAINT [PK_Fixture] PRIMARY KEY CLUSTERED 
(
	[FixtureID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Fixture_Result]    Script Date: 03/03/2013 20:26:10 ******/
ALTER TABLE [dbo].[Fixture]  WITH CHECK ADD  CONSTRAINT [FK_Fixture_Result] FOREIGN KEY([ResultID])
REFERENCES [dbo].[Result] ([ResultID])
GO
ALTER TABLE [dbo].[Fixture] CHECK CONSTRAINT [FK_Fixture_Result]
GO
/****** Object:  ForeignKey [FK_Fixture_Team]    Script Date: 03/03/2013 20:26:10 ******/
ALTER TABLE [dbo].[Fixture]  WITH CHECK ADD  CONSTRAINT [FK_Fixture_Team] FOREIGN KEY([HomeTeamID])
REFERENCES [dbo].[Team] ([TeamID])
GO
ALTER TABLE [dbo].[Fixture] CHECK CONSTRAINT [FK_Fixture_Team]
GO
/****** Object:  ForeignKey [FK_Fixture_Team1]    Script Date: 03/03/2013 20:26:10 ******/
ALTER TABLE [dbo].[Fixture]  WITH CHECK ADD  CONSTRAINT [FK_Fixture_Team1] FOREIGN KEY([AwayTeamID])
REFERENCES [dbo].[Team] ([TeamID])
GO
ALTER TABLE [dbo].[Fixture] CHECK CONSTRAINT [FK_Fixture_Team1]
GO
/****** Object:  ForeignKey [FK_Group_Tournament]    Script Date: 03/03/2013 20:26:10 ******/
ALTER TABLE [dbo].[Group]  WITH CHECK ADD  CONSTRAINT [FK_Group_Tournament] FOREIGN KEY([TournamentID])
REFERENCES [dbo].[Tournament] ([TournamentID])
GO
ALTER TABLE [dbo].[Group] CHECK CONSTRAINT [FK_Group_Tournament]
GO
/****** Object:  ForeignKey [FK_Team_Group]    Script Date: 03/03/2013 20:26:10 ******/
ALTER TABLE [dbo].[Team]  WITH CHECK ADD  CONSTRAINT [FK_Team_Group] FOREIGN KEY([GroupID])
REFERENCES [dbo].[Group] ([GroupID])
GO
ALTER TABLE [dbo].[Team] CHECK CONSTRAINT [FK_Team_Group]
GO
