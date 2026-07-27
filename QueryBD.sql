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


--Modulo Habitaciones
CREATE SCHEMA Habitaciones;
GO

CREATE TABLE Habitaciones.TipoHabitacion (
    IdTipo INT IDENTITY(1,1) PRIMARY KEY,
    Tipo VARCHAR(30) NOT NULL
        CONSTRAINT UQ_TipoHabitacion_Tipo UNIQUE (Tipo)
);
GO

CREATE TABLE Habitaciones.Habitacion (
    IdHabitacion INT IDENTITY(1,1) PRIMARY KEY,
    Numero INT NOT NULL
        CONSTRAINT UQ_Habitacion_Numero UNIQUE (Numero),
    IdTipo INT NOT NULL,
    Piso INT NOT NULL,
    Capacidad INT NOT NULL
        CONSTRAINT CK_Habitacion_Capacidad CHECK (Capacidad > 0),
    TarifaBase DECIMAL(10,2) NOT NULL
        CONSTRAINT CK_Habitacion_TarifaBase CHECK (TarifaBase > 0),
    Estado VARCHAR(20) NOT NULL
        CONSTRAINT DF_Habitacion_Estado DEFAULT 'Disponible'
        CONSTRAINT CK_Habitacion_Estado CHECK (Estado IN ('Disponible', 'Ocupada', 'Reservada', 'Limpieza')),
    CONSTRAINT FK_Habitacion_TipoHabitacion
        FOREIGN KEY (IdTipo) REFERENCES Habitaciones.TipoHabitacion(IdTipo)
);
GO

CREATE VIEW Habitaciones.VW_Habitacion AS
SELECT
    h.IdHabitacion,
    h.Numero,
    t.Tipo,
    h.Piso,
    h.Capacidad,
    h.TarifaBase,
    h.Estado
FROM Habitaciones.Habitacion h
    INNER JOIN Habitaciones.TipoHabitacion t ON h.IdTipo = t.IdTipo;
GO

-- Datos iniciales
INSERT INTO Habitaciones.TipoHabitacion (Tipo) VALUES ('Individual');
INSERT INTO Habitaciones.TipoHabitacion (Tipo) VALUES ('Doble');
INSERT INTO Habitaciones.TipoHabitacion (Tipo) VALUES ('Suite');
GO

-- Datos de prueba (IdTipo: 1=Individual, 2=Doble, 3=Suite)
INSERT INTO Habitaciones.Habitacion (Numero, IdTipo, Piso, Capacidad, TarifaBase, Estado) VALUES
(101, 1, 1, 1, 1500.00, 'Disponible'),
(102, 2, 1, 2, 2200.00, 'Disponible'),
(201, 3, 2, 4, 4500.00, 'Limpieza'),
(202, 2, 2, 2, 2200.00, 'Ocupada');
GO

select * from Habitaciones.VW_Habitacion;
select * from Habitaciones.TipoHabitacion;
go

Use HotelZormat;

-- ============================================
-- MODULO: HUESPEDES
-- ============================================

CREATE SCHEMA Huespedes;
GO

-- Tabla principal de huespedes
-- TipoDocumento: conjunto cerrado y fijo -> VARCHAR + CHECK en SQL, enum en C#
--                (mismo criterio usado en Estado de Habitacion)
CREATE TABLE Huespedes.Huesped (
    IdHuesped INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    TipoDocumento VARCHAR(20) NOT NULL
        CONSTRAINT CK_Huesped_TipoDocumento
        CHECK (TipoDocumento IN ('Cedula', 'Pasaporte', 'LicenciaConducir', 'Otro')),
    NumeroDocumento VARCHAR(20) NOT NULL,
    Nacionalidad VARCHAR(50) NOT NULL,
    Telefono VARCHAR(20) NULL,
    Email VARCHAR(100) NULL,
    FechaRegistro DATETIME NOT NULL
        CONSTRAINT DF_Huesped_FechaRegistro DEFAULT GETDATE(),
    CONSTRAINT UQ_Huesped_Documento
        UNIQUE (TipoDocumento, NumeroDocumento)
);
GO

