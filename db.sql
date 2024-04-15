USE [master]
GO

/****** Object:  Database [QL_NhaSach]    Script Date: 2024-04-13 10:27:22 AM ******/
CREATE DATABASE [QL_NhaSach]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_NhaSach', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS02\MSSQL\DATA\QL_NhaSach.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QL_NhaSach_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS02\MSSQL\DATA\QL_NhaSach_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_NhaSach].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [QL_NhaSach] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [QL_NhaSach] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [QL_NhaSach] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [QL_NhaSach] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [QL_NhaSach] SET ARITHABORT OFF 
GO

ALTER DATABASE [QL_NhaSach] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [QL_NhaSach] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [QL_NhaSach] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [QL_NhaSach] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [QL_NhaSach] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [QL_NhaSach] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [QL_NhaSach] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [QL_NhaSach] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [QL_NhaSach] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [QL_NhaSach] SET  DISABLE_BROKER 
GO

ALTER DATABASE [QL_NhaSach] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [QL_NhaSach] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [QL_NhaSach] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [QL_NhaSach] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [QL_NhaSach] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [QL_NhaSach] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [QL_NhaSach] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [QL_NhaSach] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [QL_NhaSach] SET  MULTI_USER 
GO

ALTER DATABASE [QL_NhaSach] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [QL_NhaSach] SET DB_CHAINING OFF 
GO

ALTER DATABASE [QL_NhaSach] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [QL_NhaSach] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [QL_NhaSach] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [QL_NhaSach] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [QL_NhaSach] SET QUERY_STORE = ON
GO

ALTER DATABASE [QL_NhaSach] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO

ALTER DATABASE [QL_NhaSach] SET  READ_WRITE 
GO

