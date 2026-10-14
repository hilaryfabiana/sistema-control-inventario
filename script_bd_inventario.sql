-- Crear la base de datos y cambiar al contexto de la misma
CREATE DATABASE Inventario;
GO
USE Inventario;
GO
-- 1. Crear la tabla Gestion_de_Equipos
CREATE TABLE Gestion_de_Equipos (
    id            INT IDENTITY(1,1) PRIMARY KEY,
    Codigo        VARCHAR(100),
    Tipo          VARCHAR(50),
    Marca         VARCHAR(50),
    Modelo        VARCHAR(50),
    Ubicacion     VARCHAR(80),
    Estado        VARCHAR(50)
);
GO
-- Bloque 1: Laboratorio 5 (Orden: Codigo, Tipo, Marca, Modelo, Ubicacion, Estado)
INSERT INTO Gestion_de_Equipos(Codigo,Tipo,Marca,Modelo,Ubicacion,Estado) 
VALUES 
('CBI 0250917', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250918', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250919', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250920', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250925', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250921', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250923', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250924', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250922', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250926', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250942', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250935', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250933', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250943', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250931', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250932', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250929', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250930', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250927', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250928', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250937', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250938', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250939', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250940', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250949', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250941', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250947', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250934', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250945', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250946', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250956', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250953', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250954', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250951', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250952', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250948', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250950', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250936', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0308371', 'CPU', 'LENOVO', 'V520S', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250879', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250878', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250877', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250880', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250890', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0247909', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250883', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250882', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250884', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250885', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250894', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250893', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250892', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250895', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250881', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250891', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250888', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250889', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250886', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250887', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250896', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250897', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250898', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250899', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250900', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250901', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250902', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250903', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250904', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250905', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250914', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250915', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250913', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250912', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250910', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250911', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250908', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250909', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250906', 'MONITOR', 'HP', 'V244h', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250839', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250838', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250837', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250840', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250841', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250842', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250843', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250844', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250845', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250846', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250855', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250856', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250853', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250854', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250851', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0227059', 'TECLADO', 'GENIUS', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0244675', 'TECLADO', 'HP', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250850', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250847', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250848', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250857', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250858', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250859', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250860', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250861', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250862', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250863', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250864', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250865', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250866', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250875', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250876', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250873', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250874', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250871', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0244675', 'TECLADO', 'GENIUS', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 244594', 'TECLADO', 'MICROSOFT', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250867', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0250868', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 5', 'OPERATIVO'),
('CBI 0244599', 'TECLADO', 'GENIUS', 'Sin Modelo', 'Laboratorio 5', 'OPERATIVO'), -- modificado
('CBI 0244594', 'TECLADO', 'MICROSOFT', 'Sin Modelo', 'Laboratorio 5', 'OPERATIVO'), -- modificado
('251829', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('251831', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('251832', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('251837', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('251836', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('251840', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('251839', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('251841', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('251843', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('251844', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('251845', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('251846', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('251847', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('251849', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('251850', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('251830', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('251833', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('308387', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('308383', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('308373', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('308377', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('308378', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('308379', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('308384', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('251838', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('308386', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('308385', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('308381', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('308380', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('308376', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('308375', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('308372', 'ESTABILIZADOR', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('401625', 'ESTABILIZADOR ', 'CDP', 'R2C-AVR1008i', 'Laboratorio 5', 'OPERATIVO'),
('311491', 'PROYECTOR ', 'EPSON', 'Sin Modelo', 'Laboratorio 5', 'OPERATIVO'), -- modificado
('251856', 'ECRAM', 'Sin Marca', 'Sin Modelo', 'Laboratorio 5', 'REGULAR'), -- modificado
('505188', 'SWITCH', 'D-LINK', 'Sin Modelo', 'Laboratorio 5', 'OPERATIVO'), -- modificado
('505181', 'SWITCH', 'D-LINK', 'Sin Modelo', 'Laboratorio 5', 'OPERATIVO');
GO
-- Bloque 2: Taller de Mantenimiento (Orden: Codigo, Tipo, Marca, Modelo, Ubicacion, Estado)
INSERT INTO Gestion_de_Equipos(Codigo,Tipo,Marca,Modelo,Ubicacion,Estado) 
VALUES 
('308611', 'LAPTOP', 'LENOVO', 'Sin Modelo', 'Taller de Mantenimiento', 'REGULAR'), -- modificado
('308613', 'LAPTOP', 'LENOVO', 'Sin Modelo', 'Taller de Mantenimiento', 'REGULAR'), -- modificado
('308606', 'LAPTOP', 'LENOVO', 'Sin Modelo', 'Taller de Mantenimiento', 'REGULAR'), -- modificado
('308764', 'LAPTOP', 'LENOVO', 'Sin Modelo', 'Taller de Mantenimiento', 'REGULAR'), -- modificado
('308686', 'LAPTOP', 'LENOVO', 'Sin Modelo', 'Taller de Mantenimiento', 'REGULAR'), -- modificado
('308603', 'LAPTOP', 'LENOVO', 'Sin Modelo', 'Taller de Mantenimiento', 'REGULAR'), -- modificado
('308690', 'LAPTOP', 'LENOVO', 'Sin Modelo', 'Taller de Mantenimiento', 'REGULAR'), -- modificado
('308696', 'LAPTOP', 'LENOVO', 'Sin Modelo', 'Taller de Mantenimiento', 'REGULAR'), -- modificado
('308605', 'LAPTOP', 'LENOVO', 'Sin Modelo', 'Taller de Mantenimiento', 'REGULAR'), -- modificado
('308604', 'LAPTOP', 'LENOVO', 'Sin Modelo', 'Taller de Mantenimiento', 'REGULAR'), -- modificado
('308684', 'LAPTOP', 'LENOVO', 'Sin Modelo', 'Taller de Mantenimiento', 'REGULAR'), -- modificado
('308617', 'LAPTOP', 'LENOVO', 'Sin Modelo', 'Taller de Mantenimiento', 'REGULAR'), -- modificado
('308682', 'LAPTOP', 'LENOVO', 'Sin Modelo', 'Taller de Mantenimiento', 'REGULAR'), -- modificado
('308598', 'LAPTOP', 'LENOVO', 'Sin Modelo', 'Taller de Mantenimiento', 'REGULAR'), -- modificado
('308607', 'LAPTOP', 'LENOVO', 'Sin Modelo', 'Taller de Mantenimiento', 'REGULAR'), -- modificado
('308691', 'LAPTOP', 'LENOVO', 'Sin Modelo', 'Taller de Mantenimiento', 'REGULAR'), -- modificado
('308597', 'LAPTOP', 'LENOVO', 'Sin Modelo', 'Taller de Mantenimiento', 'REGULAR'), -- modificado
('308612', 'LAPTOP', 'LENOVO', 'Sin Modelo', 'Taller de Mantenimiento', 'REGULAR'), -- modificado
('250208', 'ECRAM', 'Sin Marca', 'Sin Modelo', 'Taller de Mantenimiento', 'REGULAR'), -- modificado
('250210', 'PROYECTOR', 'EPSON', 'H654A', 'Taller de Mantenimiento', 'OPERATIVO'),
('401624', 'ESTABILIZADOR', 'ENERGIT', 'Sin Modelo', 'Taller de Mantenimiento', 'OPERATIVO'), -- modificado
('505241', 'CAJA NEGRA', 'Sin Marca', 'Sin Modelo', 'Taller de Mantenimiento', 'OPERATIVO'), -- modificado
('505242', 'SWITCH', 'D-LINK', 'DGS -1510-28', 'Taller de Mantenimiento', 'OPERATIVO');
GO
-- Bloque 3: Taller de Mantenimiento - Inoperativos (Orden: Tipo, Codigo, Marca, Modelo, Ubicacion, Estado)
INSERT INTO Gestion_de_Equipos(Tipo, Codigo, Marca, Modelo, Ubicacion, Estado) 
VALUES
('CPU', '253237', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'), -- modificado
('CPU', '244902', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '244910', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '250236', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '253911', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '246284', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '246281', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '244904', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '247934', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '254203', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '250231', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '246280', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '247585', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '244757', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '266785', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '505261', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '253832', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '244905', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '246790', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', 'N/A', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'), -- modificado
('CPU', '253591', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '254214', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '250955', 'LENOVO', 'V520S', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '250631', 'HP', 'ELITE DESK 800 G1', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '251701', 'HP', 'ELITE DESK 800 G1', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '600907', 'LENOVO', 'THINK CENTRE M91P', 'Taller de mantenimiento', 'INOPERATIVO'),
('CPU', '250428', 'HP', 'ELITE DESK 800 G2', 'Taller de mantenimiento', 'INOPERATIVO'),
('LAPTOP', '250603', 'TOSHIBA', 'PSLB8UOVS2RL1', 'Taller de mantenimiento', 'INOPERATIVO'),
('LAPTOP', '308609', 'LENOVO', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'), -- modificado
('TECLADO', '247950', 'GENIUS', 'GK-050015', 'Taller de mantenimiento', 'INOPERATIVO'),
('TECLADO', '244935', 'GENIUS', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'), -- modificado
('TECLADO', '250450', 'HP', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'), -- modificado
('TECLADO', '252122', 'MICRONICS', 'MICK522', 'Taller de mantenimiento', 'INOPERATIVO'),
('TECLADO', '247807', 'GENIUS', 'GK-050015', 'Taller de mantenimiento', 'INOPERATIVO'),
('TECLADO', '250456', 'HP', 'Sin Modelo', 'Taller de mantenimiento', 'INOPERATIVO'), -- modificado
('TECLADO', '247947', 'HP', 'KB-1156', 'Taller de mantenimiento', 'INOPERATIVO'),
('TECLADO', '254445', 'HP', 'KB-1469', 'Taller de mantenimiento', 'INOPERATIVO'),
('TECLADO', '247937', 'HP', 'KV-1156', 'Taller de mantenimiento', 'INOPERATIVO'),
('TECLADO', '247940', 'HP', 'KV-1156', 'Taller de mantenimiento', 'INOPERATIVO'),
('TECLADO', '251736', 'HP', 'KB-1156', 'Taller de mantenimiento', 'INOPERATIVO'),
('TECLADO', '308390', 'GENIUS', 'GK-050015', 'Taller de mantenimiento', 'INOPERATIVO'),
('SWICHT', '267652', 'Sin Marca', 'DGS-1510', 'Taller de mantenimiento', 'OPERATIVO'), -- modificado
('ESTABILIZADOR', 'N/A', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'OPERATIVO'), -- modificado
('CAJA NEGRA', '267653', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'BUENO'), -- modificado
('RACK', '250337', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'BUENO'), -- modificado
('ECRAM', '250343', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'BUENO'), -- modificado
('ESTABILIZADOR', 'N/A', 'Sin Marca', 'Sin Modelo', 'Taller de mantenimiento', 'BUENO'); -- modificado
GO
-- Bloque 4: Aulas (Orden: Codigo, Tipo, Marca, Modelo, Ubicacion, Estado)
INSERT INTO Gestion_de_Equipos(Codigo,Tipo,Marca,Modelo,Ubicacion,Estado) 
VALUES 
('250588', 'PROYECTOR', 'EPSON', 'Sin Modelo', 'Aula 401', 'OPERATIVO'), -- modificado
('403210', 'LAPTOP', 'HP', 'AX201NGW', 'Aula 401', 'OPERATIVO'),
('252914', 'ECRAM', 'Sin Marca', 'Sin Modelo', 'Aula 401', 'BUENO'), -- modificado
('311490', 'PROYECTOR', 'EPSON', 'Sin Modelo', 'Aula 402', 'OPERATIVO'), -- modificado
('403209', 'LAPTOP', 'HP', 'AX201NGW', 'Aula 402', 'OPERATIVO'),
('311492', 'PROYECTOR', 'EPSON', 'Sin Modelo', 'Aula 403', 'OPERATIVO'), -- modificado
('403230', 'LAPTOP', 'HP', 'AX201NGW', 'Aula 403', 'OPERATIVO'),
('505262', 'PROYECTOR', 'EPSON', 'Sin Modelo', 'Aula 404', 'OPERATIVO'), -- modificado
('403227', 'LAPTOP', 'HP', 'AX201NGW', 'Aula 404', 'OPERATIVO'),
('300809', 'PROYECTOR', 'EPSON', 'Sin Modelo', 'Aula 405', 'OPERATIVO'), -- modificado
('300813', 'PROYECTOR', 'EPSON', 'Sin Modelo', 'Aula 408', 'OPERATIVO'), -- modificado
('247478', 'PROYECTOR', 'EPSON', 'Sin Modelo', 'Aula 411', 'OPERATIVO');
GO
-- Bloque 5: Laboratorio 2 (Orden: Codigo, Tipo, Marca, Modelo, Ubicacion, Estado)
INSERT INTO Gestion_de_Equipos(Codigo,Tipo,Marca,Modelo,Ubicacion,Estado) 
VALUES 
('CBI 0250151', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250152', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250166', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250182', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250181', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250183', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250184', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250154', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250164', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250169', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250170', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250180', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250179', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250185', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250186', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250155', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250156', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250162', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250161', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250171', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250172', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250177', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250188', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250157', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250158', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250160', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250176', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250175', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250190', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0246857', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250189', 'MONITOR', 'HP', 'N246V', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0312713', 'MONITOR', 'DELL', 'P2419H', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250909', 'MONITOR', 'HP', 'V244h', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250431', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250444', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250461', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250463', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250462', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250434', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250442', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0227074', 'TECLADO', 'GENIUS', 'KB128', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250459', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250458', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250465', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250436', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250441', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250440', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250451', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250466', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250438', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250439', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250454', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250468', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250449', 'TECLADO', 'HP', 'KB-1469', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250286', 'TECLADO', 'GENIUS', 'KB-06XE', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0227062', 'TECLADO', 'GENIUS', 'KB-128', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0227077', 'TECLADO', 'GENIUS', 'KB-128', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250869', 'TECLADO', 'LENOVO', 'KU-1601', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0227065', 'TECLADO', 'GENIUS', 'KB-128', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250292', 'TECLADO', 'GENIUS', 'KB-06XE', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0250870', 'TECLADO', 'LENOVO', '0351206', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0300806', 'PROYECTOR', 'EPSON', 'A51599LCU', 'Laboratorio 2', 'OPERATIVO'),
('CBI 0505200', 'SWITCH', 'DLINK', 'Sin Modelo', 'Laboratorio 2', 'OPERATIVO'), -- modificado
('CBI 0505201', 'SWITCH', 'DLINK', 'Sin Modelo', 'Laboratorio 2', 'OPERATIVO'), -- modificado
('CBI 0505172', 'CAJA NEGRA', 'Sin Marca', 'Sin Modelo', 'Laboratorio 2', 'OPERATIVO'), -- modificado
('CBI 0250483', 'CAMARA DE SEGURIDAD', 'Sin Marca', 'Sin Modelo', 'Laboratorio 2', 'OPERATIVO'); -- modificado
GO
-- Bloque 6: Laboratorio 1 (Orden: Codigo, Tipo, Marca, Modelo, Ubicacion, Estado)
INSERT INTO Gestion_de_Equipos(Codigo,Tipo,Marca,Modelo,Ubicacion,Estado) 
VALUES 
('CBI 0250388', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250386', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250387', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250393', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0247918', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0247925', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250391', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0247926', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0247919', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250394', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251710', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250399', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251703', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251706', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251712', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251709', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251707', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251722', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251708', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0247917', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0247923', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251704', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251717', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251718', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251713', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251714', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251720', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0247916', 'CPU', 'HP', '800G1SF', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250347', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250385', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250349', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250352', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250376', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0308237', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250351', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250350', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250167', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250159', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250355', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250353', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250348', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250366', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250356', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250358', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250368', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250357', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250370', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250371', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250375', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250364', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250367', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250369', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250382', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250362', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250359', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250365', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250381', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250372', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250363', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250361', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0308238', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0250374', 'MONITOR', 'HP', 'C9F26A', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251741', 'TECLADO', 'HP', 'KB-1156', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251742', 'TECLADO', 'HP', 'KB-1156', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251760', 'TECLADO', 'HP', 'SK-2015', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251761', 'TECLADO', 'HP', 'SK-2015', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251748', 'TECLADO', 'HP', 'SK-2015', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251745', 'TECLADO', 'HP', 'KB-1156', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251747', 'TECLADO', 'HP', 'KB-1156', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251744', 'TECLADO', 'HP', 'KB-1156', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251749', 'TECLADO', 'HP', 'SK-2015', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251735', 'TECLADO', 'HP', 'KB-1156', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251757', 'TECLADO', 'HP', 'SK-2015', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251725', 'TECLADO', 'HP', 'KB-1156', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251730', 'TECLADO', 'HP', 'KB-1156', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251727', 'TECLADO', 'HP', 'KB-1156', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251739', 'TECLADO', 'HP', 'KB-1156', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251738', 'TECLADO', 'HP', 'KB-1156', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251755', 'TECLADO', 'HP', 'SK-2015', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251753', 'TECLADO', 'GENIUS', 'GK-050015', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251729', 'TECLADO', 'HP', 'KB-1156', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0251751', 'TECLADO', 'HP', 'SK-2015', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0244676', 'TECLADO', 'HP', 'KB-1156', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0247955', 'TECLADO', 'LENOVO', '11A8A17500', 'Laboratorio 1', 'OPERATIVO'),
('CBI 0247945', 'TECLADO', 'HP', 'Sin Modelo', 'Laboratorio 1', 'OPERATIVO'), -- modificado
('CBI 0250288', 'TECLADO', 'Sin Marca', 'Sin Modelo', 'Laboratorio 1', 'OPERATIVO'), -- modificado
('CBI 0250443', 'TECLADO', 'Sin Marca', 'Sin Modelo', 'Laboratorio 1', 'OPERATIVO'), -- modificado
('CBI 247949', 'TECLADO', 'Sin Marca', 'Sin Modelo', 'Laboratorio 1', 'OPERATIVO'), -- modificado
('CBI 0312677', 'TECLADO', 'Sin Marca', 'Sin Modelo', 'Laboratorio 1', 'OPERATIVO'), -- modificado
('CBI 227072', 'TECLADO', 'Sin Marca', 'Sin Modelo', 'Laboratorio 1', 'OPERATIVO'), -- modificado
('CBI 300815', 'PROYECTOR', 'Sin Marca', 'Sin Modelo', 'Laboratorio 1', 'OPERATIVO'), -- modificado
('CBI 251411', 'ECRAM', 'Sin Marca', 'Sin Modelo', 'Laboratorio 1', 'OPERATIVO'), -- modificado
('CBI 505183', 'SWITCH', 'Sin Marca', 'Sin Modelo', 'Laboratorio 1', 'OPERATIVO'), -- modificado
('CBI 505184', 'SWITCH', 'Sin Marca', 'Sin Modelo', 'Laboratorio 1', 'OPERATIVO'), -- modificado
('CBI 505182', 'CAJA NEGRA', 'Sin Marca', 'Sin Modelo', 'Laboratorio 1', 'OPERATIVO'), -- modificado
('CBI 0252709', 'CAMARA DE SEGURIDAD', 'Sin Marca', 'Sin Modelo', 'Laboratorio 1', 'OPERATIVO'), -- modificado
('CBI 0252708', 'CAMARA DE SEGURIDAD', 'Sin Marca', 'Sin Modelo', 'Laboratorio 1', 'BUENO'); -- modificado
GO

-- 2. Crear la tabla Prestamos_y_Devoluciones (Diseño corregido)
-- 2. Crear la tabla Prestamos_y_Devoluciones (Diseño corregido con Estado)
CREATE TABLE Prestamos_y_Devoluciones (
    id             INT IDENTITY(1,1) PRIMARY KEY,
    codigo_equipo  VARCHAR(100),                  
    docente_alumno VARCHAR(100),
    tipo_operacion VARCHAR(50),
    estado         VARCHAR(50), -- 🟢 NUEVA COLUMNA
    fecha          DATE,
    hora           TIME
);
GO
-- Insertar registros de Préstamos de prueba con Estado
INSERT INTO Prestamos_y_Devoluciones (codigo_equipo, docente_alumno, tipo_operacion, estado, fecha, hora) 
VALUES
('403210', 'Frank', 'prestamos', 'OPERATIVO', '2026-07-01', '21:00:10'),
('403209', 'Gerardo', 'devolución', 'OPERATIVO', '2026-06-29', '20:30:20'),
('403230', 'Panduro', 'devolución', 'BUENO', '2026-06-30', '10:30:30'),
('403227', 'Hilari', 'prestamos', 'OPERATIVO', '2026-07-02', '12:30:00');
GO
-- 3. Crear la tabla Usuarios
CREATE TABLE Usuarios (
    id              INT IDENTITY(1,1) PRIMARY KEY,
    Usuario         VARCHAR(50) UNIQUE NOT NULL,
    Contrasena      VARCHAR(255) NOT NULL, -- Recomendado para contraseñas seguras/encriptadas
    Nombre_Completo VARCHAR(100),
    Rol             VARCHAR(50)
);
GO
-- Insertar registro de Administrador
INSERT INTO Usuarios (Usuario, Contrasena, Nombre_Completo, Rol)
VALUES ('admin', '1234', 'Abraham', 'Administrador');
GO

SELECT * FROM Gestion_de_Equipos
where TIPO = 'LAPTOP'

SELECT * FROM Prestamos_y_Devoluciones
SELECT * FROM Usuarios