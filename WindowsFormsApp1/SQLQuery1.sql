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
    (1, 'Papier A4 recyclé blanc 80 g', 'Rame', 500, 53.00, 26500.00),
    (2, 'Chemises cartonnées 180g', 'Rame', 10, 66.00, 660.00),
    (3, 'Chemises cartonnées à rabat', 'Unité', 100, 7.00, 700.00),
    (4, 'Post-it 76 mm', 'Unité', 100, 6.00, 600.00),
    (5, 'Spirale n° 6', 'Unité', 100, 0.80, 80.00),
    (6, 'Spirale n° 8', 'Unité', 100, 1.20, 120.00),
    (7, 'Spirale n° 12', 'Unité', 100, 2.20, 220.00),
    (8, 'Spirale n° 14', 'Unité', 100, 2.80, 280.00),
    (9, 'Spirale n° 16', 'Unité', 100, 3.10, 310.00),
    (10, 'Serre feuille n° 6', 'Unité', 200, 0.90, 180.00),
    (11, 'Ciseaux bonne qualité', 'Unité', 15, 10.00, 150.00),
    (12, 'Blanco 2 flacon', 'Unité', 20, 20.00, 400.00),
    (13, 'Gomme', 'Unité', 15, 4.50, 67.50),
    (14, 'Taille crayon', 'Unité', 10, 4.60, 46.00),
    (15, 'Scotch emballage', 'Unité', 20, 11.00, 220.00),
    (16, 'Registre 3 mains', 'Unité', 20, 38.00, 760.00),
    (17, 'Règle 30 cm', 'Unité', 20, 5.00, 100.00),
    (18, 'Marqueur fluorescent (différent couleur)', 'Unité', 100, 14.00, 1400.00),
    (19, 'Chemise coin ouvert', 'Rame', 10, 56.00, 560.00),
    (20, 'Classeurs chronos', 'Unité', 50, 25.00, 1250.00),
    (21, 'Feutres pour tableau magnétique rouge/bleu', 'Unité', 50, 11.00, 550.00),
    (22, 'colle stick GF', 'Unité', 30, 23.00, 690.00),
    (23, 'Calculatrice bonne qualité', 'Unité', 10, 130.00, 1300.00),
    (24, 'Agrafeuse PF', 'Unité', 15, 30.00, 450.00),
	(25, 'Brosse pour tableau magnétique', 'Unité', 10, 15.00, 150.00),
(26, 'Crayon', 'Unité', 100, 4.50, 450.00),
(27, 'Tampon encreur bleu', 'Unité', 10, 11.00, 110.00),
(28, 'Encre pour Tampon encreur bleu', 'Unité', 10, 8.00, 80.00),
(29, 'Pochettes perforées', 'Rame', 30, 76.00, 2280.00),
(30, 'Bloc cube', 'Unité', 30, 28.00, 840.00);

	select * from stockBureau