-- Huespedes de prueba
INSERT INTO Huespedes.Huesped (Nombre, Apellido, TipoDocumento, NumeroDocumento, Nacionalidad, Telefono, Email) VALUES
('Juan', 'Perez', 'Cedula', '001-1234567-8', 'Dominicana', '809-555-0101', 'juan.perez@correo.com'),
('Maria', 'Gomez', 'Pasaporte', 'A1234567', 'Estados Unidos', '809-555-0102', 'maria.gomez@correo.com'),
('Carlos', 'Diaz', 'Cedula', '402-9876543-2', 'Dominicana', NULL, NULL);
GO

select * from Huespedes.Huesped;

-- ============================================
-- MODULO: RESERVAS
-- ============================================

CREATE SCHEMA Reservas;
GO

-- Tabla principal de reservas
-- Estado: conjunto cerrado y fijo -> igual criterio que TipoDocumento / EstadoHabitacion
-- Temporada: se selecciona al crear la reserva (no es propiedad fija de la habitacion)
CREATE TABLE Reservas.Reserva (
    IdReserva INT IDENTITY(1,1) PRIMARY KEY,
    IdHabitacion INT NOT NULL
        CONSTRAINT FK_Reserva_Habitacion
        REFERENCES Habitaciones.Habitacion(IdHabitacion),
    IdHuesped INT NOT NULL
        CONSTRAINT FK_Reserva_Huesped
        REFERENCES Huespedes.Huesped(IdHuesped),
    FechaCheckIn DATE NOT NULL,
    FechaCheckOut DATE NOT NULL,
    Estado VARCHAR(20) NOT NULL
        CONSTRAINT DF_Reserva_Estado DEFAULT 'Pendiente'
        CONSTRAINT CK_Reserva_Estado
        CHECK (Estado IN ('Pendiente', 'Confirmada', 'Cancelada')),
    Temporada VARCHAR(10) NOT NULL
        CONSTRAINT CK_Reserva_Temporada
        CHECK (Temporada IN ('Alta', 'Media', 'Baja')),
    CantidadNoches AS DATEDIFF(DAY, FechaCheckIn, FechaCheckOut) PERSISTED,
    TarifaAplicada DECIMAL(10,2) NOT NULL,
    MontoTotal DECIMAL(10,2) NOT NULL,
    FechaCreacion DATETIME NOT NULL
        CONSTRAINT DF_Reserva_FechaCreacion DEFAULT GETDATE(),
    CONSTRAINT CK_Reserva_Fechas
        CHECK (FechaCheckOut > FechaCheckIn)
);
GO

-- Reservas de prueba
INSERT INTO Reservas.Reserva (IdHabitacion, IdHuesped, FechaCheckIn, FechaCheckOut, Estado, Temporada, TarifaAplicada, MontoTotal) VALUES
(1, 1, '2026-07-25', '2026-07-28', 'Confirmada', 'Alta',  2500.00, 7500.00),
(2, 2, '2026-07-24', '2026-07-25', 'Pendiente',  'Media', 1800.00, 1620.00),
(3, 3, '2026-08-01', '2026-08-05', 'Pendiente',  'Baja',  3000.00, 9600.00);
GO

select * from Reservas.Reserva;
go


-- ============================================
-- VISTA: Reservas con datos de Habitacion y Huesped
-- ============================================

CREATE VIEW Reservas.vw_ReservaDetalle AS
SELECT
    r.IdReserva,
    r.IdHabitacion,
    h.Numero,
    r.IdHuesped,
    hu.Nombre + ' ' + hu.Apellido AS NombreHuesped,
    hu.NumeroDocumento,
    r.FechaCheckIn,
    r.FechaCheckOut,
    r.CantidadNoches,
    r.Estado,
    r.Temporada,
    r.TarifaAplicada,
    r.MontoTotal,
    r.FechaCreacion
FROM Reservas.Reserva r
INNER JOIN Habitaciones.Habitacion h ON h.IdHabitacion = r.IdHabitacion
INNER JOIN Huespedes.Huesped hu ON hu.IdHuesped = r.IdHuesped;
GO

select * from Reservas.vw_ReservaDetalle;

-- ============================================
-- VISTA: Reservas simplificada (solo nombres, sin IDs)
-- ============================================

CREATE VIEW Reservas.vw_ReservaSimple AS
SELECT
    h.Numero,
    hu.Nombre + ' ' + hu.Apellido AS NombreHuesped,
    r.FechaCheckIn,
    r.FechaCheckOut,
    r.CantidadNoches,
    r.Estado,
    r.Temporada,
    r.MontoTotal
