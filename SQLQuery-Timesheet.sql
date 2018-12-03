


CREATE TABLE Timesheet
(	CID int,
	Year int,
	Month int,
	Hour int,
	Status varchar (20),
	PRIMARY KEY(CID,Year, Month, Hour)

)

INSERT INTO Timesheet
VALUES(1,2018, 01, 160,'submited');
INSERT INTO Timesheet
VALUES(2,2017, 10, 100,'submited');
INSERT INTO Timesheet
VALUES(3,2017, 11, 100,'submited');
INSERT INTO Timesheet
VALUES(4,2017, 10, 100,'submited');
