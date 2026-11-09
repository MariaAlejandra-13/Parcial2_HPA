USE HPA_Capas_Login;
GO

IF NOT EXISTS
(
    SELECT 1
    FROM dbo.usuarios
    WHERE dsUsuario = 'admin'
)
BEGIN
    INSERT INTO dbo.usuarios
    (
        dsId,
        dsUsuario,
        dsPassword,
        dsEstado,
        dsUsuarioCreacion,
        dsUsuarioModificacion
    )
    VALUES
    (
        '001',
        'admin',
        0xba3253876aed6bc22d4a6ff53d8406c6ad864195ed144ab5c87621b6c233b548baeae6956df346ec8c17f5ea10f35ee3cbc514797ed7ddd3145464e2a0bab413,
        '1',
        'Sistema',
        'Sistema'
    );
END;
GO

SELECT
    id,
    dsId,
    dsUsuario,
    dsEstado,
    DATALENGTH(dsPassword) AS BytesDelHash,
    dtFechaCreacion,
    dtFechaModificacion
FROM dbo.usuarios;
GO