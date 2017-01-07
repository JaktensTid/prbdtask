INSERT INTO CandyTypes (Name)
VALUES ('Pancakes'),('Candies');

INSERT INTO Companies (Name, Email)
VALUES ('Slavyanka', 'slav@mail.ru'),('Roshen', 'roshen@rambler.com');

INSERT INTO Factories (CompanyName, Addr, Country, Phone)
VALUES ('Slavyanka','Pooshkin st, Kolotushkin house', 'Russia', '88005553535'),
 ('Roshen','Stepan Bandera st, 1488', 'Ukraine', '8832454365345');

INSERT INTO AddressCandies (Addr, Candies)
VALUES ('Pooshkin st, Kolotushkin house','Pancakes'),
 ('Pooshkin st, Kolotushkin house','Candies'),
 ('Stepan Bandera st, 1488','Pancakes');

 INSERT INTO Persons (FirstName, LastName, CompanyName)
VALUES ('Mihail', 'Zaycev','Slavyanka'),
 ('Sergey', 'Zverev','Roshen');