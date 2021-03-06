USE [master]
GO
/****** Object:  Database [PruebaCarvajal]    Script Date: 02/20/2022 21:49:15 ******/
CREATE DATABASE [PruebaCarvajal] ON  PRIMARY 
( NAME = N'PruebaCarvajal', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\PruebaCarvajal.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PruebaCarvajal_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\PruebaCarvajal_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PruebaCarvajal] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PruebaCarvajal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PruebaCarvajal] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [PruebaCarvajal] SET ANSI_NULLS OFF
GO
ALTER DATABASE [PruebaCarvajal] SET ANSI_PADDING OFF
GO
ALTER DATABASE [PruebaCarvajal] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [PruebaCarvajal] SET ARITHABORT OFF
GO
ALTER DATABASE [PruebaCarvajal] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [PruebaCarvajal] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [PruebaCarvajal] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [PruebaCarvajal] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [PruebaCarvajal] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [PruebaCarvajal] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [PruebaCarvajal] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [PruebaCarvajal] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [PruebaCarvajal] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [PruebaCarvajal] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [PruebaCarvajal] SET  DISABLE_BROKER
GO
ALTER DATABASE [PruebaCarvajal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [PruebaCarvajal] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [PruebaCarvajal] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [PruebaCarvajal] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [PruebaCarvajal] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [PruebaCarvajal] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [PruebaCarvajal] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [PruebaCarvajal] SET  READ_WRITE
GO
ALTER DATABASE [PruebaCarvajal] SET RECOVERY SIMPLE
GO
ALTER DATABASE [PruebaCarvajal] SET  MULTI_USER
GO
ALTER DATABASE [PruebaCarvajal] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [PruebaCarvajal] SET DB_CHAINING OFF
GO
USE [PruebaCarvajal]
GO
/****** Object:  Table [dbo].[Vue_Vuelos]    Script Date: 02/20/2022 21:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vue_Vuelos](
	[Vue_Id] [int] IDENTITY(1,1) NOT NULL,
	[Ciu_Id_Origen] [int] NOT NULL,
	[Ciu_Id_Destino] [int] NOT NULL,
	[Vue_FechaSalida] [smalldatetime] NOT NULL,
	[Vue_FechaLlegada] [smalldatetime] NOT NULL,
	[Vue_NumeroVuelo] [int] NOT NULL,
	[Arl_Id] [int] NOT NULL,
	[Est_Id] [int] NOT NULL,
	[Usu_Id] [int] NOT NULL,
 CONSTRAINT [PK_Vue_Vuelos] PRIMARY KEY CLUSTERED 
(
	[Vue_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usu_Usuarios]    Script Date: 02/20/2022 21:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usu_Usuarios](
	[Usu_Id] [int] IDENTITY(1,1) NOT NULL,
	[Usu_Nombres] [nvarchar](300) NOT NULL,
	[Usu_Email] [nvarchar](300) NOT NULL,
	[Usu_Password] [nvarchar](300) NOT NULL,
	[Usu_Habilitado] [bit] NOT NULL,
	[Usu_FechaCreacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Usu_Ususarios] PRIMARY KEY CLUSTERED 
(
	[Usu_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Est_Estados]    Script Date: 02/20/2022 21:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Est_Estados](
	[Est_Id] [int] IDENTITY(1,1) NOT NULL,
	[Est_Nombre] [nvarchar](300) NOT NULL,
	[Est_hailitado] [bit] NOT NULL,
 CONSTRAINT [PK_Est_Estados] PRIMARY KEY CLUSTERED 
(
	[Est_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ciu_Ciudades]    Script Date: 02/20/2022 21:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciu_Ciudades](
	[Ciu_Id] [int] IDENTITY(1,1) NOT NULL,
	[Ciu_Nombre] [nvarchar](300) NOT NULL,
	[Ciu_Habilitado] [bit] NOT NULL,
 CONSTRAINT [PK_Ciu_Ciudades] PRIMARY KEY CLUSTERED 
(
	[Ciu_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Arl_Aerolinea]    Script Date: 02/20/2022 21:49:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Arl_Aerolinea](
	[Alr_Id] [int] IDENTITY(1,1) NOT NULL,
	[Alr_Nombre] [nvarchar](300) NOT NULL,
	[Alr_Habilitada] [bit] NOT NULL,
 CONSTRAINT [PK_Arl_Aerolinea] PRIMARY KEY CLUSTERED 
(
	[Alr_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_GetEstados]    Script Date: 02/20/2022 21:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_GetEstados]
as
select * from Est_Estados where Est_hailitado='1'
GO
/****** Object:  StoredProcedure [dbo].[sp_GetCiudades]    Script Date: 02/20/2022 21:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_GetCiudades]
as
select * from Ciu_Ciudades where Ciu_Habilitado='1'
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAerolineas]    Script Date: 02/20/2022 21:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_GetAerolineas]
as
select * from Arl_Aerolinea where Alr_Habilitada='1'
GO
/****** Object:  StoredProcedure [dbo].[sp_Add_Vuelos]    Script Date: 02/20/2022 21:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Add_Vuelos]
@Ciu_Id_Origen int, 
@Ciu_Id_Destino int,
@Vue_FechaSalida smalldatetime,
@Vue_FechaLlegada smalldatetime,
@Arl_Id int,
@Est_Id int,
@Usu_Id int
as
declare @Vue_NumeroVuelo int
select @Vue_NumeroVuelo=ISNULL(MAX(Vue_NumeroVuelo),0)+1 from Vue_Vuelos where Usu_Id=@Usu_Id
insert into Vue_Vuelos(Ciu_Id_Origen, Ciu_Id_Destino, Vue_FechaSalida, Vue_FechaLlegada,
Vue_NumeroVuelo, Arl_Id, Est_Id, Usu_Id)
values(@Ciu_Id_Origen, @Ciu_Id_Destino, @Vue_FechaSalida, @Vue_FechaLlegada, @Vue_NumeroVuelo,
@Arl_Id, @Est_Id, @Usu_Id)
GO
/****** Object:  StoredProcedure [dbo].[sp_Add_Usuario]    Script Date: 02/20/2022 21:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Add_Usuario]
@Usu_Nombres nvarchar(600), 
@Usu_Email nvarchar(600),
@Usu_Password nvarchar(600),
@Usu_Habilitado bit,
@Usu_FechaCreacion smalldatetime
as
insert into Usu_Usuarios(Usu_Nombres, Usu_Email, Usu_Password, Usu_Habilitado, Usu_FechaCreacion)
values(@Usu_Nombres, @Usu_Email, @Usu_Password, @Usu_Habilitado, @Usu_FechaCreacion)
GO
/****** Object:  StoredProcedure [dbo].[sp_Add_Estados]    Script Date: 02/20/2022 21:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Add_Estados]
@Est_Nombre nvarchar(600), 
@Est_hailitado bit
as
insert into Est_Estados(Est_Nombre, Est_hailitado)
values(@Est_Nombre, @Est_hailitado)
GO
/****** Object:  StoredProcedure [dbo].[sp_Add_Ciudades]    Script Date: 02/20/2022 21:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Add_Ciudades]
@Ciu_Nombre nvarchar(600), 
@Ciu_Habilitada bit
as
insert into Ciu_Ciudades(Ciu_Nombre, Ciu_Habilitado)
values(@Ciu_Nombre, @Ciu_Habilitada)
GO
/****** Object:  StoredProcedure [dbo].[sp_Add_Aerolinea]    Script Date: 02/20/2022 21:49:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Add_Aerolinea]
@Alr_Nombre nvarchar(600), 
@Alr_Habilitada bit
as
insert into Arl_Aerolinea(Alr_Nombre, Alr_Habilitada)
values(@Alr_Nombre, @Alr_Habilitada)
GO
/****** Object:  View [dbo].[vw_VuelosDetalles]    Script Date: 02/20/2022 21:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_VuelosDetalles]
AS
SELECT     vue.Vue_Id AS Vuelo_ID, vue.Vue_FechaLlegada AS Fecha_Llegada, vue.Vue_FechaSalida AS Fecha_Salida, vue.Vue_NumeroVuelo AS Numero_Vuelo, arl.Alr_Nombre AS Aerolinea_Nombre, 
                      ciu_origen.Ciu_Nombre AS Ciudad_Origen, est.Est_Nombre AS Estado_Vuelo, usu.Usu_Nombres AS Usuario_Nombre, ciu_destino.Ciu_Nombre AS Ciudad_Destino
FROM         dbo.Vue_Vuelos AS vue INNER JOIN
                      dbo.Arl_Aerolinea AS arl ON arl.Alr_Id = vue.Arl_Id INNER JOIN
                      dbo.Est_Estados AS est ON est.Est_Id = vue.Est_Id INNER JOIN
                      dbo.Ciu_Ciudades AS ciu_origen ON ciu_origen.Ciu_Id = vue.Ciu_Id_Origen INNER JOIN
                      dbo.Ciu_Ciudades AS ciu_destino ON ciu_destino.Ciu_Id = vue.Ciu_Id_Destino INNER JOIN
                      dbo.Usu_Usuarios AS usu ON usu.Usu_Id = vue.Usu_Id
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "vue"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "arl"
            Begin Extent = 
               Top = 6
               Left = 274
               Bottom = 111
               Right = 472
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "est"
            Begin Extent = 
               Top = 114
               Left = 274
               Bottom = 219
               Right = 472
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ciu_origen"
            Begin Extent = 
               Top = 126
               Left = 38
               Bottom = 231
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ciu_destino"
            Begin Extent = 
               Top = 222
               Left = 274
               Bottom = 327
               Right = 472
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "usu"
            Begin Extent = 
               Top = 234
               Left = 38
               Bottom = 354
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 1545' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_VuelosDetalles'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_VuelosDetalles'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_VuelosDetalles'
GO
/****** Object:  StoredProcedure [dbo].[sp_ValidarUsuario]    Script Date: 02/20/2022 21:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_ValidarUsuario]
@Usu_Email nvarchar(600),
@Usu_Password nvarchar(600)
as
select * from Usu_Usuarios where Usu_Email=@Usu_Email and Usu_Password=@Usu_Password and Usu_Habilitado='1'
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateVuelo]    Script Date: 02/20/2022 21:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_UpdateVuelo]
@Vuelo_ID int, 
@Fecha_Llegada smalldatetime,
@Fecha_Salida smalldatetime,
@Aerolinea_Nombre nvarchar(600),
@Ciudad_Origen nvarchar(600),
@Estado_Vuelo nvarchar(600),
@Ciudad_Destino nvarchar(600)
as
declare @Aerolinea_Id int,
		@Ciudad_Origen_Id int,
		@Estado_Vuelo_Id int,
		@Ciudad_Destino_Id int

select @Aerolinea_Id=Alr_Id from Arl_Aerolinea where Alr_Nombre=@Aerolinea_Nombre
select @Ciudad_Origen_Id=Ciu_Id from Ciu_Ciudades where Ciu_Nombre=@Ciudad_Origen
select @Ciudad_Destino_Id=Ciu_Id from Ciu_Ciudades where Ciu_Nombre=@Ciudad_Destino
select @Estado_Vuelo_Id=Est_Id from Est_Estados where Est_Nombre=@Estado_Vuelo

update Vue_Vuelos set
Arl_Id=@Aerolinea_Id,
Ciu_Id_Origen=@Ciudad_Origen_Id,
Ciu_Id_Destino=@Ciudad_Destino_Id,
Vue_FechaLlegada=@Fecha_Llegada,
Vue_FechaSalida=@Fecha_Salida,
Est_Id=@Estado_Vuelo_Id
where Vue_Id=@Vuelo_ID
GO
/****** Object:  StoredProcedure [dbo].[sp_GetVuelos]    Script Date: 02/20/2022 21:49:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_GetVuelos]
as
select * from vw_VuelosDetalles
GO
