
 INSERT INTO Labels(Name)
VALUES
 ('Blood Music'),
 ('NewRetroWaveRec');

INSERT INTO Artists (Name,Genre, Label)
VALUES
 ('Perturbator','Synthwave', 'Blood Music'),
 ('Mega Drive', 'New retro wave', 'NewRetroWaveRec');

 INSERT INTO Albums(Name,Duration, Artist)
VALUES
 ('Dangerous days', 4080 ,'Perturbator'),
 ('198xad', 4200 ,'Mega Drive');

  INSERT INTO Tracks(Name,Duration, Artist, AlbumID)
VALUES
 ('Welcome back', 183 ,'Perturbator', 1),
 ('Perturbator theme', 366 ,'Perturbator', 1),
 ('Raw power', 305 ,'Perturbator', 1),
 ('Acid Spit', 120 ,'Mega Drive', 2),
 ('Infiltrate', 145 ,'Mega Drive', 2),
 ('NARC', 294, 'Mega Drive', 2);
INSERT INTO Performances(Artist,PerformanceName, PerformanceDate)
VALUES
 ('Perturbator', 'Burning Man', 24/07/2017),
 ('Mega Drive', 'Burning Man',24/07/2017);
