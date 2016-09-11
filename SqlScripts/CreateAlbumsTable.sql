CREATE TABLE Albums 
(
ID int PRIMARY KEY IDENTITY NOT NULL,

Name varchar(255) NOT NULL,

Duration varchar(255) NOT NULL,

Artist varchar(255) FOREIGN KEY REFERENCES Artists(Name) NOT NULL
);