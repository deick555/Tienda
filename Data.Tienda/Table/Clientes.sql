CREATE TABLE [dbo].[Clientes]
(
  [Id] INT IDENTITY(1,1)NOT NULL,
  [Nombre] VARCHAR(200) NOT NULL,
  [Direccion] VARCHAR(50) NOT NULL,
  [Telefono] VARCHAR(10) NOT NULL,
  PRIMARY KEY([Id])
)
