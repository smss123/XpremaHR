USE [XpremaHR]
GO

/****** Object:  Table [dbo].[SalaryProfile]    Script Date: 12/17/2014 11:24:22 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SalaryProfile](
	[ID] [int] NULL,
	[EmpID] [nvarchar](50) NULL,
	[ItemID] [int] NULL,
	[Amount] [money] NULL
) ON [PRIMARY]

GO


