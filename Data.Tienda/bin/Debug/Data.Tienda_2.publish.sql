/*
Script de implementación para Data.Tienda

Una herramienta generó este código.
Los cambios realizados en este archivo podrían generar un comportamiento incorrecto y se perderán si
se vuelve a generar el código.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "Data.Tienda"
:setvar DefaultFilePrefix "Data.Tienda"
:setvar DefaultDataPath "C:\Users\Charles\AppData\Local\Microsoft\VisualStudio\SSDT"
:setvar DefaultLogPath "C:\Users\Charles\AppData\Local\Microsoft\VisualStudio\SSDT"

GO
:on error exit
GO
/*
Detectar el modo SQLCMD y deshabilitar la ejecución del script si no se admite el modo SQLCMD.
Para volver a habilitar el script después de habilitar el modo SQLCMD, ejecute lo siguiente:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'El modo SQLCMD debe estar habilitado para ejecutar correctamente este script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creando [dbo].[Sp_PiezasInventario_Upd]...';


GO
CREATE PROCEDURE [dbo].[Sp_PiezasInventario_Upd]
@Piezas int Not Null,
@Id int Not null

AS
BEGIN
	UPDATE Inventario SET Piezas = @Piezas WHERE Id = @Id

END
GO
PRINT N'Actualización completada.';


GO
