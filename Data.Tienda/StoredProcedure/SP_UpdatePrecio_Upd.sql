CREATE PROCEDURE [dbo].[SP_UpdatePrecio_Upd]
@Precio float ,
@Id int 

AS
BEGIN

	UPDATE Inventario SET Piezas = @Precio WHERE Id = @Id

END
