USE [XpremaHR]
go
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Security].[FK_Users_UserGroup]') AND parent_object_id = OBJECT_ID(N'[Security].[Users]'))
ALTER TABLE [Security].[Users] DROP CONSTRAINT [FK_Users_UserGroup]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Security].[FK_Users_EmployeeBasicInfo]') AND parent_object_id = OBJECT_ID(N'[Security].[Users]'))
ALTER TABLE [Security].[Users] DROP CONSTRAINT [FK_Users_EmployeeBasicInfo]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Security].[FK_Users_City]') AND parent_object_id = OBJECT_ID(N'[Security].[Users]'))
ALTER TABLE [Security].[Users] DROP CONSTRAINT [FK_Users_City]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Security].[FK_GroupPermession_UserGroup]') AND parent_object_id = OBJECT_ID(N'[Security].[GroupPermession]'))
ALTER TABLE [Security].[GroupPermession] DROP CONSTRAINT [FK_GroupPermession_UserGroup]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Security].[FK_GroupPermession_SystemPermession]') AND parent_object_id = OBJECT_ID(N'[Security].[GroupPermession]'))
ALTER TABLE [Security].[GroupPermession] DROP CONSTRAINT [FK_GroupPermession_SystemPermession]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[localize].[FK_City_Country]') AND parent_object_id = OBJECT_ID(N'[localize].[City]'))
ALTER TABLE [localize].[City] DROP CONSTRAINT [FK_City_Country]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[EmployeePoints].[FK_employeeEstimatedProfile_EstimatedPoint]') AND parent_object_id = OBJECT_ID(N'[EmployeePoints].[employeeEstimatedProfile]'))
ALTER TABLE [EmployeePoints].[employeeEstimatedProfile] DROP CONSTRAINT [FK_employeeEstimatedProfile_EstimatedPoint]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[EmployeePoints].[FK_employeeEstimatedProfile_EmployeeBasicInfo]') AND parent_object_id = OBJECT_ID(N'[EmployeePoints].[employeeEstimatedProfile]'))
ALTER TABLE [EmployeePoints].[employeeEstimatedProfile] DROP CONSTRAINT [FK_employeeEstimatedProfile_EmployeeBasicInfo]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[EmpInfo].[FK_Job_JobGroup]') AND parent_object_id = OBJECT_ID(N'[EmpInfo].[Job]'))
ALTER TABLE [EmpInfo].[Job] DROP CONSTRAINT [FK_Job_JobGroup]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[EmpInfo].[FK_employeeFamaliy_EmployeeBasicInfo]') AND parent_object_id = OBJECT_ID(N'[EmpInfo].[employeeFamaliy]'))
ALTER TABLE [EmpInfo].[employeeFamaliy] DROP CONSTRAINT [FK_employeeFamaliy_EmployeeBasicInfo]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[EmpInfo].[FK_EmployeeBasicInfo_Job]') AND parent_object_id = OBJECT_ID(N'[EmpInfo].[EmployeeBasicInfo]'))
ALTER TABLE [EmpInfo].[EmployeeBasicInfo] DROP CONSTRAINT [FK_EmployeeBasicInfo_Job]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[EmpInfo].[FK_EmployeeAttachment_EmployeeBasicInfo]') AND parent_object_id = OBJECT_ID(N'[EmpInfo].[EmployeeAttachment]'))
ALTER TABLE [EmpInfo].[EmployeeAttachment] DROP CONSTRAINT [FK_EmployeeAttachment_EmployeeBasicInfo]
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
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[localize].[DF_Country_SerialNumber]') AND type = 'D')
BEGIN
ALTER TABLE [localize].[Country] DROP CONSTRAINT [DF_Country_SerialNumber]
END

