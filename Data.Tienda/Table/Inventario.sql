CREATE TABLE [dbo].[Inventario]
(
[Id] INT IDENTITY(1,1)NOT NULL,
[NameProduct] varchar(50) NOT NULL,
[Piezas] INT NOT NULL,
[Precio] FLOAT NOT NULL,
PRIMARY KEY([Id])
);
