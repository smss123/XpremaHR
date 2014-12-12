USE [XpremaHR]
GO
ALTER TABLE [Security].[Users] DROP CONSTRAINT [FK_Users_UserGroup]
GO
ALTER TABLE [Security].[GroupPermession] DROP CONSTRAINT [FK_GroupPermession_UserGroup]
GO
ALTER TABLE [Security].[GroupPermession] DROP CONSTRAINT [FK_GroupPermession_SystemPermession]
GO
/****** Object:  Table [Security].[Users]    Script Date: 12/13/2014 1:42:59 AM ******/
DROP TABLE [Security].[Users]
GO
/****** Object:  Table [Security].[UserGroup]    Script Date: 12/13/2014 1:42:59 AM ******/
DROP TABLE [Security].[UserGroup]
GO
/****** Object:  Table [Security].[SystemPermession]    Script Date: 12/13/2014 1:42:59 AM ******/
DROP TABLE [Security].[SystemPermession]
GO
/****** Object:  Table [Security].[GroupPermession]    Script Date: 12/13/2014 1:42:59 AM ******/
DROP TABLE [Security].[GroupPermession]
GO
/****** Object:  Schema [Security]    Script Date: 12/13/2014 1:42:59 AM ******/
DROP SCHEMA [Security]
GO
/****** Object:  Schema [Security]    Script Date: 12/13/2014 1:42:59 AM ******/
CREATE SCHEMA [Security]
GO
/****** Object:  Table [Security].[GroupPermession]    Script Date: 12/13/2014 1:42:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Security].[GroupPermession](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GroupID] [int] NULL,
	[PermessionID] [int] NULL,
	[ValueX] [nvarchar](max) NULL,
	[AlternateValue] [image] NULL,
 CONSTRAINT [PK_GroupPermession] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [Security].[SystemPermession]    Script Date: 12/13/2014 1:42:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Security].[SystemPermession](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PermessionName] [nvarchar](50) NULL,
	[PermessionDescription] [nvarchar](500) NULL,
	[PermessionType] [nvarchar](50) NULL,
 CONSTRAINT [PK_SystemPermession] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Security].[UserGroup]    Script Date: 12/13/2014 1:42:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Security].[UserGroup](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [nvarchar](50) NULL,
	[GroupDescription] [nvarchar](500) NULL,
 CONSTRAINT [PK_UserGroup] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Security].[Users]    Script Date: 12/13/2014 1:42:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Security].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[GroupID] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [Security].[GroupPermession]  WITH CHECK ADD  CONSTRAINT [FK_GroupPermession_SystemPermession] FOREIGN KEY([PermessionID])
REFERENCES [Security].[SystemPermession] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Security].[GroupPermession] CHECK CONSTRAINT [FK_GroupPermession_SystemPermession]
GO
ALTER TABLE [Security].[GroupPermession]  WITH CHECK ADD  CONSTRAINT [FK_GroupPermession_UserGroup] FOREIGN KEY([GroupID])
REFERENCES [Security].[UserGroup] ([ID])
GO
ALTER TABLE [Security].[GroupPermession] CHECK CONSTRAINT [FK_GroupPermession_UserGroup]
GO
ALTER TABLE [Security].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserGroup] FOREIGN KEY([GroupID])
REFERENCES [Security].[UserGroup] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Security].[Users] CHECK CONSTRAINT [FK_Users_UserGroup]
GO