GO
/****** Object:  Table [Security].[Users]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Security].[Users]') AND type in (N'U'))
DROP TABLE [Security].[Users]
GO
/****** Object:  Table [Security].[UserGroup]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Security].[UserGroup]') AND type in (N'U'))
DROP TABLE [Security].[UserGroup]
GO
/****** Object:  Table [Security].[SystemPermession]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Security].[SystemPermession]') AND type in (N'U'))
DROP TABLE [Security].[SystemPermession]
GO
/****** Object:  Table [Security].[GroupPermession]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Security].[GroupPermession]') AND type in (N'U'))
DROP TABLE [Security].[GroupPermession]
GO
/****** Object:  Table [procedures].[ProcedureProfile]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[procedures].[ProcedureProfile]') AND type in (N'U'))
DROP TABLE [procedures].[ProcedureProfile]
GO
/****** Object:  Table [procedures].[ProcedureHer]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[procedures].[ProcedureHer]') AND type in (N'U'))
DROP TABLE [procedures].[ProcedureHer]
GO
/****** Object:  Table [localize].[Country]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[localize].[Country]') AND type in (N'U'))
DROP TABLE [localize].[Country]
GO
/****** Object:  Table [localize].[City]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[localize].[City]') AND type in (N'U'))
DROP TABLE [localize].[City]
GO
/****** Object:  Table [EmployeePoints].[EstimatedPoint]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmployeePoints].[EstimatedPoint]') AND type in (N'U'))
DROP TABLE [EmployeePoints].[EstimatedPoint]
GO
/****** Object:  Table [EmployeePoints].[employeeEstimatedProfile]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmployeePoints].[employeeEstimatedProfile]') AND type in (N'U'))
DROP TABLE [EmployeePoints].[employeeEstimatedProfile]
GO
/****** Object:  Table [EmpInfo].[SalaryProfile]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmpInfo].[SalaryProfile]') AND type in (N'U'))
DROP TABLE [EmpInfo].[SalaryProfile]
GO
/****** Object:  Table [EmpInfo].[SalaryItem]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmpInfo].[SalaryItem]') AND type in (N'U'))
DROP TABLE [EmpInfo].[SalaryItem]
GO
/****** Object:  Table [EmpInfo].[JobGroup]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmpInfo].[JobGroup]') AND type in (N'U'))
DROP TABLE [EmpInfo].[JobGroup]
GO
/****** Object:  Table [EmpInfo].[Job]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmpInfo].[Job]') AND type in (N'U'))
DROP TABLE [EmpInfo].[Job]
GO
/****** Object:  Table [EmpInfo].[employeeFamaliy]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmpInfo].[employeeFamaliy]') AND type in (N'U'))
DROP TABLE [EmpInfo].[employeeFamaliy]
GO
/****** Object:  Table [EmpInfo].[EmployeeBasicInfo]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmpInfo].[EmployeeBasicInfo]') AND type in (N'U'))
DROP TABLE [EmpInfo].[EmployeeBasicInfo]
GO
/****** Object:  Table [EmpInfo].[EmployeeAttachment]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmpInfo].[EmployeeAttachment]') AND type in (N'U'))
DROP TABLE [EmpInfo].[EmployeeAttachment]
GO
/****** Object:  Table [Accountant].[ExpenssesMovment]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Accountant].[ExpenssesMovment]') AND type in (N'U'))
DROP TABLE [Accountant].[ExpenssesMovment]
GO
/****** Object:  Table [Accountant].[Expensses]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Accountant].[Expensses]') AND type in (N'U'))
DROP TABLE [Accountant].[Expensses]
GO
/****** Object:  Table [Accountant].[AccountDaily]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Accountant].[AccountDaily]') AND type in (N'U'))
DROP TABLE [Accountant].[AccountDaily]
GO
/****** Object:  Table [Accountant].[AccountCategory]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Accountant].[AccountCategory]') AND type in (N'U'))
DROP TABLE [Accountant].[AccountCategory]
GO
/****** Object:  Table [Accountant].[Account]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Accountant].[Account]') AND type in (N'U'))
DROP TABLE [Accountant].[Account]
GO
/****** Object:  Schema [Security]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'Security')
DROP SCHEMA [Security]
GO
/****** Object:  Schema [procedures]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'procedures')
DROP SCHEMA [procedures]
GO
/****** Object:  Schema [localize]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'localize')
DROP SCHEMA [localize]
GO
/****** Object:  Schema [EmployeePoints]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'EmployeePoints')
DROP SCHEMA [EmployeePoints]
GO
/****** Object:  Schema [EmpInfo]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'EmpInfo')
DROP SCHEMA [EmpInfo]
GO
/****** Object:  Schema [Accountant]    Script Date: 2/5/2015 12:52:25 AM ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'Accountant')
DROP SCHEMA [Accountant]
GO
/****** Object:  Schema [Accountant]    Script Date: 2/5/2015 12:52:25 AM ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'Accountant')
EXEC sys.sp_executesql N'CREATE SCHEMA [Accountant]'

GO
/****** Object:  Schema [EmpInfo]    Script Date: 2/5/2015 12:52:25 AM ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'EmpInfo')
EXEC sys.sp_executesql N'CREATE SCHEMA [EmpInfo]'

GO
/****** Object:  Schema [EmployeePoints]    Script Date: 2/5/2015 12:52:25 AM ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'EmployeePoints')
EXEC sys.sp_executesql N'CREATE SCHEMA [EmployeePoints]'

GO
/****** Object:  Schema [localize]    Script Date: 2/5/2015 12:52:25 AM ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'localize')
EXEC sys.sp_executesql N'CREATE SCHEMA [localize]'

GO
/****** Object:  Schema [procedures]    Script Date: 2/5/2015 12:52:25 AM ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'procedures')
EXEC sys.sp_executesql N'CREATE SCHEMA [procedures]'

GO
/****** Object:  Schema [Security]    Script Date: 2/5/2015 12:52:25 AM ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'Security')
EXEC sys.sp_executesql N'CREATE SCHEMA [Security]'

GO
/****** Object:  Table [Accountant].[Account]    Script Date: 2/5/2015 12:52:25 AM ******/
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
/****** Object:  Table [Accountant].[AccountCategory]    Script Date: 2/5/2015 12:52:26 AM ******/
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
/****** Object:  Table [Accountant].[AccountDaily]    Script Date: 2/5/2015 12:52:26 AM ******/
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
/****** Object:  Table [Accountant].[Expensses]    Script Date: 2/5/2015 12:52:26 AM ******/
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
/****** Object:  Table [Accountant].[ExpenssesMovment]    Script Date: 2/5/2015 12:52:26 AM ******/
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
/****** Object:  Table [EmpInfo].[EmployeeAttachment]    Script Date: 2/5/2015 12:52:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmpInfo].[EmployeeAttachment]') AND type in (N'U'))
BEGIN
CREATE TABLE [EmpInfo].[EmployeeAttachment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[Attachment] [image] NULL,
	[AttachmentDesription] [nvarchar](4000) NULL,
 CONSTRAINT [PK_EmployeeAttachment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [EmpInfo].[EmployeeBasicInfo]    Script Date: 2/5/2015 12:52:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmpInfo].[EmployeeBasicInfo]') AND type in (N'U'))
BEGIN
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Employee__AF2DBA780DAF0CB0] UNIQUE NONCLUSTERED 
(
	[EmpNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [EmpInfo].[employeeFamaliy]    Script Date: 2/5/2015 12:52:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmpInfo].[employeeFamaliy]') AND type in (N'U'))
BEGIN
CREATE TABLE [EmpInfo].[employeeFamaliy](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmpID] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[Relationship] [nvarchar](50) NULL,
	[Age] [nvarchar](50) NULL,
	[ContactPhoneNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_employeeFamaliy] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [EmpInfo].[Job]    Script Date: 2/5/2015 12:52:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmpInfo].[Job]') AND type in (N'U'))
BEGIN
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
END
GO
/****** Object:  Table [EmpInfo].[JobGroup]    Script Date: 2/5/2015 12:52:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmpInfo].[JobGroup]') AND type in (N'U'))
BEGIN
CREATE TABLE [EmpInfo].[JobGroup](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[JobGroupName] [nvarchar](50) NULL,
	[JobGroupDescription] [nvarchar](500) NULL,
 CONSTRAINT [PK_JobGroup] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [EmpInfo].[SalaryItem]    Script Date: 2/5/2015 12:52:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmpInfo].[SalaryItem]') AND type in (N'U'))
BEGIN
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
END
GO
/****** Object:  Table [EmpInfo].[SalaryProfile]    Script Date: 2/5/2015 12:52:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmpInfo].[SalaryProfile]') AND type in (N'U'))
BEGIN
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
END
GO
/****** Object:  Table [EmployeePoints].[employeeEstimatedProfile]    Script Date: 2/5/2015 12:52:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmployeePoints].[employeeEstimatedProfile]') AND type in (N'U'))
BEGIN
CREATE TABLE [EmployeePoints].[employeeEstimatedProfile](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employeeID] [int] NULL,
	[estimatedpoint] [int] NULL,
 CONSTRAINT [PK_employeeEstimatedProfile] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [EmployeePoints].[EstimatedPoint]    Script Date: 2/5/2015 12:52:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmployeePoints].[EstimatedPoint]') AND type in (N'U'))
BEGIN
CREATE TABLE [EmployeePoints].[EstimatedPoint](
	[ID] [int] NOT NULL,
	[EstimatedName] [nvarchar](50) NULL,
	[point] [int] NULL,
 CONSTRAINT [PK_EstimatedPoint] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [localize].[City]    Script Date: 2/5/2015 12:52:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[localize].[City]') AND type in (N'U'))
BEGIN
CREATE TABLE [localize].[City](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cityName] [nvarchar](50) NULL,
	[description] [nvarchar](max) NULL,
	[counrtyID] [int] NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [localize].[Country]    Script Date: 2/5/2015 12:52:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[localize].[Country]') AND type in (N'U'))
BEGIN
CREATE TABLE [localize].[Country](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](50) NULL,
	[description] [nvarchar](max) NULL,
	[SerialNumber] [uniqueidentifier] ROWGUIDCOL  NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [procedures].[ProcedureHer]    Script Date: 2/5/2015 12:52:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[procedures].[ProcedureHer]') AND type in (N'U'))
BEGIN
CREATE TABLE [procedures].[ProcedureHer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SortOfProcedure] [int] NULL,
	[ProcedureID] [int] NULL,
	[EmplyeeID] [int] NULL,
	[description] [ntext] NULL,
 CONSTRAINT [PK_ProcedureHer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [procedures].[ProcedureProfile]    Script Date: 2/5/2015 12:52:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[procedures].[ProcedureProfile]') AND type in (N'U'))
BEGIN
CREATE TABLE [procedures].[ProcedureProfile](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[procedureName] [nvarchar](50) NULL,
	[Description] [nvarchar](4000) NULL,
 CONSTRAINT [PK_ProcedureProfile] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [Security].[GroupPermession]    Script Date: 2/5/2015 12:52:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Security].[GroupPermession]') AND type in (N'U'))
BEGIN
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
END
GO
/****** Object:  Table [Security].[SystemPermession]    Script Date: 2/5/2015 12:52:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Security].[SystemPermession]') AND type in (N'U'))
BEGIN
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
END
GO
/****** Object:  Table [Security].[UserGroup]    Script Date: 2/5/2015 12:52:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Security].[UserGroup]') AND type in (N'U'))
BEGIN
CREATE TABLE [Security].[UserGroup](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [nvarchar](50) NULL,
	[GroupDescription] [nvarchar](500) NULL,
 CONSTRAINT [PK_UserGroup] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [Security].[Users]    Script Date: 2/5/2015 12:52:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Security].[Users]') AND type in (N'U'))
BEGIN
CREATE TABLE [Security].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[GroupID] [int] NULL,
	[EmployeeID] [int] NULL,
	[CountryID] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[localize].[DF_Country_SerialNumber]') AND type = 'D')
BEGIN
ALTER TABLE [localize].[Country] ADD  CONSTRAINT [DF_Country_SerialNumber]  DEFAULT (newid()) FOR [SerialNumber]
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
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[EmpInfo].[FK_EmployeeAttachment_EmployeeBasicInfo]') AND parent_object_id = OBJECT_ID(N'[EmpInfo].[EmployeeAttachment]'))
ALTER TABLE [EmpInfo].[EmployeeAttachment]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeAttachment_EmployeeBasicInfo] FOREIGN KEY([EmployeeID])
REFERENCES [EmpInfo].[EmployeeBasicInfo] ([SerialNumber])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[EmpInfo].[FK_EmployeeAttachment_EmployeeBasicInfo]') AND parent_object_id = OBJECT_ID(N'[EmpInfo].[EmployeeAttachment]'))
ALTER TABLE [EmpInfo].[EmployeeAttachment] CHECK CONSTRAINT [FK_EmployeeAttachment_EmployeeBasicInfo]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[EmpInfo].[FK_EmployeeBasicInfo_Job]') AND parent_object_id = OBJECT_ID(N'[EmpInfo].[EmployeeBasicInfo]'))
ALTER TABLE [EmpInfo].[EmployeeBasicInfo]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeBasicInfo_Job] FOREIGN KEY([JobID])
REFERENCES [EmpInfo].[Job] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[EmpInfo].[FK_EmployeeBasicInfo_Job]') AND parent_object_id = OBJECT_ID(N'[EmpInfo].[EmployeeBasicInfo]'))
ALTER TABLE [EmpInfo].[EmployeeBasicInfo] CHECK CONSTRAINT [FK_EmployeeBasicInfo_Job]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[EmpInfo].[FK_employeeFamaliy_EmployeeBasicInfo]') AND parent_object_id = OBJECT_ID(N'[EmpInfo].[employeeFamaliy]'))
ALTER TABLE [EmpInfo].[employeeFamaliy]  WITH CHECK ADD  CONSTRAINT [FK_employeeFamaliy_EmployeeBasicInfo] FOREIGN KEY([EmpID])
REFERENCES [EmpInfo].[EmployeeBasicInfo] ([SerialNumber])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[EmpInfo].[FK_employeeFamaliy_EmployeeBasicInfo]') AND parent_object_id = OBJECT_ID(N'[EmpInfo].[employeeFamaliy]'))
ALTER TABLE [EmpInfo].[employeeFamaliy] CHECK CONSTRAINT [FK_employeeFamaliy_EmployeeBasicInfo]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[EmpInfo].[FK_Job_JobGroup]') AND parent_object_id = OBJECT_ID(N'[EmpInfo].[Job]'))
ALTER TABLE [EmpInfo].[Job]  WITH CHECK ADD  CONSTRAINT [FK_Job_JobGroup] FOREIGN KEY([GroupID])
REFERENCES [EmpInfo].[JobGroup] ([ID])
ON UPDATE SET DEFAULT
ON DELETE SET DEFAULT
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[EmpInfo].[FK_Job_JobGroup]') AND parent_object_id = OBJECT_ID(N'[EmpInfo].[Job]'))
ALTER TABLE [EmpInfo].[Job] CHECK CONSTRAINT [FK_Job_JobGroup]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[EmployeePoints].[FK_employeeEstimatedProfile_EmployeeBasicInfo]') AND parent_object_id = OBJECT_ID(N'[EmployeePoints].[employeeEstimatedProfile]'))
ALTER TABLE [EmployeePoints].[employeeEstimatedProfile]  WITH CHECK ADD  CONSTRAINT [FK_employeeEstimatedProfile_EmployeeBasicInfo] FOREIGN KEY([employeeID])
REFERENCES [EmpInfo].[EmployeeBasicInfo] ([SerialNumber])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[EmployeePoints].[FK_employeeEstimatedProfile_EmployeeBasicInfo]') AND parent_object_id = OBJECT_ID(N'[EmployeePoints].[employeeEstimatedProfile]'))
ALTER TABLE [EmployeePoints].[employeeEstimatedProfile] CHECK CONSTRAINT [FK_employeeEstimatedProfile_EmployeeBasicInfo]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[EmployeePoints].[FK_employeeEstimatedProfile_EstimatedPoint]') AND parent_object_id = OBJECT_ID(N'[EmployeePoints].[employeeEstimatedProfile]'))
ALTER TABLE [EmployeePoints].[employeeEstimatedProfile]  WITH CHECK ADD  CONSTRAINT [FK_employeeEstimatedProfile_EstimatedPoint] FOREIGN KEY([id])
REFERENCES [EmployeePoints].[EstimatedPoint] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[EmployeePoints].[FK_employeeEstimatedProfile_EstimatedPoint]') AND parent_object_id = OBJECT_ID(N'[EmployeePoints].[employeeEstimatedProfile]'))
ALTER TABLE [EmployeePoints].[employeeEstimatedProfile] CHECK CONSTRAINT [FK_employeeEstimatedProfile_EstimatedPoint]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[localize].[FK_City_Country]') AND parent_object_id = OBJECT_ID(N'[localize].[City]'))
ALTER TABLE [localize].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_Country] FOREIGN KEY([counrtyID])
REFERENCES [localize].[Country] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[localize].[FK_City_Country]') AND parent_object_id = OBJECT_ID(N'[localize].[City]'))
ALTER TABLE [localize].[City] CHECK CONSTRAINT [FK_City_Country]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Security].[FK_GroupPermession_SystemPermession]') AND parent_object_id = OBJECT_ID(N'[Security].[GroupPermession]'))
ALTER TABLE [Security].[GroupPermession]  WITH CHECK ADD  CONSTRAINT [FK_GroupPermession_SystemPermession] FOREIGN KEY([PermessionID])
REFERENCES [Security].[SystemPermession] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Security].[FK_GroupPermession_SystemPermession]') AND parent_object_id = OBJECT_ID(N'[Security].[GroupPermession]'))
ALTER TABLE [Security].[GroupPermession] CHECK CONSTRAINT [FK_GroupPermession_SystemPermession]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Security].[FK_GroupPermession_UserGroup]') AND parent_object_id = OBJECT_ID(N'[Security].[GroupPermession]'))
ALTER TABLE [Security].[GroupPermession]  WITH CHECK ADD  CONSTRAINT [FK_GroupPermession_UserGroup] FOREIGN KEY([GroupID])
REFERENCES [Security].[UserGroup] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Security].[FK_GroupPermession_UserGroup]') AND parent_object_id = OBJECT_ID(N'[Security].[GroupPermession]'))
ALTER TABLE [Security].[GroupPermession] CHECK CONSTRAINT [FK_GroupPermession_UserGroup]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Security].[FK_Users_City]') AND parent_object_id = OBJECT_ID(N'[Security].[Users]'))
ALTER TABLE [Security].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_City] FOREIGN KEY([CountryID])
REFERENCES [localize].[City] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Security].[FK_Users_City]') AND parent_object_id = OBJECT_ID(N'[Security].[Users]'))
ALTER TABLE [Security].[Users] CHECK CONSTRAINT [FK_Users_City]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Security].[FK_Users_EmployeeBasicInfo]') AND parent_object_id = OBJECT_ID(N'[Security].[Users]'))
ALTER TABLE [Security].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_EmployeeBasicInfo] FOREIGN KEY([EmployeeID])
REFERENCES [EmpInfo].[EmployeeBasicInfo] ([SerialNumber])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Security].[FK_Users_EmployeeBasicInfo]') AND parent_object_id = OBJECT_ID(N'[Security].[Users]'))
ALTER TABLE [Security].[Users] CHECK CONSTRAINT [FK_Users_EmployeeBasicInfo]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Security].[FK_Users_UserGroup]') AND parent_object_id = OBJECT_ID(N'[Security].[Users]'))
ALTER TABLE [Security].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserGroup] FOREIGN KEY([GroupID])
REFERENCES [Security].[UserGroup] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Security].[FK_Users_UserGroup]') AND parent_object_id = OBJECT_ID(N'[Security].[Users]'))
ALTER TABLE [Security].[Users] CHECK CONSTRAINT [FK_Users_UserGroup]
GO
