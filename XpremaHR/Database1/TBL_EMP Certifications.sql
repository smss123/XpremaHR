USE [XpremaHR]
GO

/****** Object:  Table [EmpInfo].[empcertifications]    Script Date: 12/20/2014 18:41:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [EmpInfo].[empcertifications](
	[ID] [int] NOT NULL,
	[Career] [image] NULL,
	[Qualification] [nvarchar](200) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


