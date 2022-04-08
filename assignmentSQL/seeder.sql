USE FindPetOwner;

INSERT INTO Users
VALUES
('Dana', 'Marcu', 'dana.marcu@mail.com', '0755100100', 'Gorunului, 7, Oradea'),
('Anca', 'Patcas', 'anca.patcasu@mail.com', '0755100200', 'Alunului, 20, Oradea'),
('Marius', 'Babalai', 'marius.babalai@mail.com', '0755100300', 'Aluminei, 7, Oradea'),
('Doina', 'Bacter', 'doina.bacter@mail.com', '0755100400', 'Calea Aradului, 3, Oradea'),
('Alin', 'Hadade', 'alin.hadadeu@mail.com', '0755100500', 'Calea Clujului, 20, Oradea'),
('Camelia', 'Amariei', 'camelia.amariei@mail.com', '0755100600', 'Progresului, 27, Oradea'),
('Gabriela', 'Stanciu', 'gabriela.stanciu@mail.com', '0755100700', 'Stadionului, 22, Beius'),
('Abel', 'Pantea', 'abel.pantea@mail.com', '0755100800', 'Panselutelor, 2, Stei'),
('Dorel', 'Pantea', 'dorel.pantea@mail.com', '0755100900', 'Copacilor, 5, Oradea'),
('Gheorghina', 'Marchis', 'gheorghina.marchisu@mail.com', '0755100110', 'Daliei, 20, Oradea')


INSERT INTO FoundPetPosts
VALUES
(1, 'pic1',  '0755100100', '2022-01-23 12:45:00', '2022-01-23 20:45:00', '','Gorunului, 7, Oradea', '','inprogress', '4558745'),
(1, 'pic2',  '0755100100', '2022-01-25 12:05:00', '2022-01-25 20:45:00', '','Gorunului, 7, Oradea', '','open', '124345635'),
(2, 'pic3',  '0755100200', '2022-03-30 12:45:00', '2022-03-31 20:45:00', '','Alunului, 20, Oradea', '','open', '12225635'),
(3, 'pic4',  '0755100300', '2022-03-23 10:45:00', '2022-03-23 22:45:00', '','Aluminei, 7, Oradea', '','open', '125456565'),
(3, 'pic5',  '0755100300', '2022-01-23 12:45:00', '2022-01-23 21:45:00', '','Aluminei, 7, Oradea', '','open', '1256665'),
(4, 'pic6',  '0755100400', '2022-01-24 12:45:00', '2022-01-24 20:45:00', '','Calea Aradului, 3, Oradea', '','open', '125458745'),
(5, 'pic7',  '0755100500', '2022-01-25 12:45:00', '2022-01-25 20:45:00', '','Calea Clujului, 20, Oradea', '','open', '125458775'),
(6, 'pic8',  '0755100600', '2022-02-23 12:45:00', '2022-02-23 22:45:00', '','Progresului, 27, Oradea', '','open', '124435845'),
(7, 'pic9',  '0755100700', '2022-02-23 12:45:00', '2022-02-23 23:45:00', '','Stadionului, 22, Beius', '','open', '12548745'),
(7, 'pic10', '0755100700', '2022-03-23 12:45:00', '2022-03-23 20:45:00', '','Stadionului, 22, Beius', '','open', '12545445')


INSERT INTO AssignedVolunteers
VALUES
(8, 3, '2022-01-23 19:40:00', 'scheduled'),
(7, 11, '2022-01-23 19:40:00', 'scheduled'),
(7, 12, '2022-01-23 19:40:00', 'scheduled'),
(8, 4, '2022-01-25 20:45:00', 'scheduled'),
(9, 5, '2022-01-23 19:40:00', 'scheduled'),
(8, 6, '2022-01-23 19:40:00', 'scheduled'),
(8, 7, '2022-01-23 19:40:00', 'cancelled'),
(9, 8, '2022-01-23 19:40:00', 'cancelled'),
(9, 9, '2022-01-23 19:40:00', 'cancelled'),
(9, 10, '2022-01-23 19:40:00', 'closed')
