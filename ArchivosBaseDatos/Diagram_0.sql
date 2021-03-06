/*
   viernes, 18 de septiembre de 20202:48:30
   Usuario: 
   Servidor: DESKTOP-5LA27IQ\SQLEXPRESS
   Base de datos: Makers
   Aplicación: 
*/

/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Cliente
	(
	IdCliente int NOT NULL IDENTITY (1, 1),
	Identificacion int NULL,
	Nombres nvarchar(100) NULL,
	Apellidos nvarchar(100) NULL,
	DireccionEnvio nvarchar(200) NULL,
	TelefonoFijo nvarchar(30) NULL,
	Celular nvarchar(30) NULL,
	Email nvarchar(30) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Cliente ADD CONSTRAINT
	PK_Cliente PRIMARY KEY CLUSTERED 
	(
	IdCliente
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Cliente SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Cliente', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Cliente', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Cliente', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Empleado
	(
	IdEmpleado int NOT NULL IDENTITY (1, 1),
	Nombres nvarchar(100) NULL,
	Apellidos nvarchar(100) NULL,
	Direccion nvarchar(200) NULL,
	TelefonoFijo nvarchar(30) NULL,
	Celular nvarchar(30) NULL,
	Cargo nvarchar(30) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Empleado ADD CONSTRAINT
	PK_Empleado PRIMARY KEY CLUSTERED 
	(
	IdEmpleado
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Empleado SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Empleado', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Empleado', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Empleado', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Editorial
	(
	IdEditorial int NOT NULL IDENTITY (1, 1),
	Nombre nvarchar(200) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Editorial ADD CONSTRAINT
	PK_Editorial PRIMARY KEY CLUSTERED 
	(
	IdEditorial
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Editorial SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Editorial', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Editorial', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Editorial', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Libro
	(
	IdLibro int NOT NULL IDENTITY (1, 1),
	Titulo nvarchar(200) NULL,
	IdEditorial int NULL,
	Fecha date NULL,
	Costo decimal(18, 2) NULL,
	PrecioSugerido decimal(18, 2) NULL,
	Autor nchar(10) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Libro ADD CONSTRAINT
	PK_Libro PRIMARY KEY CLUSTERED 
	(
	IdLibro
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Libro ADD CONSTRAINT
	FK_Libro_Editorial FOREIGN KEY
	(
	IdEditorial
	) REFERENCES dbo.Editorial
	(
	IdEditorial
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Libro SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Libro', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Libro', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Libro', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Compra
	(
	IdCompra int NOT NULL IDENTITY (1, 1),
	IdLibro int NULL,
	IdCliente int NULL,
	Fecha datetime NULL,
	Valor decimal(18, 2) NULL,
	IdEmpleado int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Compra ADD CONSTRAINT
	PK_Compra PRIMARY KEY CLUSTERED 
	(
	IdCompra
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Compra ADD CONSTRAINT
	FK_Compra_Libro FOREIGN KEY
	(
	IdLibro
	) REFERENCES dbo.Libro
	(
	IdLibro
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Compra ADD CONSTRAINT
	FK_Compra_Empleado FOREIGN KEY
	(
	IdEmpleado
	) REFERENCES dbo.Empleado
	(
	IdEmpleado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Compra ADD CONSTRAINT
	FK_Compra_Cliente FOREIGN KEY
	(
	IdCliente
	) REFERENCES dbo.Cliente
	(
	IdCliente
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Compra SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Compra', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Compra', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Compra', 'Object', 'CONTROL') as Contr_Per 