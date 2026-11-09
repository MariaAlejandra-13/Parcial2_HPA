USE master;
GO

IF DB_ID(N'HPA_Capas_Login') IS NULL
BEGIN
    CREATE DATABASE HPA_Capas_Login;
END;
GO

USE HPA_Capas_Login;
GO

IF OBJECT_ID(N'dbo.usuarios', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.usuarios
    (
        id INT IDENTITY(1,1) NOT NULL
            CONSTRAINT PK_usuarios PRIMARY KEY,

        dsId VARCHAR(50) NOT NULL,

        dsUsuario VARCHAR(50) NOT NULL,

        dsPassword VARBINARY(64) NOT NULL,

        dsEstado CHAR(1) NOT NULL
            CONSTRAINT DF_usuarios_estado DEFAULT ('1'),

        dsUsuarioCreacion VARCHAR(50) NOT NULL
            CONSTRAINT DF_usuarios_creador DEFAULT ('Sistema'),

        dtFechaCreacion DATETIME2(0) NOT NULL
            CONSTRAINT DF_usuarios_fechaCreacion
            DEFAULT (SYSDATETIME()),

        dsUsuarioModificacion VARCHAR(50) NOT NULL
            CONSTRAINT DF_usuarios_modificador
            DEFAULT ('Sistema'),

        dtFechaModificacion DATETIME2(0) NOT NULL
            CONSTRAINT DF_usuarios_fechaModificacion
            DEFAULT (SYSDATETIME()),

        CONSTRAINT UQ_usuarios_dsId UNIQUE (dsId),

        CONSTRAINT UQ_usuarios_dsUsuario UNIQUE (dsUsuario),

        CONSTRAINT CK_usuarios_estado
            CHECK (dsEstado IN ('0', '1'))
    );
END;
GO