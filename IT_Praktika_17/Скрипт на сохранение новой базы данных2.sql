USE [master]
GO

/****** Object:  Database [AdventureWorks2016b]    Script Date: 27.04.2021 10:18:30 ******/
CREATE DATABASE [AdventureWorks2016b]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AdventureWorks2016b_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AdventureWorks2016b_Data.mdf' , SIZE = 212608KB , MAXSIZE = UNLIMITED, FILEGROWTH = 16384KB )
 LOG ON 
( NAME = N'AdventureWorks2016b_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AdventureWorks2016b_Log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 16384KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AdventureWorks2016b].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [AdventureWorks2016b] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [AdventureWorks2016b] SET ANSI_NULLS ON 
GO

ALTER DATABASE [AdventureWorks2016b] SET ANSI_PADDING ON 
GO

ALTER DATABASE [AdventureWorks2016b] SET ANSI_WARNINGS ON 
GO

ALTER DATABASE [AdventureWorks2016b] SET ARITHABORT ON 
GO

ALTER DATABASE [AdventureWorks2016b] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [AdventureWorks2016b] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [AdventureWorks2016b] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [AdventureWorks2016b] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [AdventureWorks2016b] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [AdventureWorks2016b] SET CONCAT_NULL_YIELDS_NULL ON 
GO

ALTER DATABASE [AdventureWorks2016b] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [AdventureWorks2016b] SET QUOTED_IDENTIFIER ON 
GO

ALTER DATABASE [AdventureWorks2016b] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [AdventureWorks2016b] SET  DISABLE_BROKER 
GO

ALTER DATABASE [AdventureWorks2016b] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [AdventureWorks2016b] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [AdventureWorks2016b] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [AdventureWorks2016b] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [AdventureWorks2016b] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [AdventureWorks2016b] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [AdventureWorks2016b] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [AdventureWorks2016b] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [AdventureWorks2016b] SET  MULTI_USER 
GO

ALTER DATABASE [AdventureWorks2016b] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [AdventureWorks2016b] SET DB_CHAINING OFF 
GO

ALTER DATABASE [AdventureWorks2016b] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [AdventureWorks2016b] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [AdventureWorks2016b] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [AdventureWorks2016b] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [AdventureWorks2016b] SET QUERY_STORE = OFF
GO

USE [AdventureWorks2016b]
GO

EXEC [AdventureWorks2016b].sys.sp_addextendedproperty @name=N'MS_Description', @value=N'AdventureWorks 2016 Sample OLTP Database' 
GO

USE [master]
GO

ALTER DATABASE [AdventureWorks2016b] SET  READ_WRITE 
GO


