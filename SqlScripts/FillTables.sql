INSERT INTO Artists (Name,Genre)
VALUES
 ('Perturbator','Synthwave'),
 ('Mega Drive', 'New retro wave');

 INSERT INTO Labels(Name,Artist)
VALUES
 ('Blood Music', 'Perturbator'),
 ('NewRetroWaveRec', 'Mega Drive');

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
