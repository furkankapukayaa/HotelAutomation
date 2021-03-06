USE [master]
GO
/****** Object:  Database [dbFurkanOtel]    Script Date: 16.04.2021 16:24:31 ******/
CREATE DATABASE [dbFurkanOtel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbFurkanOtel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dbFurkanOtel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbFurkanOtel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dbFurkanOtel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbFurkanOtel] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbFurkanOtel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbFurkanOtel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbFurkanOtel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbFurkanOtel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbFurkanOtel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbFurkanOtel] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbFurkanOtel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbFurkanOtel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbFurkanOtel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbFurkanOtel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbFurkanOtel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbFurkanOtel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbFurkanOtel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbFurkanOtel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbFurkanOtel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbFurkanOtel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbFurkanOtel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbFurkanOtel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbFurkanOtel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbFurkanOtel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbFurkanOtel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbFurkanOtel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbFurkanOtel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbFurkanOtel] SET RECOVERY FULL 
GO
ALTER DATABASE [dbFurkanOtel] SET  MULTI_USER 
GO
ALTER DATABASE [dbFurkanOtel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbFurkanOtel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbFurkanOtel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbFurkanOtel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbFurkanOtel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbFurkanOtel] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbFurkanOtel', N'ON'
GO
ALTER DATABASE [dbFurkanOtel] SET QUERY_STORE = OFF
GO
USE [dbFurkanOtel]
GO
/****** Object:  Table [dbo].[tblMusteri]    Script Date: 16.04.2021 16:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMusteri](
	[musteriid] [int] IDENTITY(1,1) NOT NULL,
	[musteritc] [nvarchar](50) NULL,
	[musteriadsoyad] [nvarchar](50) NULL,
	[musterimail] [nvarchar](50) NULL,
	[musteritelefon] [nvarchar](50) NULL,
	[musteriarac] [nvarchar](50) NULL,
	[musterigiristarih] [date] NULL,
	[mustericikistarih] [date] NULL,
	[musteriodano] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblMusteri] PRIMARY KEY CLUSTERED 
(
	[musteriid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblOda]    Script Date: 16.04.2021 16:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOda](
	[odaid] [int] IDENTITY(1,1) NOT NULL,
	[odaad] [nvarchar](50) NULL,
	[odatur] [nvarchar](50) NULL,
	[odakisisayisi] [nvarchar](50) NULL,
	[odaaciklama] [nvarchar](250) NULL,
	[odadurum] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblOda] PRIMARY KEY CLUSTERED 
(
	[odaid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSatis]    Script Date: 16.04.2021 16:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSatis](
	[satisid] [int] IDENTITY(1,1) NOT NULL,
	[satisadsoyad] [nvarchar](50) NULL,
	[satisodaadi] [nvarchar](50) NULL,
	[satisfiyat] [nvarchar](50) NULL,
	[satisodendimi] [nvarchar](50) NULL,
	[satisodemeyontemi] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblSatis] PRIMARY KEY CLUSTERED 
(
	[satisid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUye]    Script Date: 16.04.2021 16:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUye](
	[uyeid] [int] IDENTITY(1,1) NOT NULL,
	[uyeadsoyad] [nvarchar](50) NULL,
	[uyekullaniciadi] [nvarchar](50) NULL,
	[uyesifre] [nvarchar](50) NULL,
	[uyeyetki] [nvarchar](50) NULL,
	[uyemail] [nvarchar](50) NULL,
	[uyetelefon] [nvarchar](50) NULL,
	[uyefotograf] [nvarchar](500) NULL,
 CONSTRAINT [PK_tblUye] PRIMARY KEY CLUSTERED 
(
	[uyeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblOda] ADD  CONSTRAINT [DF_tblOda_odadurum]  DEFAULT (N'Boş') FOR [odadurum]
GO
USE [master]
GO
ALTER DATABASE [dbFurkanOtel] SET  READ_WRITE 
GO
