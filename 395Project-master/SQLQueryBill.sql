
USE [CMPT395]
GO

/****** Object:  Table [dbo].[Bill]    Script Date: 2018/10/16 12:20:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
/*
CREATE TABLE [Imports].
  (
     [InvoiceNumber] [INT] IDENTITY(1, 1) NOT NULL
     ,[Deleted]      [BIT] NOT NULL
     ,[Used]         [BIT] NOT NULL,
     CONSTRAINT [PK_Invoices_Numbers] PRIMARY KEY CLUSTERED ( [InvoiceNumber] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
  )
ON 
*/


CREATE TABLE Bill
(
	BID int IDENTITY(1,1) Not Null,
	CID int,
	ClientID int,
	Month int,
	Hours int,
	Amount int,
	PRIMARY KEY(BID,CID,ClientID),
);


INSERT INTO Bill
VALUES( 1, 111, 10,600,30);
INSERT INTO Bill
VALUES( 2, 222, 10,600,30);
INSERT INTO Bill
VALUES( 3, 333, 10,600,30);
INSERT INTO Bill
VALUES( 4, 444, 10,600,30);

CREATE TABLE email
(
	host varchar (35),
	port int,
	eaddress varchar (55),
	epassword varchar (20),
	esubject varchar(100),
	ebody varchar(500),
);