CREATE PROCEDURE [dbo].[Sp_PiezasInventario_Upd]
@Piezas int ,
@Id int 

AS
BEGIN

	UPDATE Inventario SET Piezas = @Piezas WHERE Id = @Id

END

