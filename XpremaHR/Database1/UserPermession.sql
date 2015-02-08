USE [XpremaHR]
GO

/****** Object:  Table [Security].[UserPermession]    Script Date: 2/8/2015 1:23:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Security].[UserPermession](
	[ID] [int] NOT NULL,
	[SystemUserID] [int] NULL,
	[PermessionValue] [nvarchar](max) NULL,
	[SystemPermessionID] [int] NULL,
	[SerialNumber] [uniqueidentifier] NULL,
 CONSTRAINT [PK_UserPermession] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


