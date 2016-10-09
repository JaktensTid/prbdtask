﻿CREATE TABLE Performances
(
ID int PRIMARY KEY IDENTITY NOT NULL,
Artist varchar(255) FOREIGN KEY REFERENCES Artists(Name),
PerformanceName varchar(255) NOT NULL,
PerformanceDate datetime NOT NULL
)