USE [XpremaHR]
GO

/****** Object:  Table [EmpInfo].[EmployeeAttendance]    Script Date: 12/20/2014 00:08:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [EmpInfo].[EmployeeAttendance](
	[WorkingDate] [date] NULL,
	[ID] [int] NULL,
	[EmployeeName] [varchar](200) NULL,
	[BasicWorkingTime] [nvarchar](50) NULL,
	[InTime] [time](7) NULL,
	[OutTime] [time](7) NULL,
	[Overtime] [time](7) NULL,
	[Status] [nvarchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


