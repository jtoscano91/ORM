USE [master]
GO

----------  DATABASE  ----------
/****** Object:  Database [music]    Script Date: 8/17/2018 12:13:09 PM ******/
CREATE DATABASE [music]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'music', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\music.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'music_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\music_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [music] SET COMPATIBILITY_LEVEL = 140
GO


----------  TABLES  ----------
USE [music]
GO

/****** Object:  Table [dbo].[albums]    Script Date: 8/17/2018 12:15:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[artists](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_artists] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UC_artists] UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[albums](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[year] [int] NULL,
	[artist] [bigint] NOT NULL,
 CONSTRAINT [PK_albums] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UC_albums] UNIQUE NONCLUSTERED 
(
	[name] ASC,
	[artist] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[albums]  WITH CHECK ADD  CONSTRAINT [FK_albums_artists] FOREIGN KEY([artist])
REFERENCES [dbo].[artists] ([id])
GO

ALTER TABLE [dbo].[albums] CHECK CONSTRAINT [FK_albums_artists]
GO

CREATE TABLE [dbo].[songs](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[title] [varchar](100) NOT NULL,
	[duration] [time](7) NOT NULL,
	[album] [bigint] NULL,
	[track] [int] NULL,
	[language] [varchar](100) NULL,
 CONSTRAINT [PK_songs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UC_songs] UNIQUE NONCLUSTERED 
(
	[title] ASC,
	[album] ASC,
	[track] ASC,
	[language] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[songs]  WITH CHECK ADD  CONSTRAINT [FK_songs_albums] FOREIGN KEY([album])
REFERENCES [dbo].[albums] ([id])
GO

ALTER TABLE [dbo].[songs] CHECK CONSTRAINT [FK_songs_albums]
GO

----------  STORED PROCEDURES  ----------
CREATE PROCEDURE [dbo].[getAlbumsByArtist]
	@artist varchar(100)
AS
BEGIN

	SET NOCOUNT ON;
	DECLARE @ref bigint

	SELECT @ref=id FROM dbo.artists WHERE name = @artist
	
	SELECT id, name, year FROM dbo.albums WHERE artist = @ref
END
GO

CREATE PROCEDURE [dbo].[getSongsByAlbum]
	@album bigint
AS
BEGIN

	SET NOCOUNT ON;

	SELECT id, title, duration, album, track, language FROM dbo.songs WHERE album = @album

END
GO