FROM Reservas.Reserva r
INNER JOIN Habitaciones.Habitacion h ON h.IdHabitacion = r.IdHabitacion
INNER JOIN Huespedes.Huesped hu ON hu.IdHuesped = r.IdHuesped;


-- Ajuste al CHECK existente en Reservas.Reserva
ALTER TABLE Reservas.Reserva DROP CONSTRAINT CK_Reserva_Estado;
GO
ALTER TABLE Reservas.Reserva ADD CONSTRAINT CK_Reserva_Estado
    CHECK (Estado IN ('Pendiente', 'Confirmada', 'Cancelada', 'Completada'));
GO
-- Agregar la columna
ALTER TABLE Usuarios.Bitacora
ADD Descripcion VARCHAR(300) NULL;

-- Rellenar los registros de login que ya existen
UPDATE b
SET b.Descripcion = u.Nombre + ' inicio sesion'
FROM Usuarios.Bitacora b
    INNER JOIN Usuarios.InfoUsuario u ON b.IdUsuario = u.IdUsuario
WHERE b.Accion = 'Inicio de sesion';
ALTER VIEW Usuarios.VW_Bitacora AS
SELECT 
    b.IdBitacora,
    u.Nombre AS Usuario,
    t.Tipo AS Rol,
    b.Accion,
    b.Descripcion,
    b.Fecha
FROM Usuarios.Bitacora b
    INNER JOIN Usuarios.InfoUsuario u ON b.IdUsuario = u.IdUsuario
    INNER JOIN Usuarios.TipoUsuario t ON u.IdTipo = t.IdTipo;

    -- Crear el nuevo schema
CREATE SCHEMA Auditoria;
GO

-- Transferir la tabla (mantiene datos, PK, FK, todo)
ALTER SCHEMA Auditoria TRANSFER Usuarios.Bitacora;
GO

-- La vista vieja quedó huérfana, hay que recrearla en el nuevo schema
DROP VIEW Usuarios.VW_Bitacora;
GO

CREATE VIEW Auditoria.VW_Bitacora AS
SELECT 
    b.IdBitacora,
    u.Nombre AS Usuario,
    t.Tipo AS Rol,
    b.Accion,
    b.Descripcion,
    b.Fecha
FROM Auditoria.Bitacora b
    INNER JOIN Usuarios.InfoUsuario u ON b.IdUsuario = u.IdUsuario
    INNER JOIN Usuarios.TipoUsuario t ON u.IdTipo = t.IdTipo;
GO

    -- ============================================
-- MODULO: FACTURACION
-- ============================================

CREATE SCHEMA Facturacion;
GO

-- ============================================
-- TABLA: Factura
-- ============================================
CREATE TABLE Facturacion.Factura (
    IdFactura INT IDENTITY(1,1) PRIMARY KEY,
    IdReserva INT NOT NULL
        CONSTRAINT FK_Factura_Reserva
        REFERENCES Reservas.Reserva(IdReserva),

    -- NCF tipo Consumo Final (B02), simplificado: secuencial atado a IdFactura.
    -- Nota para defensa: un NCF real se administra con rango autorizado por DGII,
    -- independiente del PK interno. Aqui se simplifica por alcance academico.
    NumeroNCF AS ('B02' + RIGHT('00000000' + CAST(IdFactura AS VARCHAR(8)), 8)) PERSISTED,

    FechaEmision DATETIME NOT NULL
        CONSTRAINT DF_Factura_FechaEmision DEFAULT GETDATE(),

    -- Subtotal = snapshot de Reserva.MontoTotal (noches x tarifa), SIN impuestos.
    -- Es el UNICO monto que se inserta a mano; todo lo demas se deriva de aqui.
    Subtotal DECIMAL(10,2) NOT NULL
        CONSTRAINT CK_Factura_SubtotalPositivo CHECK (Subtotal >= 0),

    -- ITBIS = 18% del Subtotal, calculada -> imposible insertar un valor inconsistente
    ITBIS AS (Subtotal * 0.18) PERSISTED,

    -- PropinaLegal = 10% del Subtotal, calculada, mismo motivo
    PropinaLegal AS (Subtotal * 0.10) PERSISTED,

    -- MontoTotal = Subtotal + ITBIS + PropinaLegal.
    -- Distinto de Reserva.MontoTotal (ese NO incluye impuestos/propina).
    -- Se repite la formula en vez de sumar ITBIS+PropinaLegal porque SQL Server
    -- no permite referenciar una columna calculada dentro de otra en todas las versiones.
    MontoTotal AS (Subtotal + (Subtotal * 0.18) + (Subtotal * 0.10)) PERSISTED,

    MetodoPago VARCHAR(20) NOT NULL
        CONSTRAINT CK_Factura_MetodoPago
        CHECK (MetodoPago IN ('Efectivo', 'Tarjeta', 'Transferencia')),

    Estado VARCHAR(20) NOT NULL
        CONSTRAINT DF_Factura_Estado DEFAULT 'Emitida'
        CONSTRAINT CK_Factura_Estado
        CHECK (Estado IN ('Emitida', 'Anulada')),

    CONSTRAINT UQ_Factura_Reserva UNIQUE (IdReserva) -- 1 a 1: una reserva -> una factura
);
GO

