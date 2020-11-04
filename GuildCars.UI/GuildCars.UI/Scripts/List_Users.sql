/****** Script for SelectTopNRows command from SSMS  ******/
SELECT anu.[Id]
      ,[Email]
      ,[EmailConfirmed]
      ,[PasswordHash]
      ,[SecurityStamp]
      ,[PhoneNumber]
      ,[PhoneNumberConfirmed]
      ,[TwoFactorEnabled]
      ,[LockoutEndDateUtc]
      ,[LockoutEnabled]
      ,[AccessFailedCount]
      ,[UserName]
      ,[FirstName]
      ,[LastName]
      ,[Level]
      ,[JoinDate]
	  ,[Role] = anr.Name
  FROM [GuildCars].[dbo].[AspNetUsers] anu
  Join [GuildCars].[dbo].[AspNetUserRoles] anur on anu.Id = anur.UserId
  join [GuildCars].[dbo].[AspNetRoles] anr on anur.RoleId = anr.Id
  Order by 1