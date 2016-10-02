CREATE TABLE Artists
(
ID int IDENTITY NOT NULL,

Name varchar(255) NOT NULL PRIMARY KEY,

Genre varchar(255),

Label varchar(255) FOREIGN KEY REFERENCES Labels(Name)
);