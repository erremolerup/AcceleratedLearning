USE [master]
GO
/****** Object:  Database [GnomeDb]    Script Date: 2019-01-11 09:58:55 ******/
CREATE DATABASE [GnomeDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GnomeDb', FILENAME = N'C:\Users\Administrator\GnomeDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GnomeDb_log', FILENAME = N'C:\Users\Administrator\GnomeDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [GnomeDb] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GnomeDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GnomeDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GnomeDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GnomeDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GnomeDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GnomeDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [GnomeDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GnomeDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GnomeDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GnomeDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GnomeDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GnomeDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GnomeDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GnomeDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GnomeDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GnomeDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GnomeDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GnomeDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GnomeDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GnomeDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GnomeDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GnomeDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GnomeDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GnomeDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GnomeDb] SET  MULTI_USER 
GO
ALTER DATABASE [GnomeDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GnomeDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GnomeDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GnomeDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GnomeDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GnomeDb] SET QUERY_STORE = OFF
GO
USE [GnomeDb]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [GnomeDb]
GO
/****** Object:  Table [dbo].[Gnome]    Script Date: 2019-01-11 09:58:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gnome](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Gnome] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Gnome] ON 

INSERT [dbo].[Gnome] ([Id], [Name]) VALUES (1, N'Nisse')
INSERT [dbo].[Gnome] ([Id], [Name]) VALUES (2, N'Kalle')
INSERT [dbo].[Gnome] ([Id], [Name]) VALUES (3, N'Pelle')
SET IDENTITY_INSERT [dbo].[Gnome] OFF
USE [master]
GO
ALTER DATABASE [GnomeDb] SET  READ_WRITE 
GO
