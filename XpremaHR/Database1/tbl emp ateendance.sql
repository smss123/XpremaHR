USE [XpremaHR]
GO

/****** Object:  Table [EmpInfo].[EmployeeAttendance]    Script Date: 12/20/2014 00:05:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [EmpInfo].[EmployeeAttendance](
	[WorkingDate] [nchar](30) NULL,
	[ID] [nchar](30) NULL,
	[EmployeeName] [varchar](100) NULL,
	[BasicWorkingTime] [nchar](10) NULL,
	[InTime] [nchar](30) NULL,
	[OutTime] [nchar](30) NULL,
	[Overtime] [nchar](10) NULL,
	[Status] [nchar](5) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


