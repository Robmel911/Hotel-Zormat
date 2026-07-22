-- =========================================
-- Tabla: TipoUsuario
-- Catálogo de roles del sistema (Admin, Recepcionista, etc.)
-- =========================================
-- =========================================
-- Tabla: TipoUsuario
-- =========================================
CREATE TABLE TipoUsuario (
    IdTipo INT IDENTITY(1,1) PRIMARY KEY,
    Tipo VARCHAR(30) NOT NULL
        CONSTRAINT UQ_TipoUsuario_Tipo UNIQUE (Tipo)
);

-- =========================================
-- Tabla: InfoUsuario
-- =========================================
CREATE TABLE InfoUsuario (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL
        CONSTRAINT UQ_InfoUsuario_Nombre UNIQUE (Nombre),
    Contrasena CHAR(64) NOT NULL,
    IdTipo INT NOT NULL,
    Activo BIT NOT NULL
        CONSTRAINT DF_InfoUsuario_Activo DEFAULT 1,
    FechaCreacion DATETIME NOT NULL
        CONSTRAINT DF_InfoUsuario_FechaCreacion DEFAULT GETDATE(),

    CONSTRAINT FK_InfoUsuario_TipoUsuario
        FOREIGN KEY (IdTipo) REFERENCES TipoUsuario(IdTipo)
);
GO

-- =========================================
-- Datos iniciales
-- =========================================
INSERT INTO TipoUsuario (Tipo) VALUES ('Administrador');
INSERT INTO TipoUsuario (Tipo) VALUES ('Recepcionista');

--Admin con su contraseña encriptada (SHA256) y tipo de usuario Administrador
Insert into InfoUsuario (Nombre, Contrasena, IdTipo) values ('Admin', '60fe74406e7f353ed979f350f2fbb6a2e8690a5fa7d1b0c32983d1d8b3f95f67', 1);

--Crear Schema (se me olvido)
CREATE SCHEMA Usuarios;

--Cambiar Tablas a el nuevo esquema
ALTER SCHEMA Usuarios TRANSFER dbo.TipoUsuario;
ALTER SCHEMA Usuarios TRANSFER dbo.InfoUsuario;

--Ver si las tablas fueron transferidas correctamente
SELECT TABLE_SCHEMA, TABLE_NAME 
FROM INFORMATION_SCHEMA.TABLES 
WHERE TABLE_NAME IN ('TipoUsuario', 'InfoUsuario');

CREATE TABLE Usuarios.Bitacora (
    IdBitacora INT IDENTITY(1,1) PRIMARY KEY,
    IdUsuario INT NOT NULL,
    Accion VARCHAR(300) NOT NULL,
    Fecha DATETIME NOT NULL
        CONSTRAINT DF_Bitacora_Fecha DEFAULT GETDATE(),

    CONSTRAINT FK_Bitacora_InfoUsuario
        FOREIGN KEY (IdUsuario) REFERENCES Usuarios.InfoUsuario(IdUsuario)
);
--Crea una view para mostrar la información de la bitácora junto con el nombre del usuario y su rol
--Ahorrar espacio en codigo y mejorar la legibilidad de las consultas
CREATE VIEW Usuarios.VW_Bitacora AS
SELECT 
    b.IdBitacora,
    u.Nombre AS Usuario,
    t.Tipo AS Rol,
    b.Accion,
    b.Fecha
FROM Usuarios.Bitacora b
    INNER JOIN Usuarios.InfoUsuario u ON b.IdUsuario = u.IdUsuario
    INNER JOIN Usuarios.TipoUsuario t ON u.IdTipo = t.IdTipo;

select * from Usuarios.VW_Bitacora;
