EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'GuildCars'
GO
use [GuildCars];
GO
use [master];
GO
ALTER DATABASE [GuildCars] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
GO
USE [master]
GO
IF EXISTS(SELECT * FROM sys.databases WHERE name='GuildCars')
DROP DATABASE GuildCars
GO

CREATE DATABASE GuildCars
GO