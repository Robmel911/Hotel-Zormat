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
