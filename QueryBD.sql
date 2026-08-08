USE [HotelZormat]
GO
/****** Object:  Schema [Auditoria]    Script Date: 08/08/2026 12:27:07 a. m. ******/
CREATE SCHEMA [Auditoria]
GO
/****** Object:  Schema [Estadias]    Script Date: 08/08/2026 12:27:07 a. m. ******/
CREATE SCHEMA [Estadias]
GO
/****** Object:  Schema [Facturacion]    Script Date: 08/08/2026 12:27:07 a. m. ******/
CREATE SCHEMA [Facturacion]
GO
/****** Object:  Schema [Habitaciones]    Script Date: 08/08/2026 12:27:07 a. m. ******/
CREATE SCHEMA [Habitaciones]
GO
/****** Object:  Schema [Huespedes]    Script Date: 08/08/2026 12:27:07 a. m. ******/
CREATE SCHEMA [Huespedes]
GO
/****** Object:  Schema [Reservas]    Script Date: 08/08/2026 12:27:07 a. m. ******/
CREATE SCHEMA [Reservas]
GO
/****** Object:  Schema [Usuarios]    Script Date: 08/08/2026 12:27:07 a. m. ******/
CREATE SCHEMA [Usuarios]
GO
/****** Object:  Table [Usuarios].[TipoUsuario]    Script Date: 08/08/2026 12:27:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Usuarios].[TipoUsuario](
	[IdTipo] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Usuarios].[InfoUsuario]    Script Date: 08/08/2026 12:27:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Usuarios].[InfoUsuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Contrasena] [char](64) NOT NULL,
	[IdTipo] [int] NOT NULL,
	[Activo] [bit] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Auditoria].[Bitacora]    Script Date: 08/08/2026 12:27:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Auditoria].[Bitacora](
	[IdBitacora] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Accion] [varchar](300) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Descripcion] [varchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdBitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [Auditoria].[VW_Bitacora]    Script Date: 08/08/2026 12:27:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Auditoria].[VW_Bitacora] AS
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
/****** Object:  Table [Estadias].[EstadiaServicio]    Script Date: 08/08/2026 12:27:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Estadias].[EstadiaServicio](
	[IdEstadiaServicio] [int] IDENTITY(1,1) NOT NULL,
	[IdEstadia] [int] NOT NULL,
	[IdServicio] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioUnitario] [decimal](10, 2) NOT NULL,
	[FechaConsumo] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEstadiaServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [Estadias].[vw_ConsumoPorEstadia]    Script Date: 08/08/2026 12:27:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Estadias].[vw_ConsumoPorEstadia] AS
SELECT
    es.IdEstadia,
    SUM(es.Cantidad * es.PrecioUnitario) AS TotalServicios
FROM Estadias.EstadiaServicio es
GROUP BY es.IdEstadia;
GO
/****** Object:  Table [Habitaciones].[TipoHabitacion]    Script Date: 08/08/2026 12:27:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Habitaciones].[TipoHabitacion](
	[IdTipo] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Habitaciones].[Habitacion]    Script Date: 08/08/2026 12:27:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Habitaciones].[Habitacion](
	[IdHabitacion] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [int] NOT NULL,
	[IdTipo] [int] NOT NULL,
	[Piso] [int] NOT NULL,
	[Capacidad] [int] NOT NULL,
	[TarifaBase] [decimal](10, 2) NOT NULL,
	[Estado] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdHabitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [Habitaciones].[VW_Habitacion]    Script Date: 08/08/2026 12:27:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [Habitaciones].[VW_Habitacion] AS
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
/****** Object:  Table [Huespedes].[Huesped]    Script Date: 08/08/2026 12:27:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Huespedes].[Huesped](
	[IdHuesped] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[TipoDocumento] [varchar](20) NOT NULL,
	[NumeroDocumento] [varchar](20) NOT NULL,
	[Telefono] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[IdNacionalidad] [int] NOT NULL,
	[NacionalidadEspecifica] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdHuesped] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Reservas].[Reserva]    Script Date: 08/08/2026 12:27:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Reservas].[Reserva](
	[IdReserva] [int] IDENTITY(1,1) NOT NULL,
	[IdHabitacion] [int] NOT NULL,
	[IdHuesped] [int] NOT NULL,
	[FechaCheckIn] [date] NOT NULL,
	[FechaCheckOut] [date] NOT NULL,
	[Estado] [varchar](20) NOT NULL,
	[Temporada] [varchar](10) NOT NULL,
	[CantidadNoches]  AS (datediff(day,[FechaCheckIn],[FechaCheckOut])) PERSISTED,
	[TarifaAplicada] [decimal](10, 2) NOT NULL,
	[MontoTotal] [decimal](10, 2) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [Reservas].[vw_ReservaDetalle]    Script Date: 08/08/2026 12:27:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Reservas].[vw_ReservaDetalle] AS
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
/****** Object:  View [Reservas].[vw_ReservaSimple]    Script Date: 08/08/2026 12:27:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Reservas].[vw_ReservaSimple] AS
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
GO
/****** Object:  Table [Facturacion].[Factura]    Script Date: 08/08/2026 12:27:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Facturacion].[Factura](
	[IdFactura] [int] IDENTITY(1,1) NOT NULL,
	[IdReserva] [int] NOT NULL,
	[NumeroNCF]  AS ('B02'+right('00000000'+CONVERT([varchar](8),[IdFactura]),(8))) PERSISTED,
	[FechaEmision] [datetime] NOT NULL,
	[Subtotal] [decimal](10, 2) NOT NULL,
	[ITBIS]  AS ([Subtotal]*(0.18)) PERSISTED,
	[PropinaLegal]  AS ([Subtotal]*(0.10)) PERSISTED,
	[MontoTotal]  AS (([Subtotal]+[Subtotal]*(0.18))+[Subtotal]*(0.10)) PERSISTED,
	[FormaPago] [varchar](20) NOT NULL,
	[Estado] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [Facturacion].[vw_FacturaDetalle]    Script Date: 08/08/2026 12:27:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   VIEW [Facturacion].[vw_FacturaDetalle] AS
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
/****** Object:  Table [Estadias].[Estadia]    Script Date: 08/08/2026 12:27:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Estadias].[Estadia](
	[IdEstadia] [int] IDENTITY(1,1) NOT NULL,
	[IdReserva] [int] NOT NULL,
	[IdHabitacion] [int] NOT NULL,
	[FechaInicio] [datetime] NOT NULL,
	[FechaFin] [datetime] NULL,
	[Motivo] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEstadia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Estadias].[Servicio]    Script Date: 08/08/2026 12:27:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Estadias].[Servicio](
	[IdServicio] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Precio] [decimal](10, 2) NOT NULL,
	[Activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Huespedes].[Nacionalidad]    Script Date: 08/08/2026 12:27:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Huespedes].[Nacionalidad](
	[IdNacionalidad] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdNacionalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [Auditoria].[Bitacora] ON 
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (1, 1, N'Inicio de sesion', CAST(N'2026-07-21T21:52:23.300' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (2, 1, N'Inicio de sesion', CAST(N'2026-07-22T22:19:22.163' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (3, 1, N'Inicio de sesion', CAST(N'2026-07-22T22:22:04.623' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (4, 1, N'Inicio de sesion', CAST(N'2026-07-22T22:33:45.627' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (5, 1, N'Inicio de sesion', CAST(N'2026-07-22T22:37:10.043' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (6, 1, N'Inicio de sesion', CAST(N'2026-07-22T23:20:06.133' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (7, 1, N'Inicio de sesion', CAST(N'2026-07-22T23:57:59.313' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (8, 1, N'Inicio de sesion', CAST(N'2026-07-23T22:41:15.910' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (9, 1, N'Inicio de sesion', CAST(N'2026-07-23T22:52:06.717' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (10, 1, N'Inicio de sesion', CAST(N'2026-07-23T22:52:58.967' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (11, 1, N'Inicio de sesion', CAST(N'2026-07-24T23:20:54.183' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (12, 1, N'Inicio de sesion', CAST(N'2026-07-24T23:22:24.677' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (13, 1, N'Inicio de sesion', CAST(N'2026-07-24T23:32:32.600' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (14, 1, N'Inicio de sesion', CAST(N'2026-07-24T23:33:45.913' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (15, 1, N'Inicio de sesion', CAST(N'2026-07-24T23:38:56.943' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (16, 1, N'Inicio de sesion', CAST(N'2026-07-24T23:43:42.927' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (17, 1, N'Inicio de sesion', CAST(N'2026-07-24T23:44:59.633' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (18, 1, N'Inicio de sesion', CAST(N'2026-07-24T23:51:48.683' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (19, 1, N'Inicio de sesion', CAST(N'2026-07-25T08:39:19.250' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (20, 1, N'Inicio de sesion', CAST(N'2026-07-26T18:59:32.137' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (21, 1, N'Inicio de sesion', CAST(N'2026-07-26T19:39:36.923' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (22, 1, N'Inicio de sesion', CAST(N'2026-07-26T19:54:08.740' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (23, 1, N'Inicio de sesion', CAST(N'2026-07-26T21:58:45.580' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (24, 1, N'Inicio de sesion', CAST(N'2026-07-26T21:59:04.357' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (25, 1, N'Inicio de sesion', CAST(N'2026-07-26T22:13:01.927' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (26, 1, N'Inicio de sesion', CAST(N'2026-07-26T22:15:14.747' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (27, 1, N'GenerarFactura', CAST(N'2026-07-26T22:15:58.197' AS DateTime), N'Factura #2 generada para Reserva #1, Habitacion #1 liberada.')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (28, 1, N'Inicio de sesion', CAST(N'2026-07-26T22:17:20.220' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (29, 1, N'Inicio de sesion', CAST(N'2026-07-26T22:20:48.010' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (30, 1, N'Inicio de sesion', CAST(N'2026-07-26T22:24:57.747' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (31, 1, N'Inicio de sesion', CAST(N'2026-07-26T22:26:07.577' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (32, 1, N'Inicio de sesion', CAST(N'2026-07-26T22:27:15.963' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (33, 1, N'Inicio de sesion', CAST(N'2026-07-26T22:27:59.463' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (34, 1, N'Inicio de sesion', CAST(N'2026-07-27T22:06:41.340' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (35, 1, N'Inicio de sesion', CAST(N'2026-07-27T22:07:34.213' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (36, 1, N'Inicio de sesion', CAST(N'2026-07-27T22:23:25.300' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (37, 1, N'Inicio de sesion', CAST(N'2026-07-27T22:29:44.877' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (38, 1, N'Inicio de sesion', CAST(N'2026-07-27T22:37:38.930' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (39, 1, N'Inicio de sesion', CAST(N'2026-07-27T22:39:28.827' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (40, 1, N'Inicio de sesion', CAST(N'2026-07-27T22:40:05.053' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (41, 1, N'Inicio de sesion', CAST(N'2026-07-27T22:41:05.457' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (42, 1, N'Inicio de sesion', CAST(N'2026-07-27T22:41:24.553' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (43, 1, N'Inicio de sesion', CAST(N'2026-07-27T22:42:23.343' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (44, 1, N'Inicio de sesion', CAST(N'2026-07-27T22:42:49.940' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (45, 1, N'Inicio de sesion', CAST(N'2026-07-27T23:00:35.383' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (46, 1, N'Inicio de sesion', CAST(N'2026-07-27T23:04:43.950' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (47, 1, N'Inicio de sesion', CAST(N'2026-07-27T23:07:44.407' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (48, 1, N'Inicio de sesion', CAST(N'2026-07-29T18:37:45.603' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (49, 1, N'Inicio de sesion', CAST(N'2026-07-29T19:17:27.900' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (50, 1, N'Inicio de sesion', CAST(N'2026-07-29T22:22:17.943' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (51, 1, N'Inicio de sesion', CAST(N'2026-07-29T22:22:58.567' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (52, 1, N'Inicio de sesion', CAST(N'2026-07-29T22:24:29.383' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (53, 1, N'Inicio de sesion', CAST(N'2026-07-29T22:27:10.217' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (54, 1, N'Inicio de sesion', CAST(N'2026-07-29T22:28:48.423' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (55, 1, N'Inicio de sesion', CAST(N'2026-07-29T22:29:39.920' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (56, 1, N'Inicio de sesion', CAST(N'2026-07-29T22:31:46.790' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (57, 1, N'Inicio de sesion', CAST(N'2026-07-29T22:34:04.597' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (58, 1, N'Inicio de sesion', CAST(N'2026-07-29T22:38:00.110' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (59, 1, N'Inicio de sesion', CAST(N'2026-07-29T22:43:23.253' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (60, 1, N'Inicio de sesion', CAST(N'2026-07-29T22:45:14.460' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (61, 1, N'Inicio de sesion', CAST(N'2026-07-29T22:51:22.927' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (62, 1, N'Inicio de sesion', CAST(N'2026-07-29T23:37:51.007' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (63, 1, N'Inicio de sesion', CAST(N'2026-07-30T22:59:55.657' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (64, 1, N'Inicio de sesion', CAST(N'2026-07-30T23:04:17.760' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (65, 1, N'Inicio de sesion', CAST(N'2026-07-30T23:09:57.717' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (66, 1, N'Inicio de sesion', CAST(N'2026-07-30T23:11:03.353' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (67, 1, N'GenerarFactura', CAST(N'2026-07-30T23:12:16.490' AS DateTime), N'Factura #5 generada para Reserva #4, Habitacion #5 enviada a Limpieza.')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (68, 1, N'GenerarFactura', CAST(N'2026-07-30T23:13:31.300' AS DateTime), N'Factura #6 generada para Reserva #5, Habitacion #2 enviada a Limpieza.')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (69, 1, N'GenerarFactura', CAST(N'2026-07-30T23:15:42.873' AS DateTime), N'Factura #8 generada para Reserva #6, Habitacion #5 enviada a Limpieza.')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (70, 1, N'Inicio de sesion', CAST(N'2026-07-30T23:51:09.890' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (71, 1, N'Inicio de sesion', CAST(N'2026-07-31T15:35:41.577' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (72, 1, N'Inicio de sesion', CAST(N'2026-07-31T15:44:09.450' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (73, 1, N'Inicio de sesion', CAST(N'2026-07-31T17:49:50.647' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (74, 1, N'Inicio de sesion', CAST(N'2026-07-31T17:53:37.643' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (75, 1, N'Inicio de sesion', CAST(N'2026-07-31T17:54:14.250' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (76, 1, N'Inicio de sesion', CAST(N'2026-07-31T23:37:58.697' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (77, 1, N'Inicio de sesion', CAST(N'2026-07-31T23:39:13.900' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (78, 2, N'Inicio de sesion', CAST(N'2026-07-31T23:40:48.843' AS DateTime), N'Recepcionista inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (79, 1, N'Inicio de sesion', CAST(N'2026-07-31T23:44:49.410' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (80, 1, N'Inicio de sesion', CAST(N'2026-07-31T23:45:27.510' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (81, 1, N'Inicio de sesion', CAST(N'2026-07-31T23:51:09.333' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (82, 2, N'Inicio de sesion', CAST(N'2026-07-31T23:51:37.727' AS DateTime), N'Recepcionista inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (83, 1, N'Inicio de sesion', CAST(N'2026-08-01T00:00:01.560' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (84, 1, N'Inicio de sesion', CAST(N'2026-08-01T00:07:25.730' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (85, 1, N'Inicio de sesion', CAST(N'2026-08-01T00:09:25.663' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (86, 1, N'Inicio de sesion', CAST(N'2026-08-01T00:10:04.910' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (87, 1, N'Inicio de sesion', CAST(N'2026-08-01T00:35:24.160' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (88, 1, N'Inicio de sesion', CAST(N'2026-08-01T01:56:48.380' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (89, 1, N'Inicio de sesion', CAST(N'2026-08-01T02:21:00.517' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (90, 1, N'Inicio de sesion', CAST(N'2026-08-01T07:48:49.750' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (91, 2, N'Inicio de sesion', CAST(N'2026-08-01T07:49:46.740' AS DateTime), N'Recepcionista inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (92, 1, N'Inicio de sesion', CAST(N'2026-08-01T12:39:27.593' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (93, 1, N'Inicio de sesion', CAST(N'2026-08-01T12:45:34.733' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (94, 1, N'Inicio de sesion', CAST(N'2026-08-01T13:01:50.243' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (95, 1, N'Inicio de sesion', CAST(N'2026-08-01T13:05:49.070' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (96, 1, N'Inicio de sesion', CAST(N'2026-08-07T22:40:43.140' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (97, 1, N'Inicio de sesion', CAST(N'2026-08-07T22:41:31.700' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (98, 1, N'Inicio de sesion', CAST(N'2026-08-07T22:42:03.940' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (99, 1, N'Inicio de sesion', CAST(N'2026-08-07T22:43:04.210' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (100, 1, N'Inicio de sesion', CAST(N'2026-08-07T22:44:57.300' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (101, 1, N'Inicio de sesion', CAST(N'2026-08-07T22:58:49.650' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (102, 1, N'Inicio de sesion', CAST(N'2026-08-08T00:12:21.780' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (103, 1, N'Inicio de sesion', CAST(N'2026-08-08T00:16:45.443' AS DateTime), N'Admin inicio sesion')
GO
INSERT [Auditoria].[Bitacora] ([IdBitacora], [IdUsuario], [Accion], [Fecha], [Descripcion]) VALUES (104, 1, N'Inicio de sesion', CAST(N'2026-08-08T00:19:48.100' AS DateTime), N'Admin inicio sesion')
GO
SET IDENTITY_INSERT [Auditoria].[Bitacora] OFF
GO
SET IDENTITY_INSERT [Estadias].[Estadia] ON 
GO
INSERT [Estadias].[Estadia] ([IdEstadia], [IdReserva], [IdHabitacion], [FechaInicio], [FechaFin], [Motivo]) VALUES (1, 2, 2, CAST(N'2026-07-30T22:25:39.623' AS DateTime), CAST(N'2026-07-30T22:25:43.663' AS DateTime), N'Check-in inicial (prueba manual)')
GO
INSERT [Estadias].[Estadia] ([IdEstadia], [IdReserva], [IdHabitacion], [FechaInicio], [FechaFin], [Motivo]) VALUES (2, 3, 3, CAST(N'2026-07-30T22:29:21.993' AS DateTime), CAST(N'2026-07-30T22:29:30.897' AS DateTime), N'Check-in inicial (prueba manual)')
GO
INSERT [Estadias].[Estadia] ([IdEstadia], [IdReserva], [IdHabitacion], [FechaInicio], [FechaFin], [Motivo]) VALUES (3, 4, 5, CAST(N'2026-07-30T23:11:16.157' AS DateTime), CAST(N'2026-07-30T23:12:16.490' AS DateTime), N'Check-in inicial')
GO
INSERT [Estadias].[Estadia] ([IdEstadia], [IdReserva], [IdHabitacion], [FechaInicio], [FechaFin], [Motivo]) VALUES (4, 5, 2, CAST(N'2026-07-30T23:13:17.827' AS DateTime), CAST(N'2026-07-30T23:13:31.297' AS DateTime), N'Check-in inicial')
GO
INSERT [Estadias].[Estadia] ([IdEstadia], [IdReserva], [IdHabitacion], [FechaInicio], [FechaFin], [Motivo]) VALUES (5, 6, 5, CAST(N'2026-07-30T23:14:26.667' AS DateTime), CAST(N'2026-07-30T23:14:53.617' AS DateTime), N'Check-in inicial')
GO
INSERT [Estadias].[Estadia] ([IdEstadia], [IdReserva], [IdHabitacion], [FechaInicio], [FechaFin], [Motivo]) VALUES (6, 6, 1, CAST(N'2026-07-30T23:14:53.620' AS DateTime), CAST(N'2026-07-30T23:15:42.870' AS DateTime), N'AC Dañado')
GO
SET IDENTITY_INSERT [Estadias].[Estadia] OFF
GO
SET IDENTITY_INSERT [Estadias].[EstadiaServicio] ON 
GO
INSERT [Estadias].[EstadiaServicio] ([IdEstadiaServicio], [IdEstadia], [IdServicio], [Cantidad], [PrecioUnitario], [FechaConsumo]) VALUES (1, 2, 1, 2, CAST(350.00 AS Decimal(10, 2)), CAST(N'2026-07-30T22:29:26.817' AS DateTime))
GO
INSERT [Estadias].[EstadiaServicio] ([IdEstadiaServicio], [IdEstadia], [IdServicio], [Cantidad], [PrecioUnitario], [FechaConsumo]) VALUES (2, 2, 3, 1, CAST(500.00 AS Decimal(10, 2)), CAST(N'2026-07-30T22:29:26.817' AS DateTime))
GO
INSERT [Estadias].[EstadiaServicio] ([IdEstadiaServicio], [IdEstadia], [IdServicio], [Cantidad], [PrecioUnitario], [FechaConsumo]) VALUES (3, 3, 2, 2, CAST(250.00 AS Decimal(10, 2)), CAST(N'2026-07-30T23:11:39.793' AS DateTime))
GO
INSERT [Estadias].[EstadiaServicio] ([IdEstadiaServicio], [IdEstadia], [IdServicio], [Cantidad], [PrecioUnitario], [FechaConsumo]) VALUES (4, 3, 3, 1, CAST(500.00 AS Decimal(10, 2)), CAST(N'2026-07-30T23:12:02.987' AS DateTime))
GO
INSERT [Estadias].[EstadiaServicio] ([IdEstadiaServicio], [IdEstadia], [IdServicio], [Cantidad], [PrecioUnitario], [FechaConsumo]) VALUES (5, 4, 1, 2, CAST(350.00 AS Decimal(10, 2)), CAST(N'2026-07-30T23:13:28.087' AS DateTime))
GO
INSERT [Estadias].[EstadiaServicio] ([IdEstadiaServicio], [IdEstadia], [IdServicio], [Cantidad], [PrecioUnitario], [FechaConsumo]) VALUES (6, 6, 3, 1, CAST(500.00 AS Decimal(10, 2)), CAST(N'2026-07-30T23:15:20.543' AS DateTime))
GO
SET IDENTITY_INSERT [Estadias].[EstadiaServicio] OFF
GO
SET IDENTITY_INSERT [Estadias].[Servicio] ON 
GO
INSERT [Estadias].[Servicio] ([IdServicio], [Nombre], [Precio], [Activo]) VALUES (1, N'Room Service', CAST(350.00 AS Decimal(10, 2)), 1)
GO
INSERT [Estadias].[Servicio] ([IdServicio], [Nombre], [Precio], [Activo]) VALUES (2, N'Lavanderia', CAST(250.00 AS Decimal(10, 2)), 1)
GO
INSERT [Estadias].[Servicio] ([IdServicio], [Nombre], [Precio], [Activo]) VALUES (3, N'Desayuno buffet', CAST(500.00 AS Decimal(10, 2)), 1)
GO
INSERT [Estadias].[Servicio] ([IdServicio], [Nombre], [Precio], [Activo]) VALUES (4, N'Uso de spa', CAST(800.00 AS Decimal(10, 2)), 1)
GO
INSERT [Estadias].[Servicio] ([IdServicio], [Nombre], [Precio], [Activo]) VALUES (5, N'Minibar', CAST(150.00 AS Decimal(10, 2)), 1)
GO
SET IDENTITY_INSERT [Estadias].[Servicio] OFF
GO
SET IDENTITY_INSERT [Facturacion].[Factura] ON 
GO
INSERT [Facturacion].[Factura] ([IdFactura], [IdReserva], [FechaEmision], [Subtotal], [FormaPago], [Estado]) VALUES (2, 1, CAST(N'2026-07-26T22:15:58.190' AS DateTime), CAST(2500.00 AS Decimal(10, 2)), N'Efectivo', N'Emitida')
GO
INSERT [Facturacion].[Factura] ([IdFactura], [IdReserva], [FechaEmision], [Subtotal], [FormaPago], [Estado]) VALUES (3, 2, CAST(N'2026-07-30T22:25:43.660' AS DateTime), CAST(1620.00 AS Decimal(10, 2)), N'Efectivo', N'Emitida')
GO
INSERT [Facturacion].[Factura] ([IdFactura], [IdReserva], [FechaEmision], [Subtotal], [FormaPago], [Estado]) VALUES (4, 3, CAST(N'2026-07-30T22:29:30.897' AS DateTime), CAST(10800.00 AS Decimal(10, 2)), N'Transferencia', N'Emitida')
GO
INSERT [Facturacion].[Factura] ([IdFactura], [IdReserva], [FechaEmision], [Subtotal], [FormaPago], [Estado]) VALUES (5, 4, CAST(N'2026-07-30T23:12:16.490' AS DateTime), CAST(15400.00 AS Decimal(10, 2)), N'Tarjeta', N'Emitida')
GO
INSERT [Facturacion].[Factura] ([IdFactura], [IdReserva], [FechaEmision], [Subtotal], [FormaPago], [Estado]) VALUES (6, 5, CAST(N'2026-07-30T23:13:31.297' AS DateTime), CAST(2900.00 AS Decimal(10, 2)), N'Efectivo', N'Emitida')
GO
INSERT [Facturacion].[Factura] ([IdFactura], [IdReserva], [FechaEmision], [Subtotal], [FormaPago], [Estado]) VALUES (8, 6, CAST(N'2026-07-30T23:15:42.870' AS DateTime), CAST(5000.00 AS Decimal(10, 2)), N'Efectivo', N'Emitida')
GO
SET IDENTITY_INSERT [Facturacion].[Factura] OFF
GO
SET IDENTITY_INSERT [Habitaciones].[Habitacion] ON 
GO
INSERT [Habitaciones].[Habitacion] ([IdHabitacion], [Numero], [IdTipo], [Piso], [Capacidad], [TarifaBase], [Estado]) VALUES (1, 101, 1, 1, 1, CAST(1500.00 AS Decimal(10, 2)), N'Ocupada')
GO
INSERT [Habitaciones].[Habitacion] ([IdHabitacion], [Numero], [IdTipo], [Piso], [Capacidad], [TarifaBase], [Estado]) VALUES (2, 102, 2, 1, 2, CAST(2200.00 AS Decimal(10, 2)), N'Disponible')
GO
INSERT [Habitaciones].[Habitacion] ([IdHabitacion], [Numero], [IdTipo], [Piso], [Capacidad], [TarifaBase], [Estado]) VALUES (3, 201, 3, 2, 4, CAST(4500.00 AS Decimal(10, 2)), N'Limpieza')
GO
INSERT [Habitaciones].[Habitacion] ([IdHabitacion], [Numero], [IdTipo], [Piso], [Capacidad], [TarifaBase], [Estado]) VALUES (4, 202, 2, 2, 2, CAST(2200.00 AS Decimal(10, 2)), N'Ocupada')
GO
INSERT [Habitaciones].[Habitacion] ([IdHabitacion], [Numero], [IdTipo], [Piso], [Capacidad], [TarifaBase], [Estado]) VALUES (5, 103, 3, 5, 1, CAST(4500.00 AS Decimal(10, 2)), N'Limpieza')
GO
INSERT [Habitaciones].[Habitacion] ([IdHabitacion], [Numero], [IdTipo], [Piso], [Capacidad], [TarifaBase], [Estado]) VALUES (6, 203, 3, 2, 3, CAST(4500.00 AS Decimal(10, 2)), N'Disponible')
GO
INSERT [Habitaciones].[Habitacion] ([IdHabitacion], [Numero], [IdTipo], [Piso], [Capacidad], [TarifaBase], [Estado]) VALUES (7, 1, 2, 1, 1, CAST(77778.00 AS Decimal(10, 2)), N'Disponible')
GO
SET IDENTITY_INSERT [Habitaciones].[Habitacion] OFF
GO
SET IDENTITY_INSERT [Habitaciones].[TipoHabitacion] ON 
GO
INSERT [Habitaciones].[TipoHabitacion] ([IdTipo], [Tipo]) VALUES (2, N'Doble')
GO
INSERT [Habitaciones].[TipoHabitacion] ([IdTipo], [Tipo]) VALUES (4, N'Familiar')
GO
INSERT [Habitaciones].[TipoHabitacion] ([IdTipo], [Tipo]) VALUES (1, N'Individual')
GO
INSERT [Habitaciones].[TipoHabitacion] ([IdTipo], [Tipo]) VALUES (3, N'Suite')
GO
SET IDENTITY_INSERT [Habitaciones].[TipoHabitacion] OFF
GO
SET IDENTITY_INSERT [Huespedes].[Huesped] ON 
GO
INSERT [Huespedes].[Huesped] ([IdHuesped], [Nombre], [Apellido], [TipoDocumento], [NumeroDocumento], [Telefono], [Email], [FechaRegistro], [IdNacionalidad], [NacionalidadEspecifica]) VALUES (1, N'Juan', N'Perez', N'Cedula', N'001-1234567-6', N'809-555-0101', N'juan.perez@correo.com', CAST(N'2026-07-23T21:50:09.680' AS DateTime), 22, N'Dominicana')
GO
INSERT [Huespedes].[Huesped] ([IdHuesped], [Nombre], [Apellido], [TipoDocumento], [NumeroDocumento], [Telefono], [Email], [FechaRegistro], [IdNacionalidad], [NacionalidadEspecifica]) VALUES (2, N'Maria', N'Gomez', N'Pasaporte', N'A1234567', N'809-555-0102', N'maria.gomez@correo.com', CAST(N'2026-07-23T21:50:09.680' AS DateTime), 22, N'Estados Unidos')
GO
INSERT [Huespedes].[Huesped] ([IdHuesped], [Nombre], [Apellido], [TipoDocumento], [NumeroDocumento], [Telefono], [Email], [FechaRegistro], [IdNacionalidad], [NacionalidadEspecifica]) VALUES (3, N'Carlos', N'Diaz', N'Cedula', N'402-9876543-2', NULL, NULL, CAST(N'2026-07-23T21:50:09.680' AS DateTime), 22, N'Dominicana')
GO
INSERT [Huespedes].[Huesped] ([IdHuesped], [Nombre], [Apellido], [TipoDocumento], [NumeroDocumento], [Telefono], [Email], [FechaRegistro], [IdNacionalidad], [NacionalidadEspecifica]) VALUES (5, N'Jeffrey', N'Epstein', N'Pasaporte', N'A123244', NULL, NULL, CAST(N'2026-07-23T22:55:19.443' AS DateTime), 22, N'Estados Unidos')
GO
INSERT [Huespedes].[Huesped] ([IdHuesped], [Nombre], [Apellido], [TipoDocumento], [NumeroDocumento], [Telefono], [Email], [FechaRegistro], [IdNacionalidad], [NacionalidadEspecifica]) VALUES (6, N'Pedro', N'Perez', N'Cedula', N'001-1234567-8', N'809-555-0101', N'juan.perez@correo.com', CAST(N'2026-07-23T22:55:43.947' AS DateTime), 22, N'Dominicana')
GO
INSERT [Huespedes].[Huesped] ([IdHuesped], [Nombre], [Apellido], [TipoDocumento], [NumeroDocumento], [Telefono], [Email], [FechaRegistro], [IdNacionalidad], [NacionalidadEspecifica]) VALUES (7, N'Robmel', N'Lozano', N'Cedula', N'402 - 1035106 - 6', N'8494013102', N'RobmelLozano@gmail.com', CAST(N'2026-07-29T23:40:42.820' AS DateTime), 21, NULL)
GO
SET IDENTITY_INSERT [Huespedes].[Huesped] OFF
GO
SET IDENTITY_INSERT [Huespedes].[Nacionalidad] ON 
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (16, N'Alemania')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (3, N'Argentina')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (8, N'Brasil')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (2, N'Canada')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (15, N'Chile')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (4, N'Colombia')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (10, N'Costa Rica')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (9, N'Cuba')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (18, N'Ecuador')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (13, N'Espana')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (1, N'Estados Unidos')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (17, N'Francia')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (11, N'Italia')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (6, N'Mexico')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (22, N'Otros')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (20, N'Panama')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (7, N'Peru')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (5, N'Puerto Rico')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (12, N'Reino Unido')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (21, N'Republica Dominicana')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (14, N'Suecia')
GO
INSERT [Huespedes].[Nacionalidad] ([IdNacionalidad], [Nombre]) VALUES (19, N'Venezuela')
GO
SET IDENTITY_INSERT [Huespedes].[Nacionalidad] OFF
GO
SET IDENTITY_INSERT [Reservas].[Reserva] ON 
GO
INSERT [Reservas].[Reserva] ([IdReserva], [IdHabitacion], [IdHuesped], [FechaCheckIn], [FechaCheckOut], [Estado], [Temporada], [TarifaAplicada], [MontoTotal], [FechaCreacion]) VALUES (1, 1, 1, CAST(N'2026-07-25' AS Date), CAST(N'2026-07-28' AS Date), N'Completada', N'Alta', CAST(2500.00 AS Decimal(10, 2)), CAST(7500.00 AS Decimal(10, 2)), CAST(N'2026-07-23T23:13:01.220' AS DateTime))
GO
INSERT [Reservas].[Reserva] ([IdReserva], [IdHabitacion], [IdHuesped], [FechaCheckIn], [FechaCheckOut], [Estado], [Temporada], [TarifaAplicada], [MontoTotal], [FechaCreacion]) VALUES (2, 2, 2, CAST(N'2026-07-24' AS Date), CAST(N'2026-07-25' AS Date), N'Completada', N'Media', CAST(1800.00 AS Decimal(10, 2)), CAST(1620.00 AS Decimal(10, 2)), CAST(N'2026-07-23T23:13:01.220' AS DateTime))
GO
INSERT [Reservas].[Reserva] ([IdReserva], [IdHabitacion], [IdHuesped], [FechaCheckIn], [FechaCheckOut], [Estado], [Temporada], [TarifaAplicada], [MontoTotal], [FechaCreacion]) VALUES (3, 3, 3, CAST(N'2026-08-01' AS Date), CAST(N'2026-08-05' AS Date), N'Completada', N'Baja', CAST(3000.00 AS Decimal(10, 2)), CAST(9600.00 AS Decimal(10, 2)), CAST(N'2026-07-23T23:13:01.220' AS DateTime))
GO
INSERT [Reservas].[Reserva] ([IdReserva], [IdHabitacion], [IdHuesped], [FechaCheckIn], [FechaCheckOut], [Estado], [Temporada], [TarifaAplicada], [MontoTotal], [FechaCreacion]) VALUES (4, 5, 5, CAST(N'2026-07-27' AS Date), CAST(N'2026-07-31' AS Date), N'Completada', N'Baja', CAST(4500.00 AS Decimal(10, 2)), CAST(14400.00 AS Decimal(10, 2)), CAST(N'2026-07-24T23:52:26.620' AS DateTime))
GO
INSERT [Reservas].[Reserva] ([IdReserva], [IdHabitacion], [IdHuesped], [FechaCheckIn], [FechaCheckOut], [Estado], [Temporada], [TarifaAplicada], [MontoTotal], [FechaCreacion]) VALUES (5, 2, 2, CAST(N'2026-07-30' AS Date), CAST(N'2026-07-31' AS Date), N'Completada', N'Alta', CAST(2200.00 AS Decimal(10, 2)), CAST(2200.00 AS Decimal(10, 2)), CAST(N'2026-07-30T23:12:45.220' AS DateTime))
GO
INSERT [Reservas].[Reserva] ([IdReserva], [IdHabitacion], [IdHuesped], [FechaCheckIn], [FechaCheckOut], [Estado], [Temporada], [TarifaAplicada], [MontoTotal], [FechaCreacion]) VALUES (6, 5, 7, CAST(N'2026-07-30' AS Date), CAST(N'2026-07-31' AS Date), N'Completada', N'Alta', CAST(4500.00 AS Decimal(10, 2)), CAST(4500.00 AS Decimal(10, 2)), CAST(N'2026-07-30T23:13:54.600' AS DateTime))
GO
SET IDENTITY_INSERT [Reservas].[Reserva] OFF
GO
SET IDENTITY_INSERT [Usuarios].[InfoUsuario] ON 
GO
INSERT [Usuarios].[InfoUsuario] ([IdUsuario], [Nombre], [Contrasena], [IdTipo], [Activo], [FechaCreacion]) VALUES (1, N'Admin', N'60fe74406e7f353ed979f350f2fbb6a2e8690a5fa7d1b0c32983d1d8b3f95f67', 1, 1, CAST(N'2026-07-20T22:35:37.333' AS DateTime))
GO
INSERT [Usuarios].[InfoUsuario] ([IdUsuario], [Nombre], [Contrasena], [IdTipo], [Activo], [FechaCreacion]) VALUES (2, N'Recepcionista', N'5d37ed314cf2b5c8462b52b12cd512e2ac4a180e75598da4f12bfb0dea6d0a67', 2, 1, CAST(N'2026-07-31T23:38:29.083' AS DateTime))
GO
SET IDENTITY_INSERT [Usuarios].[InfoUsuario] OFF
GO
SET IDENTITY_INSERT [Usuarios].[TipoUsuario] ON 
GO
INSERT [Usuarios].[TipoUsuario] ([IdTipo], [Tipo]) VALUES (1, N'Administrador')
GO
INSERT [Usuarios].[TipoUsuario] ([IdTipo], [Tipo]) VALUES (2, N'Recepcionista')
GO
SET IDENTITY_INSERT [Usuarios].[TipoUsuario] OFF
GO
/****** Object:  Index [UQ_Factura_Reserva]    Script Date: 08/08/2026 12:27:07 a. m. ******/
ALTER TABLE [Facturacion].[Factura] ADD  CONSTRAINT [UQ_Factura_Reserva] UNIQUE NONCLUSTERED 
(
	[IdReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ_Habitacion_Numero]    Script Date: 08/08/2026 12:27:07 a. m. ******/
ALTER TABLE [Habitaciones].[Habitacion] ADD  CONSTRAINT [UQ_Habitacion_Numero] UNIQUE NONCLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_TipoHabitacion_Tipo]    Script Date: 08/08/2026 12:27:07 a. m. ******/
ALTER TABLE [Habitaciones].[TipoHabitacion] ADD  CONSTRAINT [UQ_TipoHabitacion_Tipo] UNIQUE NONCLUSTERED 
(
	[Tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_Huesped_Documento]    Script Date: 08/08/2026 12:27:07 a. m. ******/
ALTER TABLE [Huespedes].[Huesped] ADD  CONSTRAINT [UQ_Huesped_Documento] UNIQUE NONCLUSTERED 
(
	[TipoDocumento] ASC,
	[NumeroDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Nacional__75E3EFCFAE99F057]    Script Date: 08/08/2026 12:27:07 a. m. ******/
ALTER TABLE [Huespedes].[Nacionalidad] ADD UNIQUE NONCLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_InfoUsuario_Nombre]    Script Date: 08/08/2026 12:27:07 a. m. ******/
ALTER TABLE [Usuarios].[InfoUsuario] ADD  CONSTRAINT [UQ_InfoUsuario_Nombre] UNIQUE NONCLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_TipoUsuario_Tipo]    Script Date: 08/08/2026 12:27:07 a. m. ******/
ALTER TABLE [Usuarios].[TipoUsuario] ADD  CONSTRAINT [UQ_TipoUsuario_Tipo] UNIQUE NONCLUSTERED 
(
	[Tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [Auditoria].[Bitacora] ADD  CONSTRAINT [DF_Bitacora_Fecha]  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [Estadias].[Estadia] ADD  CONSTRAINT [DF_Estadia_FechaInicio]  DEFAULT (getdate()) FOR [FechaInicio]
GO
ALTER TABLE [Estadias].[EstadiaServicio] ADD  CONSTRAINT [DF_EstadiaServicio_Cantidad]  DEFAULT ((1)) FOR [Cantidad]
GO
ALTER TABLE [Estadias].[EstadiaServicio] ADD  CONSTRAINT [DF_EstadiaServicio_Fecha]  DEFAULT (getdate()) FOR [FechaConsumo]
GO
ALTER TABLE [Estadias].[Servicio] ADD  CONSTRAINT [DF_Servicio_Activo]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [Facturacion].[Factura] ADD  CONSTRAINT [DF_Factura_FechaEmision]  DEFAULT (getdate()) FOR [FechaEmision]
GO
ALTER TABLE [Facturacion].[Factura] ADD  CONSTRAINT [DF_Factura_Estado]  DEFAULT ('Emitida') FOR [Estado]
GO
ALTER TABLE [Habitaciones].[Habitacion] ADD  CONSTRAINT [DF_Habitacion_Estado]  DEFAULT ('Disponible') FOR [Estado]
GO
ALTER TABLE [Huespedes].[Huesped] ADD  CONSTRAINT [DF_Huesped_FechaRegistro]  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [Reservas].[Reserva] ADD  CONSTRAINT [DF_Reserva_Estado]  DEFAULT ('Pendiente') FOR [Estado]
GO
ALTER TABLE [Reservas].[Reserva] ADD  CONSTRAINT [DF_Reserva_FechaCreacion]  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [Usuarios].[InfoUsuario] ADD  CONSTRAINT [DF_InfoUsuario_Activo]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [Usuarios].[InfoUsuario] ADD  CONSTRAINT [DF_InfoUsuario_FechaCreacion]  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [Auditoria].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_InfoUsuario] FOREIGN KEY([IdUsuario])
REFERENCES [Usuarios].[InfoUsuario] ([IdUsuario])
GO
ALTER TABLE [Auditoria].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_InfoUsuario]
GO
ALTER TABLE [Estadias].[Estadia]  WITH CHECK ADD  CONSTRAINT [FK_Estadia_Habitacion] FOREIGN KEY([IdHabitacion])
REFERENCES [Habitaciones].[Habitacion] ([IdHabitacion])
GO
ALTER TABLE [Estadias].[Estadia] CHECK CONSTRAINT [FK_Estadia_Habitacion]
GO
ALTER TABLE [Estadias].[Estadia]  WITH CHECK ADD  CONSTRAINT [FK_Estadia_Reserva] FOREIGN KEY([IdReserva])
REFERENCES [Reservas].[Reserva] ([IdReserva])
GO
ALTER TABLE [Estadias].[Estadia] CHECK CONSTRAINT [FK_Estadia_Reserva]
GO
ALTER TABLE [Estadias].[EstadiaServicio]  WITH CHECK ADD  CONSTRAINT [FK_EstadiaServicio_Estadia] FOREIGN KEY([IdEstadia])
REFERENCES [Estadias].[Estadia] ([IdEstadia])
GO
ALTER TABLE [Estadias].[EstadiaServicio] CHECK CONSTRAINT [FK_EstadiaServicio_Estadia]
GO
ALTER TABLE [Estadias].[EstadiaServicio]  WITH CHECK ADD  CONSTRAINT [FK_EstadiaServicio_Servicio] FOREIGN KEY([IdServicio])
REFERENCES [Estadias].[Servicio] ([IdServicio])
GO
ALTER TABLE [Estadias].[EstadiaServicio] CHECK CONSTRAINT [FK_EstadiaServicio_Servicio]
GO
ALTER TABLE [Facturacion].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Reserva] FOREIGN KEY([IdReserva])
REFERENCES [Reservas].[Reserva] ([IdReserva])
GO
ALTER TABLE [Facturacion].[Factura] CHECK CONSTRAINT [FK_Factura_Reserva]
GO
ALTER TABLE [Habitaciones].[Habitacion]  WITH CHECK ADD  CONSTRAINT [FK_Habitacion_TipoHabitacion] FOREIGN KEY([IdTipo])
REFERENCES [Habitaciones].[TipoHabitacion] ([IdTipo])
GO
ALTER TABLE [Habitaciones].[Habitacion] CHECK CONSTRAINT [FK_Habitacion_TipoHabitacion]
GO
ALTER TABLE [Huespedes].[Huesped]  WITH CHECK ADD  CONSTRAINT [FK_Huesped_Nacionalidad] FOREIGN KEY([IdNacionalidad])
REFERENCES [Huespedes].[Nacionalidad] ([IdNacionalidad])
GO
ALTER TABLE [Huespedes].[Huesped] CHECK CONSTRAINT [FK_Huesped_Nacionalidad]
GO
ALTER TABLE [Reservas].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Habitacion] FOREIGN KEY([IdHabitacion])
REFERENCES [Habitaciones].[Habitacion] ([IdHabitacion])
GO
ALTER TABLE [Reservas].[Reserva] CHECK CONSTRAINT [FK_Reserva_Habitacion]
GO
ALTER TABLE [Reservas].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Huesped] FOREIGN KEY([IdHuesped])
REFERENCES [Huespedes].[Huesped] ([IdHuesped])
GO
ALTER TABLE [Reservas].[Reserva] CHECK CONSTRAINT [FK_Reserva_Huesped]
GO
ALTER TABLE [Usuarios].[InfoUsuario]  WITH CHECK ADD  CONSTRAINT [FK_InfoUsuario_TipoUsuario] FOREIGN KEY([IdTipo])
REFERENCES [Usuarios].[TipoUsuario] ([IdTipo])
GO
ALTER TABLE [Usuarios].[InfoUsuario] CHECK CONSTRAINT [FK_InfoUsuario_TipoUsuario]
GO
ALTER TABLE [Estadias].[EstadiaServicio]  WITH CHECK ADD  CONSTRAINT [CK_EstadiaServicio_Cantidad] CHECK  (([Cantidad]>(0)))
GO
ALTER TABLE [Estadias].[EstadiaServicio] CHECK CONSTRAINT [CK_EstadiaServicio_Cantidad]
GO
ALTER TABLE [Facturacion].[Factura]  WITH CHECK ADD  CONSTRAINT [CK_Factura_Estado] CHECK  (([Estado]='Anulada' OR [Estado]='Emitida'))
GO
ALTER TABLE [Facturacion].[Factura] CHECK CONSTRAINT [CK_Factura_Estado]
GO
ALTER TABLE [Facturacion].[Factura]  WITH CHECK ADD  CONSTRAINT [CK_Factura_FormaPago] CHECK  (([FormaPago]='Transferencia' OR [FormaPago]='Tarjeta' OR [FormaPago]='Efectivo'))
GO
ALTER TABLE [Facturacion].[Factura] CHECK CONSTRAINT [CK_Factura_FormaPago]
GO
ALTER TABLE [Facturacion].[Factura]  WITH CHECK ADD  CONSTRAINT [CK_Factura_SubtotalPositivo] CHECK  (([Subtotal]>=(0)))
GO
ALTER TABLE [Facturacion].[Factura] CHECK CONSTRAINT [CK_Factura_SubtotalPositivo]
GO
ALTER TABLE [Habitaciones].[Habitacion]  WITH CHECK ADD  CONSTRAINT [CK_Habitacion_Capacidad] CHECK  (([Capacidad]>(0)))
GO
ALTER TABLE [Habitaciones].[Habitacion] CHECK CONSTRAINT [CK_Habitacion_Capacidad]
GO
ALTER TABLE [Habitaciones].[Habitacion]  WITH CHECK ADD  CONSTRAINT [CK_Habitacion_Estado] CHECK  (([Estado]='Limpieza' OR [Estado]='Reservada' OR [Estado]='Ocupada' OR [Estado]='Disponible'))
GO
ALTER TABLE [Habitaciones].[Habitacion] CHECK CONSTRAINT [CK_Habitacion_Estado]
GO
ALTER TABLE [Habitaciones].[Habitacion]  WITH CHECK ADD  CONSTRAINT [CK_Habitacion_TarifaBase] CHECK  (([TarifaBase]>(0)))
GO
ALTER TABLE [Habitaciones].[Habitacion] CHECK CONSTRAINT [CK_Habitacion_TarifaBase]
GO
ALTER TABLE [Huespedes].[Huesped]  WITH CHECK ADD  CONSTRAINT [CK_Huesped_TipoDocumento] CHECK  (([TipoDocumento]='Otro' OR [TipoDocumento]='LicenciaConducir' OR [TipoDocumento]='Pasaporte' OR [TipoDocumento]='Cedula'))
GO
ALTER TABLE [Huespedes].[Huesped] CHECK CONSTRAINT [CK_Huesped_TipoDocumento]
GO
ALTER TABLE [Reservas].[Reserva]  WITH CHECK ADD  CONSTRAINT [CK_Reserva_Estado] CHECK  (([Estado]='Completada' OR [Estado]='Cancelada' OR [Estado]='Confirmada' OR [Estado]='Pendiente'))
GO
ALTER TABLE [Reservas].[Reserva] CHECK CONSTRAINT [CK_Reserva_Estado]
GO
ALTER TABLE [Reservas].[Reserva]  WITH CHECK ADD  CONSTRAINT [CK_Reserva_Fechas] CHECK  (([FechaCheckOut]>[FechaCheckIn]))
GO
ALTER TABLE [Reservas].[Reserva] CHECK CONSTRAINT [CK_Reserva_Fechas]
GO
ALTER TABLE [Reservas].[Reserva]  WITH CHECK ADD  CONSTRAINT [CK_Reserva_Temporada] CHECK  (([Temporada]='Baja' OR [Temporada]='Media' OR [Temporada]='Alta'))
GO
ALTER TABLE [Reservas].[Reserva] CHECK CONSTRAINT [CK_Reserva_Temporada]
GO
/****** Object:  StoredProcedure [Facturacion].[sp_GenerarFactura]    Script Date: 08/08/2026 12:27:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Facturacion].[sp_GenerarFactura]
    @IdReserva INT,
    @IdHabitacion INT,
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

        -- Subtotal = costo de la reserva + consumo de servicios de TODAS sus estadias
        DECLARE @Subtotal DECIMAL(10,2);
        SELECT @Subtotal = r.MontoTotal + ISNULL(SUM(vc.TotalServicios), 0)
        FROM Reservas.Reserva r
        LEFT JOIN Estadias.Estadia e ON e.IdReserva = r.IdReserva
        LEFT JOIN Estadias.vw_ConsumoPorEstadia vc ON vc.IdEstadia = e.IdEstadia
        WHERE r.IdReserva = @IdReserva
        GROUP BY r.MontoTotal;

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

        -- Cierra la estadia activa (FechaFin NULL) de esta reserva, mismo criterio
        -- de closing-the-loop en la misma transaccion que Habitacion/Reserva.
        UPDATE Estadias.Estadia
        SET FechaFin = GETDATE()
        WHERE IdReserva = @IdReserva
          AND FechaFin IS NULL;
        IF @@ROWCOUNT = 0
            THROW 51005, 'No se encontró una estadía activa para esta reserva.', 1;

        COMMIT TRANSACTION;
        SELECT SCOPE_IDENTITY() AS IdFactura;
    END TRY
    BEGIN CATCH
        IF XACT_STATE() <> 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO
