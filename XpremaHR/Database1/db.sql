SET NOCOUNT ON
GO

USE master
GO
if exists (select * from sysdatabases where name='XpremaHR')
		drop database XpremaHR
go

DECLARE @device_directory NVARCHAR(520)
SELECT @device_directory = SUBSTRING(filename, 1, CHARINDEX(N'master.mdf', LOWER(filename)) - 1)
FROM master.dbo.sysaltfiles WHERE dbid = 1 AND fileid = 1

EXECUTE (N'CREATE DATABASE XpremaHR
  ON PRIMARY (NAME = N''XpremaHR'', FILENAME = N''' + @device_directory + N'northwnd.mdf'')
  LOG ON (NAME = N''XpremaHR_log'',  FILENAME = N''' + @device_directory + N'northwnd.ldf'')')
go

exec sp_dboption 'XpremaHR','trunc. log on chkpt.','true'
exec sp_dboption 'XpremaHR','select into/bulkcopy','true'
GO

set quoted_identifier on
GO


USE [XpremaHR]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Accountant].[FK_ExpenssesMovment_Expensses]') AND parent_object_id = OBJECT_ID(N'[Accountant].[ExpenssesMovment]'))
ALTER TABLE [Accountant].[ExpenssesMovment] DROP CONSTRAINT [FK_ExpenssesMovment_Expensses]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Accountant].[FK_Expensses_Account]') AND parent_object_id = OBJECT_ID(N'[Accountant].[Expensses]'))
ALTER TABLE [Accountant].[Expensses] DROP CONSTRAINT [FK_Expensses_Account]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Accountant].[FK_AccountDaily_Account]') AND parent_object_id = OBJECT_ID(N'[Accountant].[AccountDaily]'))
ALTER TABLE [Accountant].[AccountDaily] DROP CONSTRAINT [FK_AccountDaily_Account]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Accountant].[FK_Account_AccountCategory]') AND parent_object_id = OBJECT_ID(N'[Accountant].[Account]'))
ALTER TABLE [Accountant].[Account] DROP CONSTRAINT [FK_Account_AccountCategory]
GO
/****** Object:  Table [Accountant].[ExpenssesMovment]    Script Date: 2/27/2015 1:30:50 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Accountant].[ExpenssesMovment]') AND type in (N'U'))
DROP TABLE [Accountant].[ExpenssesMovment]
GO
/****** Object:  Table [Accountant].[Expensses]    Script Date: 2/27/2015 1:30:50 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Accountant].[Expensses]') AND type in (N'U'))
DROP TABLE [Accountant].[Expensses]
GO
/****** Object:  Table [Accountant].[AccountDaily]    Script Date: 2/27/2015 1:30:50 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Accountant].[AccountDaily]') AND type in (N'U'))
DROP TABLE [Accountant].[AccountDaily]
GO
/****** Object:  Table [Accountant].[AccountCategory]    Script Date: 2/27/2015 1:30:50 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Accountant].[AccountCategory]') AND type in (N'U'))
DROP TABLE [Accountant].[AccountCategory]
GO
/****** Object:  Table [Accountant].[Account]    Script Date: 2/27/2015 1:30:50 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Accountant].[Account]') AND type in (N'U'))
DROP TABLE [Accountant].[Account]
GO
/****** Object:  Schema [Accountant]    Script Date: 2/27/2015 1:30:50 AM ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'Accountant')
DROP SCHEMA [Accountant]
GO
/****** Object:  Schema [Accountant]    Script Date: 2/27/2015 1:30:50 AM ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'Accountant')
EXEC sys.sp_executesql N'CREATE SCHEMA [Accountant]'

GO
/****** Object:  Table [Accountant].[Account]    Script Date: 2/27/2015 1:30:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Accountant].[Account]') AND type in (N'U'))
BEGIN
CREATE TABLE [Accountant].[Account](
	[ID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[AccountName] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[CategoryID] [int] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [Accountant].[AccountCategory]    Script Date: 2/27/2015 1:30:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Accountant].[AccountCategory]') AND type in (N'U'))
BEGIN
CREATE TABLE [Accountant].[AccountCategory](
	[ID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[AccountCategoryName] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
 CONSTRAINT [PK_AccountCategory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [Accountant].[AccountDaily]    Script Date: 2/27/2015 1:30:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Accountant].[AccountDaily]') AND type in (N'U'))
BEGIN
CREATE TABLE [Accountant].[AccountDaily](
	[ID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[AccountID] [int] NULL,
	[TotalIn] [float] NULL,
	[TotalOut] [float] NULL,
	[DateOfProcess] [datetime] NULL,
	[Description] [nvarchar](4000) NULL,
	[CommandArg] [nvarchar](50) NULL,
 CONSTRAINT [PK_AccountDaily] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [Accountant].[Expensses]    Script Date: 2/27/2015 1:30:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Accountant].[Expensses]') AND type in (N'U'))
BEGIN
CREATE TABLE [Accountant].[Expensses](
	[ID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ExpenssesName] [nvarchar](50) NULL,
	[Description] [nvarchar](4000) NULL,
	[AccountID] [int] NULL,
 CONSTRAINT [PK_Expensses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [Accountant].[ExpenssesMovment]    Script Date: 2/27/2015 1:30:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Accountant].[ExpenssesMovment]') AND type in (N'U'))
BEGIN
CREATE TABLE [Accountant].[ExpenssesMovment](
	[ID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ExpenssesID] [int] NULL,
	[Amount] [float] NULL,
	[DateOfProcess] [datetime] NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_ExpenssesMovment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Accountant].[FK_Account_AccountCategory]') AND parent_object_id = OBJECT_ID(N'[Accountant].[Account]'))
ALTER TABLE [Accountant].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_AccountCategory] FOREIGN KEY([CategoryID])
REFERENCES [Accountant].[AccountCategory] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Accountant].[FK_Account_AccountCategory]') AND parent_object_id = OBJECT_ID(N'[Accountant].[Account]'))
ALTER TABLE [Accountant].[Account] CHECK CONSTRAINT [FK_Account_AccountCategory]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Accountant].[FK_AccountDaily_Account]') AND parent_object_id = OBJECT_ID(N'[Accountant].[AccountDaily]'))
ALTER TABLE [Accountant].[AccountDaily]  WITH CHECK ADD  CONSTRAINT [FK_AccountDaily_Account] FOREIGN KEY([AccountID])
REFERENCES [Accountant].[Account] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Accountant].[FK_AccountDaily_Account]') AND parent_object_id = OBJECT_ID(N'[Accountant].[AccountDaily]'))
ALTER TABLE [Accountant].[AccountDaily] CHECK CONSTRAINT [FK_AccountDaily_Account]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Accountant].[FK_Expensses_Account]') AND parent_object_id = OBJECT_ID(N'[Accountant].[Expensses]'))
ALTER TABLE [Accountant].[Expensses]  WITH CHECK ADD  CONSTRAINT [FK_Expensses_Account] FOREIGN KEY([AccountID])
REFERENCES [Accountant].[Account] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Accountant].[FK_Expensses_Account]') AND parent_object_id = OBJECT_ID(N'[Accountant].[Expensses]'))
ALTER TABLE [Accountant].[Expensses] CHECK CONSTRAINT [FK_Expensses_Account]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Accountant].[FK_ExpenssesMovment_Expensses]') AND parent_object_id = OBJECT_ID(N'[Accountant].[ExpenssesMovment]'))
ALTER TABLE [Accountant].[ExpenssesMovment]  WITH CHECK ADD  CONSTRAINT [FK_ExpenssesMovment_Expensses] FOREIGN KEY([ExpenssesID])
REFERENCES [Accountant].[Expensses] ([ID])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Accountant].[FK_ExpenssesMovment_Expensses]') AND parent_object_id = OBJECT_ID(N'[Accountant].[ExpenssesMovment]'))
ALTER TABLE [Accountant].[ExpenssesMovment] CHECK CONSTRAINT [FK_ExpenssesMovment_Expensses]
GO
