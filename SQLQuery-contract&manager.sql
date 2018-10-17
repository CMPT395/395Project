
CREATE TABLE Manager
(
	MID int IDENTITY(1,1) PRIMARY KEY,
	FName varchar(40),
	LName varchar(40),
	Username varchar(40),
	Passward varchar(40),
	email varchar(40),
	phone_primary bigint
);

CREATE TABLE Contracts
(
	FileNum int IDENTITY(1,1) Not Null,
	ClientID int,
	CID int,
	Salary int,
	StartDate date,
	EndDate date,
	Renewable varchar(40),
	RenewYear int PRIMARY KEY(FileNum,ClientID,CID,Salary,StartDate,EndDate,Renewable,RenewYear),
);
INSERT INTO Contracts
VALUES(3, 3, 25, '2017-11-25','2018-11-25', 'Yes', 1);
INSERT INTO Contracts
VALUES(4, 2, 28, '2017-12-05','2018-12-05', 'Yes', 1);
INSERT INTO Contracts
VALUES(2, 3, 35, '2017-10-11','2018-10-11', 'No', 0);
INSERT INTO Contracts
VALUES(1, 1, 38, '2018-01-01', '2019-01-01', 'Yes', 2);






INSERT INTO Manager
VALUES('Danieal', 'Haha', 'manager1', 'password1','manager1@gmail.com',546123);
INSERT INTO Manager
VALUES('Bell', 'Debris', 'manager2', 'password2', 'manager2@gmail.com', 822314);
INSERT INTO Manager
VALUES('Bert', 'Ernie', 'manager3', 'password3', 'manager3@gmail.com',541565);
INSERT INTO Manager
VALUES('Paul', 'Rudd', 'manager4', 'password4', 'manager4@gmail.com',889218);
