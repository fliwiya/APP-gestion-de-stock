CREATE TABLE Consumables (
    Prix_ID INT PRIMARY KEY,
    Designation VARCHAR(255),
    Unite_mesure VARCHAR(50),
    Quantite INT,
    Prix_unitaire_HT DECIMAL(10, 2),
    Prix_total_HT DECIMAL(10, 2)
);

INSERT INTO Consumables (Prix_ID, Designation, Unite_mesure, Quantite, Prix_unitaire_HT, Prix_total_HT)
VALUES 
(1, 'Toner Black pour E-STUDIO 4515AC', 'Unité', 3, 950.00, 2850.00),
(2, 'Toner Yellow pour E-STUDIO 4515AC', 'Unité', 3, 1390.00, 4170.00),
(3, 'Toner Cyan pour E-STUDIO 4515AC', 'Unité', 3, 1390.00, 4170.00),
(4, 'Toner Magenta pour E-STUDIO 4515AC', 'Unité', 3, 1390.00, 4170.00),
(5, 'Bac à déchet pour E-STUDIO 4515AC', 'Unité', 6, 590.00, 3540.00),
(6, 'Toner Black pour E-STUDIO 3505AC', 'Unité', 3, 950.00, 2850.00),
(7, 'Toner Yellow pour E-STUDIO 3505AC', 'Unité', 3, 1390.00, 4170.00),
(8, 'Toner Cyan pour E-STUDIO 3505AC', 'Unité', 3, 1390.00, 4170.00),
(9, 'Toner Magenta pour E-STUDIO 3505AC', 'Unité', 3, 1390.00, 4170.00);

