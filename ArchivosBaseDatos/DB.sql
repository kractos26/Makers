USE [Makers]
GO
/****** Object:  StoredProcedure [dbo].[SP_TotalVentas]    Script Date: 18/09/2020 4:13:45 ******/
DROP PROCEDURE [dbo].[SP_TotalVentas]
GO
ALTER TABLE [dbo].[Libro] DROP CONSTRAINT [FK_Libro_Editorial]
GO
ALTER TABLE [dbo].[Compra] DROP CONSTRAINT [FK_Compra_Libro]
GO
ALTER TABLE [dbo].[Compra] DROP CONSTRAINT [FK_Compra_Empleado]
GO
ALTER TABLE [dbo].[Compra] DROP CONSTRAINT [FK_Compra_Cliente]
GO
/****** Object:  Table [dbo].[Libro]    Script Date: 18/09/2020 4:13:45 ******/
DROP TABLE [dbo].[Libro]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 18/09/2020 4:13:45 ******/
DROP TABLE [dbo].[Empleado]
GO
/****** Object:  Table [dbo].[Editorial]    Script Date: 18/09/2020 4:13:45 ******/
DROP TABLE [dbo].[Editorial]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 18/09/2020 4:13:45 ******/
DROP TABLE [dbo].[Compra]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 18/09/2020 4:13:45 ******/
DROP TABLE [dbo].[Cliente]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 18/09/2020 4:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Identificacion] [int] NULL,
	[Nombres] [nvarchar](100) NULL,
	[Apellidos] [nvarchar](100) NULL,
	[DireccionEnvio] [nvarchar](200) NULL,
	[TelefonoFijo] [nvarchar](30) NULL,
	[Celular] [nvarchar](30) NULL,
	[Email] [nvarchar](30) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Compra]    Script Date: 18/09/2020 4:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[IdCompra] [int] IDENTITY(1,1) NOT NULL,
	[IdLibro] [int] NULL,
	[IdCliente] [int] NULL,
	[Fecha] [datetime] NULL,
	[Valor] [decimal](18, 2) NULL,
	[IdEmpleado] [int] NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[IdCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Editorial]    Script Date: 18/09/2020 4:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Editorial](
	[IdEditorial] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](200) NULL,
 CONSTRAINT [PK_Editorial] PRIMARY KEY CLUSTERED 
(
	[IdEditorial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 18/09/2020 4:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [nvarchar](100) NULL,
	[Apellidos] [nvarchar](100) NULL,
	[Direccion] [nvarchar](200) NULL,
	[TelefonoFijo] [nvarchar](30) NULL,
	[Celular] [nvarchar](30) NULL,
	[Cargo] [nvarchar](30) NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Libro]    Script Date: 18/09/2020 4:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libro](
	[IdLibro] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [nvarchar](200) NULL,
	[IdEditorial] [int] NULL,
	[Fecha] [date] NULL,
	[Costo] [decimal](18, 2) NULL,
	[PrecioSugerido] [decimal](18, 2) NULL,
	[Autor] [nchar](10) NULL,
 CONSTRAINT [PK_Libro] PRIMARY KEY CLUSTERED 
(
	[IdLibro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Cliente]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Empleado] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Empleado]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Libro] FOREIGN KEY([IdLibro])
REFERENCES [dbo].[Libro] ([IdLibro])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Libro]
GO
ALTER TABLE [dbo].[Libro]  WITH CHECK ADD  CONSTRAINT [FK_Libro_Editorial] FOREIGN KEY([IdEditorial])
REFERENCES [dbo].[Editorial] ([IdEditorial])
GO
ALTER TABLE [dbo].[Libro] CHECK CONSTRAINT [FK_Libro_Editorial]
GO
/****** Object:  StoredProcedure [dbo].[SP_TotalVentas]    Script Date: 18/09/2020 4:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_TotalVentas] 
	@Anio int
AS
BEGIN
	SELECT concat(em.Nombres,' ',em.Apellidos) as NombreCompleto ,	sum(cp.Valor) as ValorTotalVentas FROM Empleado em	LEFT JOIN Compra cp ON em.IdEmpleado = cp.IdCompra	WHERE YEAR(cp.Fecha) = @Anio	GROUP BY em.Nombres,em.Apellidos 
END

GO
