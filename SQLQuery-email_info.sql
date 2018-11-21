CREATE TABLE email
(
	host varchar (35),
	port int,
	eaddress varchar (55),
	epassword varchar (20),
	esubject varchar(100),
	ebody varchar(500),
);
INSERT INTO email
VALUES( 'smtp.gmail.com', 587, 'monthlyhourcollector@gmail.com','cmpt395test','Monthly Hour Required','Please click On the link To fill your working hours + the website link');