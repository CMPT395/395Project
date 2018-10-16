USE [CMPT395]
GO

/****** Object:  Table [dbo].[Contractors]    Script Date: 2018/10/15 15:20:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Contractors](
	[CID] [int] NOT NULL,
	[EID] [int] NOT NULL,
	[FName] [varchar](50) NULL,
	[LName] [varchar](50) NULL,
	[Cemail] [varchar](50) NULL,
 CONSTRAINT [PK_Contractors] PRIMARY KEY CLUSTERED 
(
	[CID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


INSERT INTO Contractors
VALUES(1, 1, 'a', 'a', 'contractor1@gmail.com');
INSERT INTO Contractors
VALUES(2, 2, 'b', 'b', 'contractor2@gmail.com');
INSERT INTO Contractors
VALUES(3, 3, 'c', 'c', 'contractor3@gmail.com');
INSERT INTO Contractors
VALUES(4, 4, 'd', 'd', 'contractor4@gmail.com');
INSERT INTO Contractors
VALUES(5, 5, 'e', 'e', 'contractor5@gmail.com');
INSERT INTO Contractors
VALUES(6, 6, 'f', 'f', 'contractor6@gmail.com');




