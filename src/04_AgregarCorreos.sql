USE HPA_Capas_Login;
GO

IF COL_LENGTH('dbo.usuarios', 'dsCorreo') IS NULL
BEGIN
    ALTER TABLE dbo.usuarios ADD dsCorreo NVARCHAR(254) NULL;
END;
GO

UPDATE dbo.usuarios
SET dsCorreo = N'admin@example.com'
WHERE dsUsuario = 'admin' AND dsCorreo IS NULL;
GO

SELECT dsUsuario, dsCorreo
FROM dbo.usuarios
WHERE dsUsuario = 'admin';