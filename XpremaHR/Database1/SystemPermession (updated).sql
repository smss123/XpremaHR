USE [XpremaHR]
GO

/****** Object:  Table [Security].[SystemPermession]    Script Date: 2/8/2015 1:22:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Security].[SystemPermession](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SystemPermession] [nvarchar](50) NULL,
	[ObjectName] [nvarchar](500) NULL,
	[propertyName] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[SerialNumber] [uniqueidentifier] NULL,
 CONSTRAINT [PK_SystemPermession] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


