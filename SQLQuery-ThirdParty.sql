USE [CMPT395]
GO

/****** Object:  Table [dbo].[ThirdParty]    Script Date: 2018/10/15 15:19:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ThirdParty](
	[PID] [int] NOT NULL,
	[EID] [int] NULL,
	[Name] [varchar](50) NULL,
	[Pemail] [varchar](50) NULL,
 CONSTRAINT [PK_ThirdParty] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


INSERT INTO ThirdParty
VALUES(11,1, 'aaa', 'thirdparty1@gmail.com');
INSERT INTO ThirdParty
VALUES(22,2, 'bbb', 'thirdparty2@gmail.com');
INSERT INTO ThirdParty
VALUES(33,3, 'ccc', 'thirdparty3@gmail.com');
INSERT INTO ThirdParty
VALUES(44,4, 'ddd', 'thirdparty4@gmail.com');
INSERT INTO ThirdParty
VALUES(55,5, 'eee', 'thirdparty5@gmail.com');
