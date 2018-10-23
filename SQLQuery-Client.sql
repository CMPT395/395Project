USE [CMPT395]
GO

/****** Object:  Table [dbo].[ThirdParty]    Script Date: 2018/10/15 15:19:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Client](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	
	[Pemail] [varchar](50) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


INSERT INTO Client
VALUES('aaa', 'thirdparty1@gmail.com');
INSERT INTO Client
VALUES('bbb', 'thirdparty2@gmail.com');
INSERT INTO Client
VALUES( 'ccc', 'thirdparty3@gmail.com');
INSERT INTO Client
VALUES('ddd', 'thirdparty4@gmail.com');
INSERT INTO Client
VALUES( 'eee', 'thirdparty5@gmail.com');


create proc searchClient(
@idsearcg int,
@searchbox varchar(20)
)
as
select * from Client 
where ClientID = @idsearcg or Name = @searchbox or Pemail =@searchbox;

searchClient 2,'aaa'