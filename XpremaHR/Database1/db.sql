USE [XpremaHR]
GO
ALTER TABLE [Security].[Users] DROP CONSTRAINT [FK_Users_UserGroup]
GO
ALTER TABLE [Security].[Users] DROP CONSTRAINT [FK_Users_EmployeeBasicInfo]
GO
ALTER TABLE [Security].[GroupPermession] DROP CONSTRAINT [FK_GroupPermession_UserGroup]
GO
ALTER TABLE [Security].[GroupPermession] DROP CONSTRAINT [FK_GroupPermession_SystemPermession]
GO
ALTER TABLE [EmpInfo].[Job] DROP CONSTRAINT [FK_Job_JobGroup]
GO
ALTER TABLE [EmpInfo].[EmployeeBasicInfo] DROP CONSTRAINT [FK_EmployeeBasicInfo_Job]
GO
/****** Object:  Index [UQ__Employee__AF2DBA780DAF0CB0]    Script Date: 12/19/2014 6:18:24 PM ******/
ALTER TABLE [EmpInfo].[EmployeeBasicInfo] DROP CONSTRAINT [UQ__Employee__AF2DBA780DAF0CB0]
GO
/****** Object:  Table [Security].[Users]    Script Date: 12/19/2014 6:18:24 PM ******/
DROP TABLE [Security].[Users]
GO
/****** Object:  Table [Security].[UserGroup]    Script Date: 12/19/2014 6:18:24 PM ******/
DROP TABLE [Security].[UserGroup]
GO
/****** Object:  Table [Security].[SystemPermession]    Script Date: 12/19/2014 6:18:24 PM ******/
DROP TABLE [Security].[SystemPermession]
GO
/****** Object:  Table [Security].[GroupPermession]    Script Date: 12/19/2014 6:18:24 PM ******/
DROP TABLE [Security].[GroupPermession]
GO
/****** Object:  Table [EmpInfo].[SalaryProfile]    Script Date: 12/19/2014 6:18:24 PM ******/
DROP TABLE [EmpInfo].[SalaryProfile]
GO
/****** Object:  Table [EmpInfo].[SalaryItem]    Script Date: 12/19/2014 6:18:24 PM ******/
DROP TABLE [EmpInfo].[SalaryItem]
GO
/****** Object:  Table [EmpInfo].[JobGroup]    Script Date: 12/19/2014 6:18:24 PM ******/
DROP TABLE [EmpInfo].[JobGroup]
GO
/****** Object:  Table [EmpInfo].[Job]    Script Date: 12/19/2014 6:18:24 PM ******/
DROP TABLE [EmpInfo].[Job]
GO
/****** Object:  Table [EmpInfo].[EmployeeBasicInfo]    Script Date: 12/19/2014 6:18:24 PM ******/
DROP TABLE [EmpInfo].[EmployeeBasicInfo]
GO
/****** Object:  Schema [Security]    Script Date: 12/19/2014 6:18:24 PM ******/
DROP SCHEMA [Security]
GO
/****** Object:  Schema [EmpInfo]    Script Date: 12/19/2014 6:18:24 PM ******/
DROP SCHEMA [EmpInfo]
GO
/****** Object:  Schema [EmpInfo]    Script Date: 12/19/2014 6:18:24 PM ******/
CREATE SCHEMA [EmpInfo]
GO
/****** Object:  Schema [Security]    Script Date: 12/19/2014 6:18:24 PM ******/
CREATE SCHEMA [Security]
GO
/****** Object:  Table [EmpInfo].[EmployeeBasicInfo]    Script Date: 12/19/2014 6:18:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [EmpInfo].[EmployeeBasicInfo](
	[SerialNumber] [int] IDENTITY(1,1) NOT NULL,
	[EmpNumber] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF__EmployeeB__EmpID__0F975522]  DEFAULT (newid()),
	[EmpName] [nchar](10) NULL,
	[Address] [nvarchar](200) NULL,
	[MobileNo] [nchar](10) NULL,
	[Email] [nchar](60) NULL,
	[BloodGroup] [nvarchar](50) NULL,
	[Nationalty] [nvarchar](max) NULL,
	[nationaltyID] [nvarchar](60) NULL,
	[status] [nvarchar](50) NULL,
	[JobID] [int] NULL,
	[CreateDate] [datetime] NULL,
	[HereDate] [date] NULL,
 CONSTRAINT [PK_EmployeeRegistration] PRIMARY KEY CLUSTERED 
(
	[SerialNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [EmpInfo].[Job]    Script Date: 12/19/2014 6:18:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [EmpInfo].[Job](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[JobName] [nvarchar](50) NULL,
	[JobDescription] [nvarchar](500) NULL,
	[GroupID] [int] NULL,
 CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [EmpInfo].[JobGroup]    Script Date: 12/19/2014 6:18:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [EmpInfo].[JobGroup](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[JobGroupName] [nvarchar](50) NULL,
	[JobGroupDescription] [nvarchar](500) NULL,
 CONSTRAINT [PK_JobGroup] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [EmpInfo].[SalaryItem]    Script Date: 12/19/2014 6:18:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [EmpInfo].[SalaryItem](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SalaryItem] [nvarchar](50) NULL,
	[SalaryItemDescription] [nvarchar](500) NULL,
	[SelaryDirection] [nvarchar](50) NULL,
	[_SerialNumber] [uniqueidentifier] NULL,
 CONSTRAINT [PK_SalaryItem] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [EmpInfo].[SalaryProfile]    Script Date: 12/19/2014 6:18:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [EmpInfo].[SalaryProfile](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[SalaryItemID] [int] NULL,
	[Amount] [float] NULL,
	[_SerialNumber] [uniqueidentifier] NULL,
 CONSTRAINT [PK_SalaryProfile] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Security].[GroupPermession]    Script Date: 12/19/2014 6:18:25 PM ******/
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
/****** Object:  Table [Security].[SystemPermession]    Script Date: 12/19/2014 6:18:25 PM ******/
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
/****** Object:  Table [Security].[UserGroup]    Script Date: 12/19/2014 6:18:25 PM ******/
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
/****** Object:  Table [Security].[Users]    Script Date: 12/19/2014 6:18:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Security].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[GroupID] [int] NULL,
	[EmployeeID] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [EmpInfo].[EmployeeBasicInfo] ON 

INSERT [EmpInfo].[EmployeeBasicInfo] ([SerialNumber], [EmpNumber], [EmpName], [Address], [MobileNo], [Email], [BloodGroup], [Nationalty], [nationaltyID], [status], [JobID], [CreateDate], [HereDate]) VALUES (1, N'3564d785-9dde-4b32-9ce8-94fe2db8fcfd', N'samer     ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [EmpInfo].[EmployeeBasicInfo] OFF
/****** Object:  Index [UQ__Employee__AF2DBA780DAF0CB0]    Script Date: 12/19/2014 6:18:25 PM ******/
ALTER TABLE [EmpInfo].[EmployeeBasicInfo] ADD  CONSTRAINT [UQ__Employee__AF2DBA780DAF0CB0] UNIQUE NONCLUSTERED 
(
	[EmpNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [EmpInfo].[EmployeeBasicInfo]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeBasicInfo_Job] FOREIGN KEY([JobID])
REFERENCES [EmpInfo].[Job] ([ID])
GO
ALTER TABLE [EmpInfo].[EmployeeBasicInfo] CHECK CONSTRAINT [FK_EmployeeBasicInfo_Job]
GO
ALTER TABLE [EmpInfo].[Job]  WITH CHECK ADD  CONSTRAINT [FK_Job_JobGroup] FOREIGN KEY([GroupID])
REFERENCES [EmpInfo].[JobGroup] ([ID])
ON UPDATE SET DEFAULT
ON DELETE SET DEFAULT
GO
ALTER TABLE [EmpInfo].[Job] CHECK CONSTRAINT [FK_Job_JobGroup]
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
ALTER TABLE [Security].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_EmployeeBasicInfo] FOREIGN KEY([EmployeeID])
REFERENCES [EmpInfo].[EmployeeBasicInfo] ([SerialNumber])
ON DELETE CASCADE
GO
ALTER TABLE [Security].[Users] CHECK CONSTRAINT [FK_Users_EmployeeBasicInfo]
GO
ALTER TABLE [Security].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserGroup] FOREIGN KEY([GroupID])
REFERENCES [Security].[UserGroup] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [Security].[Users] CHECK CONSTRAINT [FK_Users_UserGroup]
GO
