USE HPA_Capas_Login;
GO

IF OBJECT_ID(N'dbo.usp_Usuario_ObtenerPorNombre', N'P') IS NOT NULL
BEGIN
    DROP PROCEDURE dbo.usp_Usuario_ObtenerPorNombre;
END;
GO

CREATE PROCEDURE dbo.usp_Usuario_ObtenerPorNombre
    @Usuario VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        id,
        dsId,
        dsUsuario,
        dsPassword,
        dsEstado,
        dsUsuarioCreacion,
        dtFechaCreacion,
        dsUsuarioModificacion,
        dtFechaModificacion
    FROM dbo.usuarios
    WHERE dsUsuario = @Usuario;
END;
GO