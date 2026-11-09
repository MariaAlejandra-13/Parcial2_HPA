USE HPA_Capas_Login;
GO

IF OBJECT_ID(N'dbo.Marcas', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Marcas (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Nombre NVARCHAR(100) NOT NULL UNIQUE
    );
END;
GO

IF OBJECT_ID(N'dbo.Productos', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Productos (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Nombre NVARCHAR(150) NOT NULL,
        MarcaId INT NOT NULL REFERENCES dbo.Marcas(Id),
        Stock INT NOT NULL CHECK (Stock >= 0),
        StockMinimo INT NOT NULL CHECK (StockMinimo >= 0)
    );
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Marcas WHERE Nombre = N'Asus')
    INSERT INTO dbo.Marcas (Nombre) VALUES (N'Asus');

IF NOT EXISTS (SELECT 1 FROM dbo.Marcas WHERE Nombre = N'Lenovo')
    INSERT INTO dbo.Marcas (Nombre) VALUES (N'Lenovo');

INSERT INTO dbo.Productos (Nombre, MarcaId, Stock, StockMinimo)
SELECT v.Producto, m.Id, v.Stock, 5
FROM (VALUES
    (N'Laptop Asus X540LA Intel Core i3',   N'Asus',    2),
    (N'Notebook Asus X455LA Intel Core i3', N'Asus',    2),
    (N'Laptop Asus X556U Intel Core i5',    N'Asus',    3),
    (N'Laptop Lenovo IdeaPad 310',          N'Lenovo',  3),
    (N'Notebook Lenovo IdeaPad 110',        N'Lenovo',  5),
    (N'Laptop Lenovo IdeaPad 320',          N'Lenovo', 12)
) AS v(Producto, Marca, Stock)
JOIN dbo.Marcas AS m ON m.Nombre = v.Marca
WHERE NOT EXISTS (
    SELECT 1 FROM dbo.Productos AS p WHERE p.Nombre = v.Producto
);
GO

CREATE OR ALTER PROCEDURE dbo.usp_Productos_BajoStock
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id, Nombre AS Producto, Stock
    FROM dbo.Productos
    WHERE Stock <= StockMinimo
    ORDER BY Stock, Id;
END;
GO

EXEC dbo.usp_Productos_BajoStock;