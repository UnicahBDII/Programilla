USE [master]
GO
/****** Object:  Database [CompuCenter]    Script Date: 12/12/2020 12:34:06 AM ******/
CREATE DATABASE [CompuCenter]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CompuCenter', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CompuCenter.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CompuCenter_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CompuCenter_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CompuCenter] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CompuCenter].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CompuCenter] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CompuCenter] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CompuCenter] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CompuCenter] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CompuCenter] SET ARITHABORT OFF 
GO
ALTER DATABASE [CompuCenter] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CompuCenter] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CompuCenter] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CompuCenter] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CompuCenter] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CompuCenter] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CompuCenter] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CompuCenter] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CompuCenter] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CompuCenter] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CompuCenter] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CompuCenter] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CompuCenter] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CompuCenter] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CompuCenter] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CompuCenter] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CompuCenter] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CompuCenter] SET RECOVERY FULL 
GO
ALTER DATABASE [CompuCenter] SET  MULTI_USER 
GO
ALTER DATABASE [CompuCenter] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CompuCenter] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CompuCenter] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CompuCenter] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CompuCenter] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CompuCenter] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CompuCenter] SET QUERY_STORE = OFF
GO
USE [CompuCenter]
GO
/****** Object:  Schema [Center]    Script Date: 12/12/2020 12:34:06 AM ******/
CREATE SCHEMA [Center]
GO
/****** Object:  Table [Center].[empleados]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Center].[empleados](
	[IdCodigo] [int] NOT NULL,
	[identidad] [varchar](15) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[direccion] [varchar](60) NOT NULL,
	[edad] [int] NOT NULL,
	[sexo] [varchar](10) NULL,
	[Id_Puesto] [int] NULL,
	[Estado] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Center].[producto]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Center].[producto](
	[id] [nvarchar](50) NOT NULL,
	[codigobarra] [varchar](25) NULL,
	[tipoproducto] [int] NULL,
	[nombre] [varchar](25) NOT NULL,
	[precio] [decimal](18, 0) NOT NULL,
	[precioventa] [decimal](18, 0) NOT NULL,
	[cantidad] [int] NOT NULL,
	[caracteristica] [varchar](50) NULL,
	[estado] [varchar](25) NULL,
	[modelo] [int] NULL,
 CONSTRAINT [PK__producto__3213E83F783DE31E] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Center].[detalleventa]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Center].[detalleventa](
	[iddetalleventa] [int] NOT NULL,
	[idventa] [int] NOT NULL,
	[idProducto] [nvarchar](50) NULL,
	[cantidad] [int] NOT NULL,
	[precio] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK__detallev__4EA180983EC78B96] PRIMARY KEY CLUSTERED 
(
	[iddetalleventa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Center].[cliente]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Center].[cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[identidad] [varchar](15) NULL,
	[nombre] [varchar](25) NULL,
	[apellido] [varchar](25) NULL,
	[numero] [varchar](25) NULL,
	[direccion] [varchar](60) NULL,
	[estado] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Center].[venta]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Center].[venta](
	[id] [int] NOT NULL,
	[idcliente] [int] NOT NULL,
	[idempleado] [int] NOT NULL,
	[fecha] [date] NULL,
	[formapago] [int] NULL,
	[numerofactura] [decimal](18, 0) NOT NULL,
	[total] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vVentaspordiaEmp]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE View [dbo].[vVentaspordiaEmp] as 
select [idventa] as 'Numero de factura',[fecha] as 'fecha de venta',em.[nombre] as'Empleado que realizo la venta' ,CONCAT([Center].[cliente].[nombre],' ',[Center].[cliente].[apellido])  as 'Nombre del cliente ' ,[Center].[producto].[nombre] as 'nombre del articulo',dv.[cantidad] as 'cantidad que lleva',dv.[precio] as 'precio unidad',
(dv.[cantidad] * dv.[precio]) as 'Subtotal', [total] as 'total' from [Center].[detalleventa] as dv
inner join [Center].[venta] on [id]=[idventa]
inner join [Center].[producto]  on [Center].[producto].[id]=[idProducto]
inner join [Center].[cliente]  on [Center].[cliente].[id]=[idcliente]
inner join [Center].[empleados]  as em on  em.[IdCodigo] =[idempleado]
where DAY(Center.venta.fecha) = DAY(GETDATE())
GO
/****** Object:  View [dbo].[vVentasporMES]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[vVentasporMES] as 
select [idventa] as 'Numero de factura',[fecha] as 'fecha de venta',em.[nombre] as'Empleado que realizo la venta' ,CONCAT([Center].[cliente].[nombre],' ',[Center].[cliente].[apellido])  as 'Nombre del cliente ' ,[Center].[producto].[nombre] as 'nombre del articulo',dv.[cantidad] as 'cantidad que lleva',dv.[precio] as 'precio unidad',
(dv.[cantidad] * dv.[precio]) as 'Subtotal', [total] as 'total' from [Center].[detalleventa] as dv
inner join [Center].[venta] on [id]=[idventa]
inner join [Center].[producto]  on [Center].[producto].[id]=[idProducto]
inner join [Center].[cliente]  on [Center].[cliente].[id]=[idcliente]
inner join [Center].[empleados]  as em on  em.[IdCodigo] =[idempleado]

where MONTH(Center.venta.fecha) = MONTH(GETDATE())
GO
/****** Object:  Table [Center].[entradas]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Center].[entradas](
	[identrada] [int] IDENTITY(1,1) NOT NULL,
	[codbarra] [nvarchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[precioventa] [decimal](18, 0) NULL,
	[cantidad] [decimal](18, 0) NULL,
	[total] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vEntrada]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vEntrada] as
select identrada as 'ID Entrada', codbarra as 'Codigo de barra', nombre as 'Nombre', precioventa as 'Precio de venta', cantidad as 'Cantidad',
total as 'Total' from Center.entradas 
GO
/****** Object:  Table [Center].[salidas]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Center].[salidas](
	[idsalida] [int] IDENTITY(1,1) NOT NULL,
	[numeroventa] [int] NULL,
	[tipodeproceso] [varchar](50) NULL,
	[fecha] [date] NULL,
	[codigoproducto] [int] NULL,
	[cantidad] [int] NULL,
	[total] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vSalida]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vSalida] as
select s.idSalida as 'ID Salida', s.numeroventa as 'Numero de venta', s.tipodeproceso as 'Tipo de proceso', s.fecha as 'Fecha', 
p.nombre as 'Nombre', s.codigoproducto as 'Codigo de producto', s.cantidad as 'Cantidad', s.total as 'Total' from Center.salidas s
inner join Center.producto p on s.codigoproducto = p.id
GO
/****** Object:  Table [Center].[marca]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Center].[marca](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[marca] [varchar](80) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Center].[modelo]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Center].[modelo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[modelo] [varchar](80) NOT NULL,
	[marca] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Puestos_Empleados]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puestos_Empleados](
	[Id_Puesto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Puesto] [varchar](80) NOT NULL,
	[Descripción] [varchar](80) NOT NULL,
	[Id_Telefono] [int] NOT NULL,
 CONSTRAINT [PK_Puestos_Empleados] PRIMARY KEY CLUSTERED 
(
	[Id_Puesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Telefonos_Empleados]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefonos_Empleados](
	[Id_Telefono] [int] IDENTITY(1,1) NOT NULL,
	[Telefono] [int] NOT NULL,
	[Tipo_Paquete] [int] NOT NULL,
 CONSTRAINT [PK_Telefonos_Empleados] PRIMARY KEY CLUSTERED 
(
	[Id_Telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Paquete]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Paquete](
	[Id_Tipo_Paquete] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Paquete] [varchar](50) NOT NULL,
	[Descripción] [varchar](80) NOT NULL,
 CONSTRAINT [PK_Tipo_Paquete] PRIMARY KEY CLUSTERED 
(
	[Id_Tipo_Paquete] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vEmpleados]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[vEmpleados] as
SELECT Center.empleados.identidad AS [Identidad Empleado], Center.empleados.nombre AS [Nombre Completo], 
				  dbo.Puestos_Empleados.Nombre_Puesto AS Puesto, Center.marca.marca, Center.modelo.modelo, 
                  dbo.Tipo_Paquete.Nombre_Paquete AS [Paquete Asignado], dbo.Tipo_Paquete.Descripción AS [Descripcion del Paquete]
FROM     dbo.Puestos_Empleados INNER JOIN
                  Center.empleados ON dbo.Puestos_Empleados.Id_Puesto = Center.empleados.Id_Puesto INNER JOIN
                  dbo.Telefonos_Empleados ON dbo.Puestos_Empleados.Id_Telefono = dbo.Telefonos_Empleados.Id_Telefono AND 
				  dbo.Puestos_Empleados.Id_Telefono = dbo.Telefonos_Empleados.Id_Telefono AND 
                  dbo.Puestos_Empleados.Id_Telefono = dbo.Telefonos_Empleados.Id_Telefono INNER JOIN
                  Center.marca INNER JOIN
                  Center.modelo ON Center.marca.id = Center.modelo.marca ON dbo.Telefonos_Empleados.Telefono = Center.modelo.id AND 
				  dbo.Telefonos_Empleados.Telefono = Center.modelo.id AND 
                  dbo.Telefonos_Empleados.Telefono = Center.modelo.id INNER JOIN
                  dbo.Tipo_Paquete ON dbo.Telefonos_Empleados.Tipo_Paquete = dbo.Tipo_Paquete.Id_Tipo_Paquete AND 
				  dbo.Telefonos_Empleados.Tipo_Paquete = dbo.Tipo_Paquete.Id_Tipo_Paquete AND 
                  dbo.Telefonos_Empleados.Tipo_Paquete = dbo.Tipo_Paquete.Id_Tipo_Paquete
GO
/****** Object:  View [dbo].[vMarcas]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[vMarcas] AS
SELECT Center.modelo.id AS ID, CONCAT(Center.marca.marca, ' ', Center.modelo.modelo) AS Marca
FROM     Center.modelo INNER JOIN
         Center.marca ON Center.modelo.marca = Center.marca.id AND Center.modelo.marca = Center.marca.id AND 
		 Center.modelo.marca = Center.marca.id AND Center.modelo.marca = Center.marca.id
GO
/****** Object:  View [dbo].[vFactura]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create View [dbo].[vFactura] as 
select [idventa] as 'Numero de factura',[fecha] as 'fecha de venta',em.[nombre] as'Empleado que realizo la venta' ,CONCAT([Center].[cliente].[nombre],' ',[Center].[cliente].[apellido])  as 'Nombre del cliente ' ,[Center].[producto].[nombre] as 'nombre del articulo',dv.[cantidad] as 'cantidad que lleva',dv.[precio] as 'precio unidad',
(dv.[cantidad] * dv.[precio]) as 'Subtotal', [total] as 'total' from [Center].[detalleventa] as dv
inner join [Center].[venta] on [id]=[idventa]
inner join [Center].[producto]  on [Center].[producto].[id]=[idProducto]
inner join [Center].[cliente]  on [Center].[cliente].[id]=[idcliente]
inner join [Center].[empleados]  as em on  em.[IdCodigo] =[idempleado]

GO
/****** Object:  Table [Center].[tipoProducto]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Center].[tipoProducto](
	[id] [int] NOT NULL,
	[tipo] [varchar](25) NOT NULL,
	[descripcion] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vProductos]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vProductos] AS
SELECT Center.producto.codigobarra AS [Codigo De Barra], Center.producto.nombre AS [Nombre Producto], 
				  Center.producto.precio AS [Precio De Compra], Center.producto.precioventa AS [Precio De Venta], 
                  Center.producto.cantidad AS Cantidad, Center.producto.caracteristica AS Caracteristicas,
				  CONCAT(Center.marca.marca, ' ', Center.modelo.modelo) AS Marca, Center.tipoProducto.tipo AS [Tipo De Producto], 
                  Center.tipoProducto.descripcion AS [Descripción del Tipo]
FROM     Center.producto 
	  INNER JOIN Center.modelo ON Center.producto.modelo = Center.modelo.id 
      INNER JOIN Center.marca ON Center.modelo.marca = Center.marca.id 
 
	  INNER JOIN  Center.tipoProducto ON Center.producto.tipoproducto = Center.tipoProducto.id
GO
/****** Object:  Table [Center].[formaDePago]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Center].[formaDePago](
	[id] [int] NOT NULL,
	[formaPago] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Center].[rol]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Center].[rol](
	[id] [int] NOT NULL,
	[rol] [char](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Center].[usuario]    Script Date: 12/12/2020 12:34:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Center].[usuario](
	[id] [int] NOT NULL,
	[nombre] [varchar](25) NOT NULL,
	[apellido] [varchar](25) NOT NULL,
	[usuario] [varchar](25) NOT NULL,
	[contraseña] [varchar](50) NOT NULL,
	[correo] [varchar](50) NOT NULL,
	[rol] [int] NULL,
	[estado] [char](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [Center].[cliente] ON 
GO
INSERT [Center].[cliente] ([id], [identidad], [nombre], [apellido], [numero], [direccion], [estado]) VALUES (1, N'identidad', N'nombre', N'apellido', NULL, N'direccion', N'Eliminado')
GO
INSERT [Center].[cliente] ([id], [identidad], [nombre], [apellido], [numero], [direccion], [estado]) VALUES (2, N'0318200200555', N'Cristina', N'Aguilera', NULL, N'Sucasa uwu', N'Eliminado')
GO
INSERT [Center].[cliente] ([id], [identidad], [nombre], [apellido], [numero], [direccion], [estado]) VALUES (3, N'1524785988658', N'Jose', N'Mendoza', N'17552920', N'Tocoa, Colon', N'Activo')
GO
INSERT [Center].[cliente] ([id], [identidad], [nombre], [apellido], [numero], [direccion], [estado]) VALUES (4, N'0318197800571', N'Maria', N'Pineda', N'35214472', N'Siguatepeque, Comayagua', N'Activo')
GO
INSERT [Center].[cliente] ([id], [identidad], [nombre], [apellido], [numero], [direccion], [estado]) VALUES (5, N'051975481236', N'Adonai', N'Diaz', N'34781524', N'Siguatepeque, Comayagua', N'Activo')
GO
INSERT [Center].[cliente] ([id], [identidad], [nombre], [apellido], [numero], [direccion], [estado]) VALUES (6, N'0316198155023', N'Andrea', N'Pineda ', N'99165502', N'Marcala, La Paz', N'Activo')
GO
INSERT [Center].[cliente] ([id], [identidad], [nombre], [apellido], [numero], [direccion], [estado]) VALUES (7, N'1602200124125', N'Alberto', N'Trejo', N'32550214', N'Olanchito, Yoro', N'Activo')
GO
INSERT [Center].[cliente] ([id], [identidad], [nombre], [apellido], [numero], [direccion], [estado]) VALUES (8, N'0315200745212', N'Selvin', N'Ordoñez ', N'97184520', N'Taulabe, Comayagua', N'Activo')
GO
INSERT [Center].[cliente] ([id], [identidad], [nombre], [apellido], [numero], [direccion], [estado]) VALUES (9, N'1608197036421', N'Pedro', N'Gutierrez ', N'35140230', N'Choluteca, Choluteca', N'Activo')
GO
INSERT [Center].[cliente] ([id], [identidad], [nombre], [apellido], [numero], [direccion], [estado]) VALUES (10, N'1504198255432', N'Apolinario', N'Hernandez ', N'32658215', N'Nacahome, Valle ', N'Activo')
GO
INSERT [Center].[cliente] ([id], [identidad], [nombre], [apellido], [numero], [direccion], [estado]) VALUES (11, N'1804198565214', N'Raúl ', N'Perez', N'97201540', N'Olanchito, Yoro', N'Activo')
GO
INSERT [Center].[cliente] ([id], [identidad], [nombre], [apellido], [numero], [direccion], [estado]) VALUES (12, N'1408197855521', N'Samuel', N'Trochez', N'35206145', N'Gracias, Lempira', N'Activo')
GO
INSERT [Center].[cliente] ([id], [identidad], [nombre], [apellido], [numero], [direccion], [estado]) VALUES (13, N'1805198532122', N'Javier', N'Montoya', N'32154720', N'La Esperanza, Intibucá', N'Activo')
GO
INSERT [Center].[cliente] ([id], [identidad], [nombre], [apellido], [numero], [direccion], [estado]) VALUES (14, N'1205198454124', N'Manuel', N'Altamirano', N'97154420', N'La Ceiba, Atlántida', N'Activo')
GO
INSERT [Center].[cliente] ([id], [identidad], [nombre], [apellido], [numero], [direccion], [estado]) VALUES (15, N'1608200278962', N'Roberto', N'Manueles', N'94158623', N'Yuscarán, El Paraíso ', N'Activo')
GO
INSERT [Center].[cliente] ([id], [identidad], [nombre], [apellido], [numero], [direccion], [estado]) VALUES (16, N'0615199001520', N'Josefina', N'Mapcui', N'92991205', N'Santa Rosa de Copán, Copán ', N'Activo')
GO
INSERT [Center].[cliente] ([id], [identidad], [nombre], [apellido], [numero], [direccion], [estado]) VALUES (17, N'0819200031240', N'Walther', N'Menjivar', N'32541201', N'Santa Bárbara, Santa Bárbara', N'Activo')
GO
INSERT [Center].[cliente] ([id], [identidad], [nombre], [apellido], [numero], [direccion], [estado]) VALUES (18, N'1208200100571', N'Eduardo', N'Castellanos', N'97120170', N'Marcala, La Paz.', N'Activo')
GO
SET IDENTITY_INSERT [Center].[cliente] OFF
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (1, 1, N'1', 5, CAST(350 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (2, 1, N'1', 5, CAST(500 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (3, 2, N'3', 4, CAST(3700 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (4, 2, N'8', 2, CAST(5000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (5, 3, N'5', 2, CAST(3500 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (6, 3, N'6', 1, CAST(3999 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (7, 4, N'10', 2, CAST(6000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (8, 4, N'8', 1, CAST(5000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (9, 5, N'8', 1, CAST(5000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (10, 5, N'7', 2, CAST(6000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (11, 11, N'7', 2, CAST(5500 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (12, 12, N'19', 4, CAST(4000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (13, 13, N'4', 1, CAST(3800 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (14, 14, N'2', 2, CAST(6500 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (15, 14, N'6', 2, CAST(3300 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (16, 15, N'5', 2, CAST(3500 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (17, 15, N'14', 2, CAST(18000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (18, 16, N'4', 1, CAST(4000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (19, 17, N'6', 2, CAST(4000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (20, 20, N'1', 3, CAST(9000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (21, 22, N'14', 2, CAST(18000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (22, 22, N'19', 2, CAST(4500 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (23, 23, N'1', 3, CAST(9000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (24, 23, N'20', 3, CAST(6000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (25, 24, N'5', 1, CAST(3500 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (26, 24, N'8', 1, CAST(5000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (27, 25, N'7', 2, CAST(6000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (28, 25, N'19', 2, CAST(4500 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (29, 26, N'7', 1, CAST(6000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (30, 27, N'19', 2, CAST(4500 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (31, 28, N'15', 2, CAST(3300 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (32, 30, N'6', 1, CAST(3999 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (33, 31, N'3', 1, CAST(3700 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (34, 32, N'7', 1, CAST(6000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (35, 33, N'7', 1, CAST(6000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (36, 34, N'8', 1, CAST(5000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (45, 30, N'7', 2, CAST(3500 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (46, 35, N'11', 2, CAST(6200 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (47, 36, N'10', 3, CAST(6000 AS Decimal(18, 0)))
GO
INSERT [Center].[detalleventa] ([iddetalleventa], [idventa], [idProducto], [cantidad], [precio]) VALUES (48, 37, N'13', 2, CAST(12000 AS Decimal(18, 0)))
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (1, N'0101-2000-01154', N'Sara Hernandez', N'Atlantida, La Ceiba, El naranjal ', 20, N'Femenino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (3, N'1804-1980-04558', N'Merlin Alexandra Ramos Ponce', N'Yoro,Yoro, Villa Nuria', 40, N'Femenino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (5, N'0205-1997-15743', N'Nino Carlos Sanchez Mendoza', N'Colon,Saba, La Esperanza', 23, N'Masculino', 3, N'Eliminado')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (101, N'0101-2000-04263', N'Oscar Manuel garbanzo rivery', N'Atlantida,La Ceiba, Vista de Palmira', 19, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (103, N'0101-2000-00018', N'Abril de las Santisimas Barahona Calix', N'Atlantida,La Ceiba, El Sauce', 19, N'Femenino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (105, N'0101-2003-00245', N'Genesis Paola Cerrato Atala', N'Atlantida,La Ceiba, Toronjal II', 19, N'Femenino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (107, N'0101-1966-01081', N'Gloria Ondina Valladares Romero', N'Atlantida,La Ceiba, Toronjal II', 19, N'Femenino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (109, N'0101-1966-01284', N'Jose Gustavo Murillo Valladares', N'Atlantida,La Ceiba, Toronjal II', 19, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (191, N'0101-1981-27511', N'Carlos Daniel Romero Mencilla', N'La Ceiba,Atlantida, Col. Pizzaty', 39, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (193, N'0101-1982-22207', N'Gustavo Josue Colindres Almendares', N'La Ceiba,Atlantida, Col. Sierra Pina', 38, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (221, N'0101-1982-22207', N'Sebastian Miguel Barahona Mencia', N'La Ceiba,Atlantida, Col. Sierra Pina', 38, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (320, N'0313-1999-00006', N'Jose Isidro Ventura Reyes', N'Comayagua, Siguatepeque, El Carmen', 21, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (321, N'0101-1997-00006', N'Henrry Osmani Costa Benitez', N'Comayagua, Siguatepeque, El Parnaso', 23, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (350, N'0107-1998-00006', N'Francisco Jose Hernandez Gonzales', N'Comayagua, Siguatepeque, Colonia Mata', 22, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (412, N'0403-2000-00006', N'Daniela Alejandra Garcia Medina', N'Comayagua, Siguatepeque, San Antonio', 20, N'Femenino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (440, N'0318-1990-03001', N'Gustavo Enrique Arellano Arias', N'Comayagua,Siguatepeque, Las Colinas', 30, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (442, N'0318-1986-00012', N'Roberto Jose Gomez Moncada', N'Comayagua,Siguatepeque, Barrio Fatima', 34, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (444, N'0318-1986-00873', N'Carlos Alonso Estrada Castillo', N'Comayagua,Siguatepeque, Barrio Abajo', 34, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (446, N'0318-1989-00345', N'Daniela Alejandra Castro Castro', N'Comayagua,Siguatepeque, Barrio San Antonio', 31, N'Femenino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (448, N'0318-1992-00741', N'Lidia Jimena Aguilar Espinoza', N'Comayagua,Siguatepeque, El Centro', 29, N'Femenino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (550, N'1016-1997-00006', N'Miguel Benjamin Hernandez Betrand', N'Comayagua, Siguatepeque, Las Colinas', 23, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (551, N'0318-1993-00400', N'Nicol Pamela Jimenez Mejia', N'Comayagua,Siguatepeque, El Centro', 27, N'Femenino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (553, N'0318-1990-08821', N'Rocio Beatriz Meza Palacios', N'Comayagua,Siguatepeque, El Carmen', 30, N'Femenino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (991, N'0101-1994-24872', N'Ricardo Alberto Lopez Ramirez', N'La Ceiba,Atlantida, Barrio Mejia', 19, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (993, N'1804-2001-05389', N'Merlin Denisse Guerra Ponce', N'Yoro,Yoro, Villa Nuria', 18, N'Femenino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (995, N'0205-1997-15743', N'Christian Omar Sanchez Munguia', N'Colon,Saba, La Esperanza', 23, N'Masculino', 3, N'Eliminado')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (997, N'0401-1992-58437', N'Andrea Maria Garcia Muñoz', N'Copán, Santa Rosa de Copan, Col Osorios', 28, N'Femenino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (999, N'1501-1998-00103', N'Amelia Ruth Lopez Muñoz', N'Olancho, Juticalpa, Col Saturno', 21, N'Femenino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (1011, N'0801-1993-22101', N'Gustavo Antonio Murillo Valladares', N'Francisco Morazan,Tegucigalpa, Col. 21 de Octubre', 26, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (1013, N'0801-1995-01234', N'Maria Fernanda Cuestas Fernandez ', N'Francisco Morazon,Tegucigalpa, Col. 21 de Octubre', 19, N'Femenino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (1015, N'0318-1999-06851', N'Esdras Joel Tinoco Mejia', N'Comayagua,Siguatepeque, El Centro', 20, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (1017, N'0101-2000-07580', N'Eduardo Manuel Mencia Lopez', N'Atlantida,La Ceiba, Villa Mary', 20, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (1019, N'0101-2000-01185', N'Carlos Mario Paz Santos', N'Atlantida,La Ceiba, Villa Mary', 20, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (1021, N'0101-1991-03336', N'Christopher Josue Ramos Diaz', N'Atlantida,La Ceiba, Santa Lucia', 29, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (1023, N'0101-1990-08974', N'Christopher Alejandro Cabrera Romero', N'Atlantida,La Ceiba, El Naranjal', 30, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (1025, N'0501-1991-00032', N'Enrique Federico Cruz Cruz ', N'Cortes,San Pedro Sula, El Centro', 29, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (1027, N'1101-1989-02222', N'Carlos Joe Jones Diaz ', N'Islas de la Bahia,Roatan, El Centro', 31, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (1253, N'0318-2001-00445', N'Daniela Isabel Vasquez', N'Comayagua,Siguatepeque, Barrio San Antonio', 19, N'Femenino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (4589, N'0318-2004-00731', N'Elmer Chandia Sabillon', N'Comayagua,Siguatepeque, El Centro', 19, N'Maculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (9911, N'1402-1996-01062', N'Gabriela Paola Escobar Contreras', N'Ocotepeque, Belen Gualcho, Col Neptuno', 23, N'Femenino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (9913, N'1101-1996-01163', N'Kurt David Hernandez Jones', N'Islas de la Bahia, Roatan, Col Small Key', 23, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (9915, N'1102-2001-03697', N'Jose Dario Peralta Paz', N'Islas de la Bahia, Guanaja, Barrio Abajo', 18, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (9917, N'0318-2002-05628', N'Antonio Raul Valladares Castillo', N'Comayagua,Siguatepeque, Barrio Abajo', 18, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (9919, N'0301-2002-05629', N'Francisco Jose Valladares Castillo', N'Comayagua,Siguatepeque, Barrio Abajo', 18, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (9921, N'0801-2001-00034', N'German Jose Molinero Mejia', N'Francisco Morazan,Tegucigalpa, Valle de Angeles', 19, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (9925, N'0501-1999-01134', N'Fabian Alejandro Castro Facusse', N'Cortes,San Pedro Sula, Colonia Satelite', 21, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (9927, N'0501-1998-01434', N'Santiago Andres Castro Facusse', N'Cortes,San Pedro Sula, Colonia Satelite', 22, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (9928, N'0501-1998-00698', N'Andres Santiago Facusse Castro', N'Cortes, San Pedro Sula, Colonia Satelite', 23, N'Masculino', 3, N'Activo')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (32123, N'1232-2000-00003', N'Danilo José Oviedo Ulloa', N'el rancho de a lado en olancho', 22, N'Masculino', 3, N'Eliminado')
GO
INSERT [Center].[empleados] ([IdCodigo], [identidad], [nombre], [direccion], [edad], [sexo], [Id_Puesto], [Estado]) VALUES (40010, N'0318-2000-0243', N'mauricio kempez', N'vive en el calan donde la doña cuelga la tela', 20, N'Masculino', 3, N'Activo')
GO
SET IDENTITY_INSERT [Center].[entradas] ON 
GO
INSERT [Center].[entradas] ([identrada], [codbarra], [nombre], [precioventa], [cantidad], [total]) VALUES (1, N'jbjbj123', N'xiomi', CAST(6500 AS Decimal(18, 0)), CAST(12 AS Decimal(18, 0)), CAST(78000 AS Decimal(18, 0)))
GO
SET IDENTITY_INSERT [Center].[entradas] OFF
GO
INSERT [Center].[formaDePago] ([id], [formaPago]) VALUES (1, N'Efectivo')
GO
INSERT [Center].[formaDePago] ([id], [formaPago]) VALUES (2, N'Tarjeta de Crédito')
GO
INSERT [Center].[formaDePago] ([id], [formaPago]) VALUES (3, N'Tarjeta de Débito')
GO
INSERT [Center].[formaDePago] ([id], [formaPago]) VALUES (4, N'Transferencia Electrónica ')
GO
SET IDENTITY_INSERT [Center].[marca] ON 
GO
INSERT [Center].[marca] ([id], [marca]) VALUES (1, N'CHAYOTE')
GO
INSERT [Center].[marca] ([id], [marca]) VALUES (2, N'Samsung')
GO
INSERT [Center].[marca] ([id], [marca]) VALUES (3, N'Apple')
GO
INSERT [Center].[marca] ([id], [marca]) VALUES (4, N'Xiaomi')
GO
INSERT [Center].[marca] ([id], [marca]) VALUES (5, N'Huawei')
GO
INSERT [Center].[marca] ([id], [marca]) VALUES (6, N'Lenovo')
GO
INSERT [Center].[marca] ([id], [marca]) VALUES (7, N'LG')
GO
INSERT [Center].[marca] ([id], [marca]) VALUES (8, N'Sony')
GO
INSERT [Center].[marca] ([id], [marca]) VALUES (9, N'Nokia')
GO
INSERT [Center].[marca] ([id], [marca]) VALUES (10, N'Asus')
GO
INSERT [Center].[marca] ([id], [marca]) VALUES (11, N'ZTE')
GO
INSERT [Center].[marca] ([id], [marca]) VALUES (12, N'Microsoft')
GO
INSERT [Center].[marca] ([id], [marca]) VALUES (13, N'BlackBerry')
GO
INSERT [Center].[marca] ([id], [marca]) VALUES (14, N'Meizu')
GO
INSERT [Center].[marca] ([id], [marca]) VALUES (15, N'Lanix')
GO
INSERT [Center].[marca] ([id], [marca]) VALUES (16, N'MSI')
GO
SET IDENTITY_INSERT [Center].[marca] OFF
GO
SET IDENTITY_INSERT [Center].[modelo] ON 
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (1, N'NENOTA 6IX9INE', 1)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (2, N'Galaxy A20s', 2)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (3, N'Galaxy M11', 2)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (4, N'Galaxy J6', 2)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (5, N'Galaxy S9 Plus', 2)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (6, N'Galaxy Note 10 Plus', 2)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (7, N'iPhone 8', 3)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (8, N'iPhone 6s Plus', 3)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (9, N'iPhone 6 ', 3)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (10, N'iPhone X', 3)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (12, N'iPhone 11 ', 3)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (13, N'Mi 10 Lite ', 4)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (14, N'Redmi K30 Pro ', 4)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (15, N'Redmi Note 9s', 4)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (16, N'Mi Note 10 Pro ', 4)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (17, N'Poco X3 NFC', 4)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (18, N'P40 Pro ', 5)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (19, N'Y7p', 5)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (20, N'Mate Xs', 5)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (21, N'Y8s', 5)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (22, N'Mate 30 Pro 5G', 5)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (23, N'Moto M', 6)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (24, N'Moto Z Force', 6)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (25, N'K6 Power', 6)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (26, N'Moto G5 Plus', 6)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (27, N'Z6 Pro', 6)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (28, N'V50 ThinQ', 7)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (29, N'G7 One ', 7)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (30, N'Q8 2018', 7)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (31, N'X2 2019', 7)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (32, N'K62', 7)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (33, N'Xperia XA2', 8)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (34, N'Xperia R1 Plus', 8)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (35, N'Xperia XZ3', 8)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (36, N'Xperia 1', 8)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (37, N'Xperia 5 II', 8)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (38, N'5.1 ', 9)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (39, N'X5', 9)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (40, N'6.1 Plus', 9)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (41, N'X71 ', 9)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (42, N'6.2', 9)
GO
INSERT [Center].[modelo] ([id], [modelo], [marca]) VALUES (43, N'SE75', 16)
GO
SET IDENTITY_INSERT [Center].[modelo] OFF
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'1', N'wds34456', 1, N'Teléfono Samsung', CAST(8000 AS Decimal(18, 0)), CAST(9000 AS Decimal(18, 0)), 6, N'Se dobla', N'Eliminado', 2)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'10', N'qqr674df', 1, N'Teléfono Apple', CAST(5000 AS Decimal(18, 0)), CAST(6000 AS Decimal(18, 0)), 1, N'Memoria RAM: 2GB Almacenamiento: 64GB IOS: 11', N'En Existencia', 7)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'11', N'llky482e', 1, N'Teléfono Apple', CAST(5200 AS Decimal(18, 0)), CAST(6200 AS Decimal(18, 0)), 40, N'Memoria RAM: 2GB Almacenamiento: 16GB IOS: 9 ', N'En Existencia', 8)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'12', N'assw22q', 1, N'Teléfono Xiaomi', CAST(8400 AS Decimal(18, 0)), CAST(9000 AS Decimal(18, 0)), 12, N'Memoria RAM: 6GB Almacenamiento: 64GB Android: 10', N'En Existencia', 13)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'13', N'bvgf753', 1, N'Teléfono Xiaomi', CAST(11000 AS Decimal(18, 0)), CAST(12000 AS Decimal(18, 0)), 2, N'Memoria RAM: 6GB Almacenamiento: 128GB Android: 10', N'En Existencia', 14)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'14', N'yfgyd78', 1, N'Teléfono Huawei', CAST(16000 AS Decimal(18, 0)), CAST(18000 AS Decimal(18, 0)), 2, N'Memoria RAM: 8GB Almacenamiento: 256GB Android: 10', N'En Existencia', 18)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'15', N'kliñ23e4', 1, N'Teléfono Huawei', CAST(3000 AS Decimal(18, 0)), CAST(3300 AS Decimal(18, 0)), 10, N'Memoria RAM: 4GB Almacenamiento: 64GB Android: 10', N'En Existencia', 19)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'16', N'cxds123', 2, N'Teléfono Lenovo', CAST(2500 AS Decimal(18, 0)), CAST(3000 AS Decimal(18, 0)), 12, N'Memoria RAM: 3GB Almacenamiento: 32GB Android: 6', N'En Existencia', 23)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'17', N'eqrw124e', 2, N'Teléfono Lenovo', CAST(3000 AS Decimal(18, 0)), CAST(3500 AS Decimal(18, 0)), 4, N'Memoria RAM: 4GB Almacenamiento: 32GB Android: 6', N'En Existencia', 24)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'18', N'sska254q', 1, N'Teléfono LG', CAST(6000 AS Decimal(18, 0)), CAST(6500 AS Decimal(18, 0)), 6, N'Memoria RAM: 6GB Almacenamiento: 128GB Android: 10', N'En Existencia', 28)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'19', N'kkru2w4e', 2, N'Teléfono LG', CAST(4000 AS Decimal(18, 0)), CAST(4500 AS Decimal(18, 0)), 2, N'Memoria RAM: 4GB Almacenamiento: 32GB Android: 8', N'En Existencia', 29)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'2', N'sdw3456', 1, N'Teléfono Xiaomi', CAST(6500 AS Decimal(18, 0)), CAST(7000 AS Decimal(18, 0)), 4, N'Memoria RAM:6GB Almacenamiento:128GB Android 10', N'En Existencia', 15)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'20', N'xssxs238', 1, N'Teléfono Sony', CAST(5000 AS Decimal(18, 0)), CAST(6000 AS Decimal(18, 0)), 3, N'Memoria RAM: 4GB Almacenamiento: 64GB Android: 8', N'En Existencia', 33)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'21', N'sfw555we', 1, N'Teléfono Sony', CAST(5200 AS Decimal(18, 0)), CAST(6100 AS Decimal(18, 0)), 12, N'Memoria RAM: 3GB Almacenamiento: 32GB Android: 9', N'Eliminado', 34)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'26', N'jbjbj123', 1, N'xiomi', CAST(3500 AS Decimal(18, 0)), CAST(6500 AS Decimal(18, 0)), 12, N'celular robado', NULL, 2)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'3', N'trw862w5', 2, N'Teléfono Nokia ', CAST(3500 AS Decimal(18, 0)), CAST(3700 AS Decimal(18, 0)), 5, N'Memoria RAM:3GB Almacenamiento: 32GB Android 8.1 ', N'En Existencia', 38)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'4', N'kjh458k6', 2, N'Teléfono Nokia', CAST(3800 AS Decimal(18, 0)), CAST(4000 AS Decimal(18, 0)), 3, N'Memoria RAM:6GB Almacenamiento:64GB Android 8.1', N'En Existencia', 39)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'5', N'asd247t8', 2, N'Teléfono Nokia', CAST(3200 AS Decimal(18, 0)), CAST(3500 AS Decimal(18, 0)), 7, N'Memoria RAM:4GB Almacenamiento:64GB Android: 8.1', N'En Existencia', 40)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'6', N'ewr8885t', 2, N'Teléfono Nokia', CAST(3300 AS Decimal(18, 0)), CAST(3999 AS Decimal(18, 0)), 0, N'Memoria RAM: 6GB Almacenamiento: 128GB Android: 9 ', N'En Existencia', 41)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'7', N'hfjf5841w', 2, N'Teléfono Nokia', CAST(5500 AS Decimal(18, 0)), CAST(6000 AS Decimal(18, 0)), -1, N'Memoria RAM: 6GB Almacenamiento: 64GB Android: 9.1', N'En Existencia', 42)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'8', N'frwt852q', 1, N'Teléfono Samsung', CAST(4500 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), -2, N'Memoria RAM: 4GB Almacenamiento: 64GB Android: 9', N'En Existencia', 2)
GO
INSERT [Center].[producto] ([id], [codigobarra], [tipoproducto], [nombre], [precio], [precioventa], [cantidad], [caracteristica], [estado], [modelo]) VALUES (N'9', N'nbh5542r', 1, N'Teléfono Samsung', CAST(4700 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), 6, N'Memoria RAM: 4GB Almacenamiento: 64GB Android: 10', N'En Existencia', 3)
GO
INSERT [Center].[rol] ([id], [rol]) VALUES (1, N'Administrador  ')
GO
INSERT [Center].[rol] ([id], [rol]) VALUES (2, N'Empleado       ')
GO
SET IDENTITY_INSERT [Center].[salidas] ON 
GO
INSERT [Center].[salidas] ([idsalida], [numeroventa], [tipodeproceso], [fecha], [codigoproducto], [cantidad], [total]) VALUES (1, 30, N'salida', CAST(N'2020-12-10' AS Date), 7, 2, CAST(7000 AS Decimal(18, 0)))
GO
INSERT [Center].[salidas] ([idsalida], [numeroventa], [tipodeproceso], [fecha], [codigoproducto], [cantidad], [total]) VALUES (2, 35, N'salida', CAST(N'2020-12-11' AS Date), 11, 2, CAST(12400 AS Decimal(18, 0)))
GO
INSERT [Center].[salidas] ([idsalida], [numeroventa], [tipodeproceso], [fecha], [codigoproducto], [cantidad], [total]) VALUES (3, 36, N'salida', CAST(N'2020-12-11' AS Date), 10, 3, CAST(18000 AS Decimal(18, 0)))
GO
INSERT [Center].[salidas] ([idsalida], [numeroventa], [tipodeproceso], [fecha], [codigoproducto], [cantidad], [total]) VALUES (4, 37, N'salida', CAST(N'2020-12-12' AS Date), 13, 2, CAST(24000 AS Decimal(18, 0)))
GO
SET IDENTITY_INSERT [Center].[salidas] OFF
GO
INSERT [Center].[tipoProducto] ([id], [tipo], [descripcion]) VALUES (1, N'Celular', N'Celulares Inteligentes')
GO
INSERT [Center].[tipoProducto] ([id], [tipo], [descripcion]) VALUES (2, N'Celular', N'Celulares sencillos')
GO
INSERT [Center].[usuario] ([id], [nombre], [apellido], [usuario], [contraseña], [correo], [rol], [estado]) VALUES (1, N'Edgardi', N'Zavala', N'ChamuBro', N'12345', N'hector_777@gmail.com', 1, N'inactivo            ')
GO
INSERT [Center].[usuario] ([id], [nombre], [apellido], [usuario], [contraseña], [correo], [rol], [estado]) VALUES (3, N'marlon', N'martinez', N'mmenjiva', N'1234', N'meilimala@gmail.com', 1, N'activo              ')
GO
INSERT [Center].[usuario] ([id], [nombre], [apellido], [usuario], [contraseña], [correo], [rol], [estado]) VALUES (5, N'maria', N'menjivar', N'hottimarta', N'1234', N'meilimala@gmail.com', 1, N'activo              ')
GO
INSERT [Center].[usuario] ([id], [nombre], [apellido], [usuario], [contraseña], [correo], [rol], [estado]) VALUES (6, N'messi', N'andres', N'messi10', N'1010', N'meesi1987@yahoo.com', 2, N'activo              ')
GO
INSERT [Center].[usuario] ([id], [nombre], [apellido], [usuario], [contraseña], [correo], [rol], [estado]) VALUES (7, N'cristiano', N'ronaldo', N'cr7', N'752', N'cris777@gmail.com', 2, N'activo              ')
GO
INSERT [Center].[usuario] ([id], [nombre], [apellido], [usuario], [contraseña], [correo], [rol], [estado]) VALUES (8, N'Vegueta', N'deLuque', N'vegetageymer', N'uwu12345', N'vegeta777@gamil.com', 2, N'activo              ')
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (1, 1, 1, CAST(N'2020-12-04' AS Date), 1, CAST(1 AS Decimal(18, 0)), CAST(2600 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (2, 2, 1, CAST(N'2020-12-05' AS Date), 1, CAST(2 AS Decimal(18, 0)), CAST(24800 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (3, 3, 101, CAST(N'2020-12-05' AS Date), 1, CAST(2 AS Decimal(18, 0)), CAST(10999 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (4, 4, 103, CAST(N'2020-12-05' AS Date), 1, CAST(3 AS Decimal(18, 0)), CAST(17000 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (5, 5, 107, CAST(N'2020-12-05' AS Date), 1, CAST(4 AS Decimal(18, 0)), CAST(17000 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (6, 10, 1, CAST(N'2020-12-12' AS Date), 1, CAST(6 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (7, 2, 5, CAST(N'2020-12-12' AS Date), 1, CAST(7 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (8, 3, 5, CAST(N'2020-12-12' AS Date), 1, CAST(8 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (9, 2, 5, CAST(N'2020-12-12' AS Date), 1, CAST(9 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (10, 17, 1, CAST(N'2020-09-12' AS Date), 1, CAST(10 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (11, 5, 101, CAST(N'2020-12-12' AS Date), 1, CAST(5 AS Decimal(18, 0)), CAST(11000 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (12, 4, 3, CAST(N'2020-12-12' AS Date), 1, CAST(12 AS Decimal(18, 0)), CAST(16000 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (13, 3, 5, CAST(N'2020-12-12' AS Date), 1, CAST(13 AS Decimal(18, 0)), CAST(3800 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (14, 3, 5, CAST(N'2020-12-12' AS Date), 1, CAST(12 AS Decimal(18, 0)), CAST(19600 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (15, 4, 1, CAST(N'2020-12-12' AS Date), 1, CAST(15 AS Decimal(18, 0)), CAST(43000 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (16, 11, 442, CAST(N'2020-12-12' AS Date), 1, CAST(16 AS Decimal(18, 0)), CAST(8000 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (17, 16, 5, CAST(N'2020-10-12' AS Date), 1, CAST(17 AS Decimal(18, 0)), CAST(27024 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (18, 4, 3, CAST(N'2020-12-12' AS Date), 1, CAST(18 AS Decimal(18, 0)), CAST(17400 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (19, 3, 101, CAST(N'2020-01-11' AS Date), 1, CAST(19 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (20, 2, 1, CAST(N'2020-10-12' AS Date), 1, CAST(20 AS Decimal(18, 0)), CAST(27000 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (21, 4, 101, CAST(N'2020-10-10' AS Date), 1, CAST(21 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (22, 3, 101, CAST(N'2020-10-12' AS Date), 1, CAST(22 AS Decimal(18, 0)), CAST(45000 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (23, 5, 103, CAST(N'2020-10-10' AS Date), 1, CAST(23 AS Decimal(18, 0)), CAST(45000 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (24, 3, 103, CAST(N'2020-10-10' AS Date), 1, CAST(24 AS Decimal(18, 0)), CAST(8500 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (25, 3, 101, CAST(N'2020-10-10' AS Date), 1, CAST(25 AS Decimal(18, 0)), CAST(21000 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (26, 3, 103, CAST(N'2020-10-10' AS Date), 1, CAST(26 AS Decimal(18, 0)), CAST(6000 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (27, 2, 103, CAST(N'2020-10-10' AS Date), 1, CAST(27 AS Decimal(18, 0)), CAST(9000 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (28, 6, 221, CAST(N'2020-10-10' AS Date), 1, CAST(28 AS Decimal(18, 0)), CAST(6600 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (29, 5, 1, CAST(N'2020-10-10' AS Date), 1, CAST(29 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (30, 2, 101, CAST(N'2020-10-10' AS Date), 1, CAST(30 AS Decimal(18, 0)), CAST(10999 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (31, 5, 101, CAST(N'2020-10-10' AS Date), 1, CAST(31 AS Decimal(18, 0)), CAST(3700 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (32, 4, 101, CAST(N'2020-10-10' AS Date), 1, CAST(32 AS Decimal(18, 0)), CAST(6000 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (33, 17, 101, CAST(N'2020-10-10' AS Date), 1, CAST(33 AS Decimal(18, 0)), CAST(6000 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (34, 5, 3, CAST(N'2020-10-10' AS Date), 1, CAST(34 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (35, 2, 5, CAST(N'2020-11-12' AS Date), 1, CAST(35 AS Decimal(18, 0)), CAST(12400 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (36, 2, 3, CAST(N'2020-12-11' AS Date), 1, CAST(36 AS Decimal(18, 0)), CAST(18000 AS Decimal(18, 0)))
GO
INSERT [Center].[venta] ([id], [idcliente], [idempleado], [fecha], [formapago], [numerofactura], [total]) VALUES (37, 3, 101, CAST(N'2020-12-12' AS Date), 1, CAST(37 AS Decimal(18, 0)), CAST(24000 AS Decimal(18, 0)))
GO
SET IDENTITY_INSERT [dbo].[Puestos_Empleados] ON 
GO
INSERT [dbo].[Puestos_Empleados] ([Id_Puesto], [Nombre_Puesto], [Descripción], [Id_Telefono]) VALUES (3, N'Gerente', N'Es bien pro', 1)
GO
SET IDENTITY_INSERT [dbo].[Puestos_Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[Telefonos_Empleados] ON 
GO
INSERT [dbo].[Telefonos_Empleados] ([Id_Telefono], [Telefono], [Tipo_Paquete]) VALUES (1, 1, 3)
GO
INSERT [dbo].[Telefonos_Empleados] ([Id_Telefono], [Telefono], [Tipo_Paquete]) VALUES (2, 13, 2)
GO
INSERT [dbo].[Telefonos_Empleados] ([Id_Telefono], [Telefono], [Tipo_Paquete]) VALUES (3, 4, 1)
GO
SET IDENTITY_INSERT [dbo].[Telefonos_Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[Tipo_Paquete] ON 
GO
INSERT [dbo].[Tipo_Paquete] ([Id_Tipo_Paquete], [Nombre_Paquete], [Descripción]) VALUES (1, N'Master', N'tiene de todo we 50 gb nena ozi ozi')
GO
INSERT [dbo].[Tipo_Paquete] ([Id_Tipo_Paquete], [Nombre_Paquete], [Descripción]) VALUES (2, N'Master', N'tiene de todo we 50 gb nena ozi ozi')
GO
INSERT [dbo].[Tipo_Paquete] ([Id_Tipo_Paquete], [Nombre_Paquete], [Descripción]) VALUES (3, N'Master', N'tiene de todo we 50 gb nena ozi ozi')
GO
SET IDENTITY_INSERT [dbo].[Tipo_Paquete] OFF
GO
ALTER TABLE [Center].[cliente] ADD  DEFAULT ('Activo') FOR [estado]
GO
ALTER TABLE [Center].[empleados] ADD  CONSTRAINT [DF_empleados_Estado]  DEFAULT ('Activo') FOR [Estado]
GO
ALTER TABLE [Center].[producto] ADD  CONSTRAINT [DF__producto__estado__571DF1D5]  DEFAULT ('En Existencia') FOR [estado]
GO
ALTER TABLE [Center].[salidas] ADD  DEFAULT ('Salida') FOR [tipodeproceso]
GO
ALTER TABLE [Center].[salidas] ADD  DEFAULT (getdate()) FOR [fecha]
GO
ALTER TABLE [Center].[detalleventa]  WITH CHECK ADD  CONSTRAINT [FK__detalleve__idPro__59FA5E80] FOREIGN KEY([idProducto])
REFERENCES [Center].[producto] ([id])
GO
ALTER TABLE [Center].[detalleventa] CHECK CONSTRAINT [FK__detalleve__idPro__59FA5E80]
GO
ALTER TABLE [Center].[detalleventa]  WITH CHECK ADD  CONSTRAINT [fk_detalle_idventa] FOREIGN KEY([idventa])
REFERENCES [Center].[venta] ([id])
GO
ALTER TABLE [Center].[detalleventa] CHECK CONSTRAINT [fk_detalle_idventa]
GO
ALTER TABLE [Center].[empleados]  WITH CHECK ADD  CONSTRAINT [FK_empleados_Puestos_Empleados] FOREIGN KEY([Id_Puesto])
REFERENCES [dbo].[Puestos_Empleados] ([Id_Puesto])
GO
ALTER TABLE [Center].[empleados] CHECK CONSTRAINT [FK_empleados_Puestos_Empleados]
GO
ALTER TABLE [Center].[modelo]  WITH CHECK ADD FOREIGN KEY([marca])
REFERENCES [Center].[marca] ([id])
GO
ALTER TABLE [Center].[producto]  WITH CHECK ADD  CONSTRAINT [FK__producto__modelo__5EBF139D] FOREIGN KEY([modelo])
REFERENCES [Center].[modelo] ([id])
GO
ALTER TABLE [Center].[producto] CHECK CONSTRAINT [FK__producto__modelo__5EBF139D]
GO
ALTER TABLE [Center].[producto]  WITH CHECK ADD  CONSTRAINT [FK__producto__tipopr__5FB337D6] FOREIGN KEY([tipoproducto])
REFERENCES [Center].[tipoProducto] ([id])
GO
ALTER TABLE [Center].[producto] CHECK CONSTRAINT [FK__producto__tipopr__5FB337D6]
GO
ALTER TABLE [Center].[salidas]  WITH CHECK ADD FOREIGN KEY([numeroventa])
REFERENCES [Center].[venta] ([id])
GO
ALTER TABLE [Center].[usuario]  WITH CHECK ADD FOREIGN KEY([rol])
REFERENCES [Center].[rol] ([id])
GO
ALTER TABLE [Center].[venta]  WITH CHECK ADD FOREIGN KEY([formapago])
REFERENCES [Center].[formaDePago] ([id])
GO
ALTER TABLE [Center].[venta]  WITH CHECK ADD  CONSTRAINT [fk_factura_idcliente] FOREIGN KEY([idcliente])
REFERENCES [Center].[cliente] ([id])
GO
ALTER TABLE [Center].[venta] CHECK CONSTRAINT [fk_factura_idcliente]
GO
ALTER TABLE [Center].[venta]  WITH CHECK ADD  CONSTRAINT [fk_factura_idempleado] FOREIGN KEY([idempleado])
REFERENCES [Center].[empleados] ([IdCodigo])
GO
ALTER TABLE [Center].[venta] CHECK CONSTRAINT [fk_factura_idempleado]
GO
ALTER TABLE [dbo].[Puestos_Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Puestos_Empleados_Telefonos_Empleados] FOREIGN KEY([Id_Telefono])
REFERENCES [dbo].[Telefonos_Empleados] ([Id_Telefono])
GO
ALTER TABLE [dbo].[Puestos_Empleados] CHECK CONSTRAINT [FK_Puestos_Empleados_Telefonos_Empleados]
GO
ALTER TABLE [dbo].[Telefonos_Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Telefonos_Empleados_modelo] FOREIGN KEY([Telefono])
REFERENCES [Center].[modelo] ([id])
GO
ALTER TABLE [dbo].[Telefonos_Empleados] CHECK CONSTRAINT [FK_Telefonos_Empleados_modelo]
GO
ALTER TABLE [dbo].[Telefonos_Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Telefonos_Empleados_Tipo_Paquete] FOREIGN KEY([Tipo_Paquete])
REFERENCES [dbo].[Tipo_Paquete] ([Id_Tipo_Paquete])
GO
ALTER TABLE [dbo].[Telefonos_Empleados] CHECK CONSTRAINT [FK_Telefonos_Empleados_Tipo_Paquete]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarEmpleado]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

    create procedure [dbo].[ActualizarEmpleado](@identidad varchar(15),@nombre varchar(50),
    @direccion varchar(60),@edad int,@sexo varchar(10), @Id_Puesto int)
	as 
	begin
	if exists(select identidad, [Estado] from Center.empleados where identidad = @identidad and [Estado] = 'Activo')
	update Center.empleados 
	set nombre =@nombre, direccion = @direccion, edad = @edad, sexo = @sexo, id_Puesto = @Id_Puesto
	where identidad = @identidad
	else
		raiserror('El empleado no existe en la base de datos',16,1)
	end
GO
/****** Object:  StoredProcedure [dbo].[actualizarProducto]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizarProducto]
@id as int, @nombre as varchar(25), @precio as decimal(18,0), @precioventa as decimal(18,0),
@cantidad as int, @caracteristica as varchar(50)
AS
BEGIN
UPDATE [Center].[producto]
SET [nombre] = @nombre, [precio] = @precio, [precioventa] = @precioventa, [cantidad] = @cantidad, [caracteristica] = @caracteristica
WHERE [id] = @id
END
GO
/****** Object:  StoredProcedure [dbo].[actualizarTelefonosEmpleados]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizarTelefonosEmpleados]
@Id_Telefono as int, @Telefono as int, @Tipo_Paquete as int
AS
BEGIN
UPDATE [dbo].[Telefonos_Empleados]
SET [Telefono] = @Telefono, [Tipo_Paquete] = @Tipo_Paquete
WHERE [Id_Telefono] = @Id_Telefono
END
GO
/****** Object:  StoredProcedure [dbo].[actualizarTipoProducto]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizarTipoProducto]
@id as int, @tipo as varchar(25), @descripcion as varchar(60)
AS
BEGIN
UPDATE [Center].[tipoProducto]
SET [tipo] = @tipo, [descripcion] = @descripcion where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[actualizarUsuario]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizarUsuario] (
@id as int ,
@nombre varchar(25),
@apellido varchar(25),
@usuario varchar(25),
@contraseña varchar(25),
@correo varchar(25),
@rol int,
@estado char(20)
)

AS
BEGIN
if exists(select usuario from center.usuario where usuario =@usuario and id =@id) 
update center.usuario
set nombre  = @nombre, apellido= @apellido, usuario = @usuario,
contraseña  = @contraseña,correo = @correo, rol=@rol,estado=@estado
where id = @id
else
raiserror('Usuario No encontrado',16,1)
end 
GO
/****** Object:  StoredProcedure [dbo].[agregarProducto]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarProducto]
@id as int, @codigobarra as varchar(25), @tipoproducto as int, 
@nombre as varchar(25), @precio as decimal(18,0), @precioventa as decimal(18,0),
@cantidad as int, @caracteristica as varchar(50), @modelo as int
AS

BEGIN

INSERT INTO [Center].[producto](id, codigobarra, tipoproducto, nombre, precio, precioventa, cantidad, caracteristica, modelo)
VALUES (@id, @codigobarra, @tipoproducto, @nombre, @precio, @precioventa, @cantidad, @caracteristica, @modelo)

END
GO
/****** Object:  StoredProcedure [dbo].[agregarTelefonosEmpleados]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarTelefonosEmpleados]
@Telefono as int, @Tipo_Paquete as int
AS
BEGIN
INSERT INTO [dbo].[Telefonos_Empleados](Telefono, Tipo_Paquete)
VALUES (@Telefono, @Tipo_Paquete)
END
GO
/****** Object:  StoredProcedure [dbo].[agregarTipoProducto]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------------TipoProducto---------------------------------------------------------------
CREATE PROCEDURE [dbo].[agregarTipoProducto]
@id as int, @tipo as varchar(25), @descripcion as varchar(60)
AS
BEGIN

INSERT INTO [Center].[tipoProducto]
VALUES (@id, @tipo, @descripcion)
END
GO
/****** Object:  StoredProcedure [dbo].[agregarUsuarios]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[agregarUsuarios] (
@id int,
@nombre varchar(25),
@apellido varchar(25),
@usuario varchar(25),
@contraseña varchar(25),
@correo varchar(25),
@rol int ,
@estado char(20) 
)

AS
BEGIN
if exists (select usuario from center.usuario where usuario = @usuario and estado='activo')
raiserror ('Ya existe un usuario con ese usuario, porfavor ingrese uno nuevo',16,1)
else
insert into center.usuario(id, nombre,apellido,usuario,contraseña,correo,rol,estado) 
values(@id, @nombre,@apellido,@usuario,@contraseña,@correo,@rol,@estado)
END
GO
/****** Object:  StoredProcedure [dbo].[BuscarEmpleado]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BuscarEmpleado](@identidad varchar(15))
	as
	begin
	if exists(select identidad from center.empleados where identidad = @Identidad and [Estado] = 'Activo')
	SELECT Center.empleados.identidad AS Identidad, Center.empleados.nombre AS Nombre, Center.empleados.direccion AS Direccion, Center.empleados.edad AS Edad,
	dbo.Puestos_Empleados.Nombre_Puesto AS Puesto, CONCAT(Center.marca.marca, ' ',Center.modelo.modelo ) AS Telefono , dbo.Tipo_Paquete.Nombre_Paquete AS Paquete
    FROM     Center.empleados INNER JOIN
                  dbo.Puestos_Empleados ON Center.empleados.Id_Puesto = dbo.Puestos_Empleados.Id_Puesto INNER JOIN
                  dbo.Telefonos_Empleados ON dbo.Puestos_Empleados.Id_Telefono = dbo.Telefonos_Empleados.Id_Telefono INNER JOIN
                  dbo.Tipo_Paquete ON dbo.Telefonos_Empleados.Tipo_Paquete = dbo.Tipo_Paquete.Id_Tipo_Paquete INNER JOIN
                  Center.modelo ON dbo.Telefonos_Empleados.Telefono = Center.modelo.id INNER JOIN
                  Center.marca ON Center.modelo.marca = Center.marca.id AND Center.modelo.marca = Center.marca.id AND
				  Center.modelo.marca = Center.marca.id AND Center.modelo.marca = Center.marca.id
				  Where identidad = @identidad
	end
GO
/****** Object:  StoredProcedure [dbo].[buscarMarca]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[buscarMarca] 
@marca as varchar(80) 
AS
BEGIN
SELECT id as 'Id Marca', marca as 'Marca' from [Center].[marca]
WHERE marca like '%' +@marca+ '%'
END
GO
/****** Object:  StoredProcedure [dbo].[buscarModelo]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[buscarModelo]
@modelo as varchar(80)
AS
BEGIN
SELECT id as 'Id Modelo', modelo as 'Modelo', marca as 'Id Marca' from [Center].[modelo]
WHERE modelo like '%' +@modelo+ '%'
END 
GO
/****** Object:  StoredProcedure [dbo].[buscarProducto]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarProducto]
@codigobarra as varchar(25)
AS
BEGIN

IF exists(SELECT [codigobarra] FROM [Center].[producto] WHERE [codigobarra] = @codigobarra)
	BEGIN
	SELECT [id] as 'ID', [codigobarra] as 'Codigo barra', [tipoproducto] as 'Tipo producto', [nombre] as 'Nombre producto', 
	[precio] as 'Precio', [precioventa] as 'Precio de venta', [cantidad] as 'Cantidad', [caracteristica] as 'Caracteristica',
	[estado] as 'Estado', [modelo] as 'Modelo' FROM [Center].[producto]
	WHERE [codigobarra] like '%' +@codigobarra+ '%'
	END

ELSE
	raiserror('No existe un producto con ese codigo',16,10)

END
GO
/****** Object:  StoredProcedure [dbo].[buscarUser]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[buscarUser]
@nombreUsuario as varchar(50)
as begin
select id as 'idUsuario',nombre as 'Nombre', apellido as 'Apellido', usuario as 'usuario',contraseña as 'Contraseña', correo as 'correo', rol as 'puesto',estado as 'estado' 
from center.usuario
where usuario like '%' +@nombreUsuario+ '%'

end 
GO
/****** Object:  StoredProcedure [dbo].[clientesconmasventas]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[clientesconmasventas]
as begin	
SELECT c.nombre AS [Nombre Cliente],c.apellido as 'Apellido cliente'  ,  COUNT(*) AS Total
FROM      Center.venta as v
INNER JOIN  Center.cliente as   c ON v.idcliente = c.[id]
GROUP BY c.nombre,c.apellido 
order by Total desc
end
GO
/****** Object:  StoredProcedure [dbo].[eliminarCliente]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[eliminarCliente] 
	@identidad as varchar (15)
	as begin 
	update center.cliente
		set estado = 'Eliminado'
		where identidad = @identidad
	end
GO
/****** Object:  StoredProcedure [dbo].[eliminardetalleventa]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[eliminardetalleventa]
@iddetalledeventa as int
as begin 
delete [Center].[detalleventa] where iddetalleventa=@iddetalledeventa
end
GO
/****** Object:  StoredProcedure [dbo].[eliminarEmpleado]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[eliminarEmpleado](@identidadEmpleado varchar(15))
	as
	begin
	if exists(select identidad, [Estado] from Center.empleados where identidad = @identidadEmpleado and [Estado]='Activo')
			update Center.empleados
		set [Estado] = 'Eliminado'
		where identidad = @identidadEmpleado
	else
		raiserror ('El Empleado no existe en la base de datos',16,1)
	end
GO
/****** Object:  StoredProcedure [dbo].[eliminarProducto]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[eliminarProducto]
@id as int, @codigobarra as varchar(25)
AS
BEGIN
UPDATE [Center].[producto]
SET [estado] = 'Eliminado'
WHERE [id] = @id and [codigobarra] = @codigobarra
END
GO
/****** Object:  StoredProcedure [dbo].[eliminarPuestosEmpleados]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[eliminarPuestosEmpleados]
	@id as int 
	as begin
		delete [dbo].[Puestos_Empleados]
		where [Id_Puesto] = @id
	end
GO
/****** Object:  StoredProcedure [dbo].[EmpleadoDelMes]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[EmpleadoDelMes]
AS
BEGIN

SELECT top 1 e.nombre, COUNT(*)AS total
FROM      [Center].[venta] as v 
INNER JOIN  [Center].[empleados] as   e ON v.idempleado = e.[IdCodigo]
GROUP BY e.nombre order by total desc


END
GO
/****** Object:  StoredProcedure [dbo].[extraerrol]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[extraerrol]
@nombreusuario as varchar(25)
as begin
select r.[rol] from [Center].[usuario] as u
inner join [Center].[rol] as r on r.[id]=u.[rol]
where u.[usuario]=@nombreusuario
end
GO
/****** Object:  StoredProcedure [dbo].[insertarCliente]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertarCliente]
    @identidad as varchar(15),@nombre as varchar(50), @numero as varchar(25), @apellido as varchar(50),@direccion as varchar(65)
	as begin
	insert into center.cliente(identidad,nombre,numero,apellido,direccion)
	values (@identidad,@nombre,@numero,@apellido,@direccion)
	end 
GO
/****** Object:  StoredProcedure [dbo].[insertarDetalleventa]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertarDetalleventa]
@iddetalledeventa as int,@idventa as int , @idproducto as int,@cantidad as int , @precio as decimal
as begin
insert into [Center].[detalleventa]([iddetalleventa],[idventa],[idProducto],[cantidad],[precio])
values(@iddetalledeventa,@idventa,@idproducto,@cantidad,@precio)
end
GO
/****** Object:  StoredProcedure [dbo].[insertarMarca]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[insertarMarca]
(@marca as varchar(80))  
AS
BEGIN
INSERT INTO [Center].[marca](marca)
VALUES(@marca)
END
GO
/****** Object:  StoredProcedure [dbo].[insertarModelo]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertarModelo]
@modelo as varchar(80), @marca as int
AS
BEGIN
INSERT INTO [Center].[modelo](modelo, marca)
VALUES( @modelo, @marca)
END
GO
/****** Object:  StoredProcedure [dbo].[insertarventas]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[insertarventas]
	@id as int, @idcliente as int, @idempleado as int, @fecha as date,@formadepago as int,@numeroFactura as int,@total as decimal
	as begin
	insert into [Center].[venta](id,idcliente,idempleado,fecha,formapago,numerofactura,total)
	values (@id,@idcliente,@idempleado,@fecha,@formadepago,@numeroFactura,@total)
	end
GO
/****** Object:  StoredProcedure [dbo].[instertarPuestosEmpleados]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[instertarPuestosEmpleados]
	@Nombre_Puesto as varchar (80), @Descripcion as varchar (80), @id_Telefono as int
	as begin
		insert into [dbo].[Puestos_Empleados](Nombre_Puesto, Descripción, Id_Telefono)
		values(@Nombre_Puesto , @Descripcion ,  @id_Telefono  )
	end

GO
/****** Object:  StoredProcedure [dbo].[llenargrid]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[llenargrid](
@idventa int
)
AS
BEGIN
select pr.[nombre] as 'Nombre Articulo', dv.cantidad as 'Cantidad', dv.precio,(dv.cantidad) * (dv.precio) as total   from [Center].[detalleventa] as dv
inner join [Center].[producto] as pr on [id]=[idProducto]
where idventa=@idventa
end
GO
/****** Object:  StoredProcedure [dbo].[ModificarCliente]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE procedure [dbo].[ModificarCliente]
    @identidad as varchar(15),@nombre as varchar(50),@numero as varchar(25), @apellido as varchar(50),@direccion as varchar(65)
	as begin
	update 
	center.cliente
	set
    nombre=@nombre,numero=@numero, apellido=@apellido,direccion=@direccion where identidad = @identidad
	end
GO
/****** Object:  StoredProcedure [dbo].[modificardetalleventa]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[modificardetalleventa]
@iddetalledeventa as int,@idventa as int , @idproducto as int,@cantidad as int , @precio as decimal
as begin
update [Center].[detalleventa]
set [idventa]=@idventa,[idProducto]=@idproducto,[cantidad]=@cantidad,[precio]=@precio
where [iddetalleventa]=@iddetalledeventa
end
GO
/****** Object:  StoredProcedure [dbo].[modificarMarca]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[modificarMarca]
 @id int, @marca as varchar(80)
AS
BEGIN
UPDATE [Center].[marca]
SET marca=@marca where id= @id
END
GO
/****** Object:  StoredProcedure [dbo].[modificarModelo]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[modificarModelo]
@id int, @modelo as varchar(80), @marca as int
AS
BEGIN
UPDATE [Center].[modelo]
SET modelo = @modelo, marca = @marca where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[modificarPuestosEmpleados]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[modificarPuestosEmpleados]
	@idPuesto as int, @Nombre_Puesto as varchar (80), @Descripcion as varchar (80), @id_Telefono as int
	as begin
		update [dbo].[Puestos_Empleados]
		set [Nombre_Puesto]=@Nombre_Puesto,[Descripción]=@Descripcion, [Id_Telefono]=@id_Telefono  where [Id_Puesto]= @idPuesto
	end
GO
/****** Object:  StoredProcedure [dbo].[modificarventa]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[modificarventa]
	@id as int, @idcliente as int, @idempleado as int, @fecha as date,@formadepago as int,@numeroFactura as int,@total as decimal
	as begin
	update [Center].[venta]
	set [idcliente]=@idcliente ,[idempleado]=@idempleado,[fecha]=@fecha,[formapago]=@formadepago,[numerofactura]=@numeroFactura,[total]=@total
	where [id]=@id
	end
GO
/****** Object:  StoredProcedure [dbo].[RegistrarEmpleado]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   create procedure [dbo].[RegistrarEmpleado](@IdCodigo int,@identidad varchar(15),@nombre varchar(50),
    @direccion varchar(60),@edad int,@sexo varchar(10),@Id_Puesto int)
	as
	begin
	if exists(select identidad, [Estado] from Center.empleados where identidad=@identidad and [Estado] = 'Activo' )
		raiserror('Este Empleado Ya existe',16,1)
	else if exists(select identidad, [Estado] from Center.empleados where identidad=@identidad and [Estado] = 'Eliminado' )
		update Center.empleados set [Estado] = 'Activo' where identidad = @identidad
	else
		insert into Center.empleados([IdCodigo],[identidad],[nombre],[direccion],[edad],[sexo],[Id_Puesto])
		values(@IdCodigo, @identidad, @nombre, @direccion, @edad, @sexo,@Id_Puesto)

	end
GO
/****** Object:  StoredProcedure [dbo].[validarusuario]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[validarusuario]
@username varchar(25),
@llave varchar(25)

as begin

if exists(select*from Center.usuario where [usuario]=@username and [contraseña]=@llave and [estado]='activo')

  PRINT N'Este usuario ha iniciado sesion.'

 
else if exists(select*from Center.usuario where [usuario]=@username and [contraseña]=@llave and [estado]<>'activo')

raiserror('el usuario esta inactivo',16,1)
 else 
  raiserror('Contraseña o Usuario no existe o no coinciden',16,1)
/*else if  exists(select*from Center.usuario where [usuario]<>@username and [contraseña]<>@llave and [estado]<>'activo')
raiserror('el usuario esta inactivo',16,1)*/
end
GO
/****** Object:  StoredProcedure [dbo].[VentasEmpleados]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[VentasEmpleados]
AS
BEGIN
SELECT e.nombre AS [Nombre Empleado], COUNT(*) AS Total
FROM      [Center].[venta] as v
INNER JOIN  [Center].[empleados] as   e ON v.idempleado = e.[IdCodigo]
GROUP BY e.nombre
END
GO
/****** Object:  Trigger [Center].[actualizarcantproductos]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [Center].[actualizarcantproductos]
on [Center].[detalleventa]
AFTER INSERT
AS BEGIN 
declare 
@idVenta as int , @cantidad as int,@precio as decimal,@total as decimal

select @cantidad=[cantidad] from inserted
select @idVenta=[idventa] from inserted
select @precio=[precio] from inserted
Set @total=@cantidad * @precio

update [Center].[venta]
set total =total + @total where [id]=@idVenta
end
GO
ALTER TABLE [Center].[detalleventa] ENABLE TRIGGER [actualizarcantproductos]
GO
/****** Object:  Trigger [Center].[aumentar_inventario]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  TRIGGER [Center].[aumentar_inventario]
ON [Center].[detalleventa]
AFTER delete
AS
BEGIN
	DECLARE @cantidad int, @id int
	SELECT @cantidad = cantidad, @id = idProducto from deleted
	update center.producto
	set
	cantidad = cantidad + @cantidad
	where id = @id
END
GO
ALTER TABLE [Center].[detalleventa] ENABLE TRIGGER [aumentar_inventario]
GO
/****** Object:  Trigger [Center].[devolverProducto]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [Center].[devolverProducto]
on [Center].[detalleventa]
AFTER delete
AS BEGIN 
declare 
@idVenta as int , @cantidad as int,@precio as decimal,@total as decimal

select @cantidad=[cantidad] from deleted
select @idVenta=[idventa] from deleted
select @precio=[precio] from deleted
Set @total=@cantidad * @precio

update [Center].[venta]
set total =total - @total where [id]=@idVenta
end
GO
ALTER TABLE [Center].[detalleventa] ENABLE TRIGGER [devolverProducto]
GO
/****** Object:  Trigger [Center].[DISMINUCION_INVENTARIO]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [Center].[DISMINUCION_INVENTARIO]
ON [Center].[detalleventa]
AFTER INSERT
AS
BEGIN
	DECLARE @cantidad int, @id int
	SELECT @cantidad = cantidad, @id = idProducto from inserted 
	update center.producto
	set
	cantidad = cantidad - @cantidad
	where id = @id
END
GO
ALTER TABLE [Center].[detalleventa] ENABLE TRIGGER [DISMINUCION_INVENTARIO]
GO
/****** Object:  Trigger [Center].[SALIDAS_k]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create TRIGGER [Center].[SALIDAS_k]
ON [Center].[detalleventa]
AFTER INSERT
AS
BEGIN
	DECLARE @id int, @idVenta int, @idProducto varchar(25), @cantidad int, @precio decimal
	SELECT @id = iddetalleventa, @idVenta = idventa, @idProducto = idProducto, @cantidad = cantidad, @precio = precio from inserted

	INSERT INTO Center.salidas( numeroventa, tipodeproceso, fecha, codigoproducto, cantidad, total)
	values( @idVenta,  'salida', getdate(), @idProducto, @cantidad, (@cantidad * @precio))
	
END
GO
ALTER TABLE [Center].[detalleventa] ENABLE TRIGGER [SALIDAS_k]
GO
/****** Object:  Trigger [Center].[ENTRADAS_KARDEX]    Script Date: 12/12/2020 12:34:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [Center].[ENTRADAS_KARDEX]
ON [Center].[producto]
AFTER INSERT
AS
BEGIN
    DECLARE @id int, @codigo varchar(25), @nombre varchar(25), @precioventa decimal, @cantidad int
    SELECT @id = id, @codigo = codigobarra, @nombre = nombre, @precioventa = precioventa, @cantidad = cantidad from inserted

    INSERT INTO center.entradas( codbarra, nombre, precioventa, cantidad, total)
    values(@codigo, @nombre, @precioventa, @cantidad, (@cantidad * @precioventa))
   
END
GO
ALTER TABLE [Center].[producto] ENABLE TRIGGER [ENTRADAS_KARDEX]
GO
USE [master]
GO
ALTER DATABASE [CompuCenter] SET  READ_WRITE 
GO