CREATE DATABASE SweeftDigital


CREATE TABLE Pupils(
	PupilID int IDENTITY(1,1) primary key NOT NULL,
	Firstname nvarchar(25) NOT NULL,
	Lastname nvarchar(25) NOT NULL,
	Sex nvarchar(15) NOT NULL,
	Class varchar(2) NOT NULL,
)

CREATE TABLE TeacherPupil(
	TeacherID int NOT NULL,
	PupilID int NOT NULL,
 CONSTRAINT PK_TeacherPupil PRIMARY KEY CLUSTERED 
(
	TeacherID ASC,
	PupilID ASC
))
CREATE TABLE Teachers(
	TeacherID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Firstname nvarchar(25) NOT NULL,
	Lastname nvarchar(25) NOT NULL,
	Sex nvarchar(15) NOT NULL,
	Subject nvarchar(20) NOT NULL,
)


ALTER TABLE TeacherPupil  WITH CHECK ADD  CONSTRAINT FK_TeacherPupil_Pupils FOREIGN KEY(PupilID)
REFERENCES Pupils (PupilID)

ALTER TABLE TeacherPupil CHECK CONSTRAINT FK_TeacherPupil_Pupils

ALTER TABLE TeacherPupil  WITH CHECK ADD  CONSTRAINT FK_TeacherPupil_Teachers FOREIGN KEY(TeacherID)
REFERENCES Teachers (TeacherID)

ALTER TABLE TeacherPupil CHECK CONSTRAINT FK_TeacherPupil_Teachers