-- ============================================
-- RENOMBRAR MetodoPago -> FormaPago en Facturacion.Factura
-- ============================================

-- 1. Renombrar la columna
ALTER TABLE Facturacion.Factura DROP CONSTRAINT CK_Factura_MetodoPago;
GO

-- 2. Ahora si se puede renombrar la columna sin la dependencia enforced
EXEC sp_rename 'Facturacion.Factura.MetodoPago', 'FormaPago', 'COLUMN';
GO

-- 3. Recrear el constraint ya apuntando a la columna con su nombre nuevo
ALTER TABLE Facturacion.Factura ADD CONSTRAINT CK_Factura_FormaPago
    CHECK (FormaPago IN ('Efectivo', 'Tarjeta', 'Transferencia'));
GO

-- ============================================
-- RECREAR VISTA con el nombre nuevo
-- ============================================
CREATE OR ALTER VIEW Facturacion.vw_FacturaDetalle AS
SELECT
    f.IdFactura,
    f.NumeroNCF,
    f.IdReserva,
    h.Numero,
    hu.Nombre + ' ' + hu.Apellido AS NombreHuesped,
    hu.NumeroDocumento,
    r.FechaCheckIn,
    r.FechaCheckOut,
    r.CantidadNoches,
    f.FechaEmision,
    f.Subtotal,
    f.ITBIS,
    f.PropinaLegal,
    f.MontoTotal,
    f.FormaPago,
    f.Estado
FROM Facturacion.Factura f
INNER JOIN Reservas.Reserva r ON r.IdReserva = f.IdReserva
INNER JOIN Habitaciones.Habitacion h ON h.IdHabitacion = r.IdHabitacion
INNER JOIN Huespedes.Huesped hu ON hu.IdHuesped = r.IdHuesped;
GO

-- ============================================
-- RECREAR STORED PROCEDURE con el parametro renombrado
-- ============================================
CREATE OR ALTER PROCEDURE Facturacion.sp_GenerarFactura
    @IdReserva INT,
    @IdHabitacion INT,
    @Subtotal DECIMAL(10,2),
    @FormaPago VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

        IF NOT EXISTS (SELECT 1 FROM Reservas.Reserva WHERE IdReserva = @IdReserva)
            THROW 51000, 'La reserva especificada no existe.', 1;

        IF EXISTS (SELECT 1 FROM Facturacion.Factura WHERE IdReserva = @IdReserva)
            THROW 51002, 'Esta reserva ya tiene una factura generada.', 1;

        INSERT INTO Facturacion.Factura (IdReserva, Subtotal, FormaPago)
        VALUES (@IdReserva, @Subtotal, @FormaPago);

        UPDATE Habitaciones.Habitacion
        SET Estado = 'Limpieza'
        WHERE IdHabitacion = @IdHabitacion
          AND Estado = 'Ocupada';
        IF @@ROWCOUNT = 0
            THROW 51003, 'La habitación no estaba en estado Ocupada.', 1;

        UPDATE Reservas.Reserva
        SET Estado = 'Completada'
        WHERE IdReserva = @IdReserva
          AND Estado = 'Confirmada';
        IF @@ROWCOUNT = 0
            THROW 51004, 'La reserva no estaba en estado Confirmada.', 1;

        COMMIT TRANSACTION;
        SELECT SCOPE_IDENTITY() AS IdFactura;
    END TRY
    BEGIN CATCH
        IF XACT_STATE() <> 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO
GO

select * from Reservas.vw_ReservaSimple;
go
