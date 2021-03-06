USE [Alumno]
GO
/****** Object:  Table [dbo].[Tabla]    Script Date: 05/22/2019 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tabla](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreAlumno] [varchar](50) NOT NULL,
	[ApellidoAlumno] [varchar](50) NOT NULL,
	[CalificacionAlumno] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Tabla] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Tabla] ON
INSERT [dbo].[Tabla] ([Id], [NombreAlumno], [ApellidoAlumno], [CalificacionAlumno], [Fecha]) VALUES (11, N'Josue', N'Mireles', 80, CAST(0x0000AA5500000000 AS DateTime))
INSERT [dbo].[Tabla] ([Id], [NombreAlumno], [ApellidoAlumno], [CalificacionAlumno], [Fecha]) VALUES (12, N'Angela', N'Rubí', 100, CAST(0x0000AA5400000000 AS DateTime))
INSERT [dbo].[Tabla] ([Id], [NombreAlumno], [ApellidoAlumno], [CalificacionAlumno], [Fecha]) VALUES (13, N'Abel', N'Galindo', 70, CAST(0x0000AA5400000000 AS DateTime))
INSERT [dbo].[Tabla] ([Id], [NombreAlumno], [ApellidoAlumno], [CalificacionAlumno], [Fecha]) VALUES (14, N'Abigail', N'Ledezma', 100, CAST(0x0000AA5400000000 AS DateTime))
INSERT [dbo].[Tabla] ([Id], [NombreAlumno], [ApellidoAlumno], [CalificacionAlumno], [Fecha]) VALUES (16, N'Adrian', N'Campos', 80, CAST(0x0000AA5500000000 AS DateTime))
INSERT [dbo].[Tabla] ([Id], [NombreAlumno], [ApellidoAlumno], [CalificacionAlumno], [Fecha]) VALUES (17, N'Vladimir', N'Medina', 80, CAST(0x0000AA5600000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[Tabla] OFF
