USE [XpremaHR]
GO

/****** Object:  Table [dbo].[SalaryItem]    Script Date: 12/17/2014 11:23:36 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SalaryItem](
	[ItemID] [int] NULL,
	[Item] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


