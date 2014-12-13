USE [XpremaHR]
GO

/****** Object:  Table [dbo].[EmployeeRegistration]    Script Date: 12/13/2014 20:28:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EmployeeRegistration](
	[EmpID] [nvarchar](50) NOT NULL,
	[EmpName] [nchar](10) NULL,
	[Address] [nvarchar](200) NULL,
	[MobileNo] [nchar](10) NULL,
	[Email] [nchar](60) NULL,
	[BloodGroup] [nvarchar](50) NULL,
	[Department] [nvarchar](max) NULL,
	[Designation] [nchar](60) NULL,
	[DateofJoining] [date] NULL,
	[Salary] [nvarchar](max) NULL,
	[BasicWorkingTime] [time](7) NULL,
	[Bday] [date] NULL,
	[Nationalty] [nvarchar](max) NULL,
	[nationaltyID] [nvarchar](60) NULL,
	[educlass] [nvarchar](max) NULL,
	[univercitydgree] [nvarchar](max) NULL,
	[specialization] [nvarchar](max) NULL,
	[Empcategory] [nvarchar](max) NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_EmployeeRegistration] PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


