CREATE TABLE [dbo].[Ventas]
(
[Id] INT IDENTITY(1,1)NOT NULL,
[ProductoId] INT NOT NULL,
[NombreProducto] VARCHAR(50),
[Piezas] INT NOT NULL,
[Precio] FLOAT NOT NULL,
[Total] FLOAT NOT NULL
PRIMARY KEY([Id]),
FOREIGN KEY([ProductoId])REFERENCES [dbo].[Inventario]([Id])
);
