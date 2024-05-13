create table stockBureau(
NumPrd int primary key,
Designation varchar(255),
uniteMesure varchar(255),
PrixU float,
PrixTot float,
QteStock int
)

INSERT INTO stockbureau (NumPrd, Designation, uniteMesure, QteStock, PrixU, PrixTot)
VALUES
    (1, 'Papier A4 recycl� blanc 80 g', 'Rame', 500, 53.00, 26500.00),
    (2, 'Chemises cartonn�es 180g', 'Rame', 10, 66.00, 660.00),
    (3, 'Chemises cartonn�es � rabat', 'Unit�', 100, 7.00, 700.00),
    (4, 'Post-it 76 mm', 'Unit�', 100, 6.00, 600.00),
    (5, 'Spirale n� 6', 'Unit�', 100, 0.80, 80.00),
    (6, 'Spirale n� 8', 'Unit�', 100, 1.20, 120.00),
    (7, 'Spirale n� 12', 'Unit�', 100, 2.20, 220.00),
    (8, 'Spirale n� 14', 'Unit�', 100, 2.80, 280.00),
    (9, 'Spirale n� 16', 'Unit�', 100, 3.10, 310.00),
    (10, 'Serre feuille n� 6', 'Unit�', 200, 0.90, 180.00),
    (11, 'Ciseaux bonne qualit�', 'Unit�', 15, 10.00, 150.00),
    (12, 'Blanco 2 flacon', 'Unit�', 20, 20.00, 400.00),
    (13, 'Gomme', 'Unit�', 15, 4.50, 67.50),
    (14, 'Taille crayon', 'Unit�', 10, 4.60, 46.00),
    (15, 'Scotch emballage', 'Unit�', 20, 11.00, 220.00),
    (16, 'Registre 3 mains', 'Unit�', 20, 38.00, 760.00),
    (17, 'R�gle 30 cm', 'Unit�', 20, 5.00, 100.00),
    (18, 'Marqueur fluorescent (diff�rent couleur)', 'Unit�', 100, 14.00, 1400.00),
    (19, 'Chemise coin ouvert', 'Rame', 10, 56.00, 560.00),
    (20, 'Classeurs chronos', 'Unit�', 50, 25.00, 1250.00),
    (21, 'Feutres pour tableau magn�tique rouge/bleu', 'Unit�', 50, 11.00, 550.00),
    (22, 'colle stick GF', 'Unit�', 30, 23.00, 690.00),
    (23, 'Calculatrice bonne qualit�', 'Unit�', 10, 130.00, 1300.00),
    (24, 'Agrafeuse PF', 'Unit�', 15, 30.00, 450.00),
	(25, 'Brosse pour tableau magn�tique', 'Unit�', 10, 15.00, 150.00),
(26, 'Crayon', 'Unit�', 100, 4.50, 450.00),
(27, 'Tampon encreur bleu', 'Unit�', 10, 11.00, 110.00),
(28, 'Encre pour Tampon encreur bleu', 'Unit�', 10, 8.00, 80.00),
(29, 'Pochettes perfor�es', 'Rame', 30, 76.00, 2280.00),
(30, 'Bloc cube', 'Unit�', 30, 28.00, 840.00);

	select * from stockBureau