CREATE TABLE Tracks
(
ID int IDENTITY NOT NULL,

Name varchar(255) NOT NULL,

Duration int NOT NULL,

Artist varchar(255) NOT NULL,

AlbumID int NOT NULL REFERENCES Albums(ID),

PRIMARY KEY (Name, Artist),
);