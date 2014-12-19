USE [XpremaHR]
GO

/****** Object:  Table [EmpInfo].[Vacations]    Script Date: 12/19/2014 23:34:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [EmpInfo].[Vacations](
	[ID] [int] NULL,
	[Start_Date] [date] NULL,
	[End_date] [date] NULL,
	[Vacation_type] [nchar](200) NULL
) ON [PRIMARY]

GO


