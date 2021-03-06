USE [master]
GO
/****** Object:  Database [Aplikasi_Laundry]    Script Date: 12/03/2020 13.15.59 ******/
CREATE DATABASE [Aplikasi_Laundry]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Aplikasi_Laundry', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Aplikasi_Laundry.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Aplikasi_Laundry_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Aplikasi_Laundry_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Aplikasi_Laundry] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Aplikasi_Laundry].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Aplikasi_Laundry] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Aplikasi_Laundry] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Aplikasi_Laundry] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Aplikasi_Laundry] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Aplikasi_Laundry] SET ARITHABORT OFF 
GO
ALTER DATABASE [Aplikasi_Laundry] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Aplikasi_Laundry] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Aplikasi_Laundry] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Aplikasi_Laundry] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Aplikasi_Laundry] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Aplikasi_Laundry] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Aplikasi_Laundry] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Aplikasi_Laundry] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Aplikasi_Laundry] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Aplikasi_Laundry] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Aplikasi_Laundry] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Aplikasi_Laundry] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Aplikasi_Laundry] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Aplikasi_Laundry] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Aplikasi_Laundry] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Aplikasi_Laundry] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Aplikasi_Laundry] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Aplikasi_Laundry] SET RECOVERY FULL 
GO
ALTER DATABASE [Aplikasi_Laundry] SET  MULTI_USER 
GO
ALTER DATABASE [Aplikasi_Laundry] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Aplikasi_Laundry] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Aplikasi_Laundry] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Aplikasi_Laundry] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Aplikasi_Laundry] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Aplikasi_Laundry', N'ON'
GO
ALTER DATABASE [Aplikasi_Laundry] SET QUERY_STORE = OFF
GO
USE [Aplikasi_Laundry]
GO
/****** Object:  Table [dbo].[detail_transaksi]    Script Date: 12/03/2020 13.16.07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detail_transaksi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_transaksi] [int] NULL,
	[id_paket] [int] NULL,
	[qty] [varchar](50) NULL,
	[keterangan] [text] NULL,
 CONSTRAINT [PK_detail_transaksi] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[member]    Script Date: 12/03/2020 13.16.07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[member](
	[id_member] [int] IDENTITY(1,1) NOT NULL,
	[nama] [varchar](100) NULL,
	[alamat] [text] NULL,
	[jenis_kelamin] [varchar](5) NULL,
	[no_hp] [varchar](15) NULL,
 CONSTRAINT [PK_member] PRIMARY KEY CLUSTERED 
(
	[id_member] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[outlet]    Script Date: 12/03/2020 13.16.07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[outlet](
	[id_outlet] [int] IDENTITY(1,1) NOT NULL,
	[nama] [varchar](100) NULL,
	[alamat] [text] NULL,
	[no_hp] [varchar](15) NULL,
 CONSTRAINT [PK_outlet] PRIMARY KEY CLUSTERED 
(
	[id_outlet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[paket]    Script Date: 12/03/2020 13.16.07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paket](
	[id_paket] [int] IDENTITY(1,1) NOT NULL,
	[id_outlet] [int] NULL,
	[jenis] [varchar](50) NULL,
	[nama_paket] [varchar](50) NULL,
	[harga] [int] NULL,
 CONSTRAINT [PK_paket] PRIMARY KEY CLUSTERED 
(
	[id_paket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaksi]    Script Date: 12/03/2020 13.16.07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaksi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_outlet] [int] NULL,
	[kode_invoice] [varchar](100) NULL,
	[id_member] [int] NULL,
	[tgl] [datetime] NULL,
	[batas_waktu] [datetime] NULL,
	[tgl_bayar] [datetime] NULL,
	[biaya_tambahan] [int] NULL,
	[diskon] [varchar](100) NULL,
	[pajak] [int] NULL,
	[status] [varchar](50) NULL,
	[dibayar] [varchar](50) NULL,
	[id_user] [int] NULL,
 CONSTRAINT [PK_Transaksi] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 12/03/2020 13.16.07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[nama] [varchar](50) NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[id_outlet] [int] NULL,
	[role] [varchar](30) NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Aplikasi_Laundry] SET  READ_WRITE 
GO
