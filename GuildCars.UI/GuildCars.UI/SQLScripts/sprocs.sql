USE [GuildCars]
GO
/****** Object:  StoredProcedure [dbo].[usp_UsedInventoryCars]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_UsedInventoryCars]
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateVehicle]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_UpdateVehicle]
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateUser]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_UpdateUser]
GO
/****** Object:  StoredProcedure [dbo].[usp_SearchAllCars]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_SearchAllCars]
GO
/****** Object:  StoredProcedure [dbo].[usp_NewPurchase]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_NewPurchase]
GO
/****** Object:  StoredProcedure [dbo].[usp_NewInventoryCars]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_NewInventoryCars]
GO
/****** Object:  StoredProcedure [dbo].[usp_GuildCars_Reset]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_GuildCars_Reset]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetYears]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_GetYears]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetVehicleById]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_GetVehicleById]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetUsers]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_GetUsers]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetUserById]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_GetUserById]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetStates]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_GetStates]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetSpecials]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_GetSpecials]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetSalesUsers]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_GetSalesUsers]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetSalesResults]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_GetSalesResults]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetModels]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_GetModels]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetMakesByModel]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_GetMakesByModel]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetMakes]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_GetMakes]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetIntColors]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_GetIntColors]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetFilteredModels]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_GetFilteredModels]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetFeatured]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_GetFeatured]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetExtColors]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_GetExtColors]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetDetails]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_GetDetails]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetBodyStyles]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_GetBodyStyles]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllCars]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_GetAllCars]
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteVehicle]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_DeleteVehicle]
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteSpecial]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_DeleteSpecial]
GO
/****** Object:  StoredProcedure [dbo].[usp_ContactForm]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_ContactForm]
GO
/****** Object:  StoredProcedure [dbo].[usp_Cars_forSale]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_Cars_forSale]
GO
/****** Object:  StoredProcedure [dbo].[usp_AddUsers]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_AddUsers]
GO
/****** Object:  StoredProcedure [dbo].[usp_AddSpecial]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_AddSpecial]
GO
/****** Object:  StoredProcedure [dbo].[usp_AddNewCar]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_AddNewCar]
GO
/****** Object:  StoredProcedure [dbo].[usp_AddModel]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_AddModel]
GO
/****** Object:  StoredProcedure [dbo].[usp_AddMake]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[usp_AddMake]
GO
/****** Object:  StoredProcedure [dbo].[rpt_VehiclesInStock]    Script Date: 11/4/2020 8:57:25 AM ******/
DROP PROCEDURE [dbo].[rpt_VehiclesInStock]
GO
/****** Object:  StoredProcedure [dbo].[rpt_VehiclesInStock]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[rpt_VehiclesInStock]
AS
BEGIN
	SET NOCOUNT ON;
SELECT  [cfs_id]
      ,[cfs_cm_id]
      ,[cfs_year]
      ,[cfs_type]
      ,[cfs_body_style]
      ,[cfs_cccatid]
      ,[cfs_msrp]
      ,[cfs_saleprice]
      ,[cfs_vin]
      ,[cfs_ext_color]
      ,[cfs_int_color]
      ,[cfs_transmission]
      ,[cfs_mileage]
      ,[cfs_description]
      ,[cfs_photo_name]
      ,[cfs_photo]
      ,[cfs_feature]
      ,[cfs_sold]
  FROM [GuildCars].[dbo].[CarsForSale]
  Where cfs_sold = 0
END
GO
/****** Object:  StoredProcedure [dbo].[usp_AddMake]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_AddMake](
   @MakeName CHAR(100)
)
AS
   begin

   
   INSERT INTO  [GuildCars].[dbo].[CarMakes](cmk_make,cmk_date_added, cmk_updated_by) 
   VALUES (@MAkeName,GetDate(),'twhitehouse' )
   
 end
GO
/****** Object:  StoredProcedure [dbo].[usp_AddModel]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_AddModel](
   @ModelName CHAR(100),
   @MakeId int,
   @MakeName CHAR(100)
)
AS
   begin

   
   INSERT INTO  [GuildCars].[dbo].[CarModels]           
			([cm_model]
           ,[cm_makeId]
           ,[cm_makeName]
           ,[cm_date_added]
           ,[cm_updated_by])
   VALUES (@ModelName, @MakeId, @MakeName , GetDate(),'twhitehouse' )
   
 end
GO
/****** Object:  StoredProcedure [dbo].[usp_AddNewCar]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_AddNewCar]
@MakeId int, 
@ModelId int,
@Yr int, 
@Type int, 
@BodyStyle varchar(25), 
@Msrp decimal(10,2), 
@SalePrice decimal(10,2), 
@Vin varchar(18), 
@ExtColor varchar(25), 
@intColor varchar(25), 
@Trans varchar(25), 
@Mileage int, 
@Desc varchar(200), 
@ImageName varchar(50) = null

AS
BEGIN
	SET NOCOUNT ON;

   INSERT INTO  [GuildCars].[dbo].[CarsForSale]( [cfs_cm_id],[cfs_modelid],[cfs_year],[cfs_type],[cfs_body_style],[cfs_msrp]
   ,[cfs_saleprice],[cfs_vin],[cfs_ext_color],[cfs_int_color],[cfs_transmission],[cfs_mileage],[cfs_description],[cfs_photo_name]
   ,[cfs_photo],[cfs_sold])
   VALUES (@MakeId, @ModelId,@Yr, @Type, @BodyStyle, @Msrp, @SalePrice, @Vin, @ExtColor, @intColor, @Trans, @Mileage, @Desc, @ImageName,'/images/DefaultDesk_Style_SEDAN.png',0)

END
GO
/****** Object:  StoredProcedure [dbo].[usp_AddSpecial]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_AddSpecial]
@Title varchar(50),
@Description varchar(1000),
@imagefilename varchar(50) = '/Images/DefaultDesk_Style_COUPE.png'

AS
BEGIN
	SET NOCOUNT ON;

   INSERT INTO  [GuildCars].[dbo].[Specials]([s_title],[s_description],[s_imagefilename],[s_startdate],[s_enddate])
   VALUES (@Title, @Description, @imagefilename,GetDate(), GetDate())

END
GO
/****** Object:  StoredProcedure [dbo].[usp_AddUsers]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_AddUsers](
   @FName CHAR(100),
   @LName CHAR(100),
   @Email CHAR(256),
   @RoleId INT
)
AS
   begin

   Declare @UserId nvarchar(256)
   
   Select @UserId = Id FROM [GuildCars].[dbo].[AspNetUsers]
   Where Email = @Email and FirstName = @Fname
   AND LastName = @LName
   
   INSERT INTO  [GuildCars].[dbo].[AspNetUserRoles]([UserId],[RoleId]) 
   VALUES (@UserId,@RoleId)
   
 end
GO
/****** Object:  StoredProcedure [dbo].[usp_Cars_forSale]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[usp_Cars_forSale]
@type bit
AS
BEGIN
	SET NOCOUNT ON;
Declare @select2 nvarchar(128)


	If(@type= 0)
	Begin
		Select @select2 = 'AND cfs_type = 0'
	END
	If(@type= 1)
	Begin
		Select @select2 = 'AND cfs_type = 1'
	END
	If(@type= 2)
	Begin
		Select @select2 = ''
	END


EXEC 
('SELECT [CarId] = [cfs_id]
      ,[cfs_cm_id]
      ,[cfs_year]
      ,[cfs_type]
      ,[cfs_body_style]
      ,[cfs_cccatid]
      ,[cfs_msrp]
      ,[cfs_saleprice]
      ,[cfs_vin]
      ,[cfs_ext_color]
      ,[cfs_int_color]
      ,[cfs_transmission]
      ,[cfs_mileage]
      ,[cfs_description]
      ,[cfs_photo_name]
      ,[cfs_photo]
      ,[cfs_feature]
	  ,[cfs_sold]
  FROM [GuildCars].[dbo].[CarsForSale]
  where cfs_sold = 0' + @select2) 
  END
GO
/****** Object:  StoredProcedure [dbo].[usp_ContactForm]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[usp_ContactForm] (@Name nvarchar(50), @Phone nvarchar(20), @Email nvarchar(30), @Message nvarchar(1000)) AS
Begin
INSERT INTO ContactForm(cf_name, cf_phone, cf_email, cf_message)
VALUES (@Name, @Phone, @Email, @Message)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteSpecial]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_DeleteSpecial]

@id int

AS
BEGIN
	SET NOCOUNT ON;

	Delete from [dbo].[Specials] where [s_id] = @id


END
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteVehicle]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[usp_DeleteVehicle]
@id int

AS
BEGIN
	SET NOCOUNT ON;

	Delete from [dbo].CarsForSale where [cfs_id] = @id


END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllCars]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[usp_GetAllCars]
As
BEGIN
	SET NOCOUNT ON;


EXEC 
('SELECT [CarId]=[cfs_id]
      ,[Model] = [cm_model]
	  ,[Make] = [cm_makeName]
      ,[Year] = [cfs_year]
      ,[Type] = [cfs_type]
	  ,[BodyStyle] = [cbs_catdesc]
      ,[MSRP] = [cfs_msrp]
      ,[SalePrice] = [cfs_saleprice]
      ,[VIN] = [cfs_vin]
      ,[ExtColor] = [ec_colorname]
      ,[IntColor] = [ic_colorname]
      ,[Trans] =
	  CASE
	  When [cfs_transmission] = 1 then ''Automatic''
	  When  [cfs_transmission] = 2 then ''Manual''
	  End 
      ,[Mileage] = [cfs_mileage]
      ,[Description] = [cfs_description]
      ,[Photo_Name] = [cfs_photo_name]
      ,[Photo_Path] = [cfs_photo]
      ,[Sold] = [cfs_sold]
  FROM [GuildCars].[dbo].[CarsForSale] cfs
  JOIN [GuildCars].[dbo].[CarMakes] cm ON cm.cmk_id = cfs.cfs_cm_Id
  JOIN [GuildCars].[dbo].[CarModels] cmdl ON cmdl.cm_modelid = cfs.cfs_modelid
  JOIN [GuildCars].[dbo].[ExteriorColors] ex ON cfs.cfs_ext_color = ex.ec_id
  JOIN [GuildCars].[dbo].[InteriorColors] ic ON cfs.cfs_int_color = ic.ic_id
  JOIN [GuildCars].[dbo].[CarBodyStyle] cbs ON cbs.cbs_catid = cfs.cfs_body_style')
  END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetBodyStyles]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_GetBodyStyles]
AS
BEGIN
	SET NOCOUNT ON;
SELECT [BodyStyleId] = [cbs_catid]
      ,[BodyStyleDesc] = [cbs_catdesc]
  FROM [GuildCars].[dbo].[CarBodyStyle]
  END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetDetails]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[usp_GetDetails]
@id int
AS
BEGIN
	SET NOCOUNT ON;


EXEC 
('SELECT [CarId]=[cfs_id]
      ,[Model] = [cm_model]
	  ,[Make] = [cm_makeName]
      ,[Year] = [cfs_year]
      ,[Type] = [cfs_type]
	  ,[BodyStyle] = [cbs_catdesc]
      ,[MSRP] = [cfs_msrp]
      ,[SalePrice] = [cfs_saleprice]
      ,[VIN] = [cfs_vin]
      ,[ExtColor] = [ec_colorname]
      ,[IntColor] = [ic_colorname]
      ,[Trans] =
	  CASE
	  When [cfs_transmission] = 1 then ''Automatic''
	  When  [cfs_transmission] = 2 then ''Manual''
	  End 
      ,[Mileage] = [cfs_mileage]
      ,[Description] = [cfs_description]
      ,[Photo_Path] = [cfs_photo]
      ,[Sold] = [cfs_sold]
  FROM [GuildCars].[dbo].[CarsForSale] cfs
  LEFT JOIN [GuildCars].[dbo].[CarMakes] cm ON cm.cmk_id = cfs.cfs_cm_Id
  LEFT JOIN [GuildCars].[dbo].[CarModels] cmdl ON cmdl.cm_modelid = cfs.cfs_modelid
  LEFT JOIN [GuildCars].[dbo].[ExteriorColors] ex ON cfs.cfs_ext_color = ex.ec_id
  LEFT JOIN [GuildCars].[dbo].[InteriorColors] ic ON cfs.cfs_int_color = ic.ic_id
  LEFT JOIN [GuildCars].[dbo].[CarBodyStyle] cbs ON cbs.cbs_catid = cfs.cfs_body_style

  where cfs_id = ' + @id )
  END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetExtColors]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_GetExtColors]
AS
BEGIN
	SET NOCOUNT ON;
SELECT [ExtColorId] = [ec_id]
      ,[ExtColorDesc] = [ec_colorname]
  FROM [GuildCars].[dbo].[ExteriorColors]
  END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetFeatured]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_GetFeatured]
AS
BEGIN
	SET NOCOUNT ON;


EXEC 
('SELECT 
       [CarId] = cfs.[cfs_id]
	  ,[Year] = cfs.[cfs_year]
      ,[Type] = cfs.[cfs_type]
      ,[SalePrice] =  cfs.[cfs_saleprice]
	  ,[Photo_Path] = cfs.cfs_photo
	  ,[MakeId] = [cfs_cm_id]
	  ,[ModelId] = [cfs_modelid]
	  ,[MakeName] = [cm_makeName]
	  ,[ModelName] = [cm_model]
  FROM [GuildCars].[dbo].[CarsForSale] cfs
  LEFT JOIN [GuildCars].[dbo].[CarModels] cmodels on cmodels.[cm_modelid] = cfs.[cfs_modelid]
  where cfs_IsFeatured = 1 and cfs_sold = 0') 
  END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetFilteredModels]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetFilteredModels] 
@MakeId int
AS
BEGIN

	SET NOCOUNT ON;
SELECT Distinct  [MakeName] = [cm_makeName],  [ModelName] = [cm_model], [ModelId] = [cm_modelid]

  FROM [GuildCars].[dbo].[CarMakes] cm
  JOIN [GuildCars].[dbo].[CarModels] cmdl ON cm.cmk_make = cmdl.cm_makeName
  where cmk_Id = @MakeId
END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetIntColors]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_GetIntColors]
AS
BEGIN
	SET NOCOUNT ON;
SELECT [IntColorId] = [ic_id]
      ,[IntColorDesc] = [ic_colorname]
  FROM [GuildCars].[dbo].[InteriorColors]
  END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetMakes]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_GetMakes] 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
SELECT [MakeId] = [cmk_id]
      ,[MakeName] = [cmk_make]
      ,[DateAdded] = [cmk_date_added]
      ,[UpdatedBy] =[cmk_updated_by]
  FROM [GuildCars].[dbo].[CarMakes]
END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetMakesByModel]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_GetMakesByModel] 
@ModelId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
SELECT [MakeId] = [cmk_id]
      ,[MakeName] = [cmk_make]
      ,[DateAdded] = [cmk_date_added]
      ,[UpdatedBy] =[cmk_updated_by]
  FROM [GuildCars].[dbo].[CarMakes] cm
  JOIN [GuildCars].[dbo].[CarModels] cmdl ON cm.cmk_make = cmdl.cm_manufacture
  where cm_id =  @ModelId
END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetModels]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_GetModels] 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
SELECT [ModelId] = [cm_modelid],
	   [ModelName] = [cm_model],
	   [MakeId] = [cm_makeid],
	   [MakeName] = [cm_makeName]
      ,[DateAdded] = [cm_date_added]
      ,[UpdatedBy] =[cm_updated_by]
  FROM [GuildCars].[dbo].[CarModels]
  
END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetSalesResults]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetSalesResults]

@UserName varchar(50) = N'%',
@FromDate varchar(10) = '01/01/1900',
@ToDate varchar(10) = GETDATE
AS
BEGIN
	SET NOCOUNT ON;
	Declare
	@Where nvarchar(100),
	@AND nvarchar(100),
	@SQL nvarchar(max)

Print '21' + @UserName

If (@UserName = 'Null')
BEGIN
 Set @Where = ' Where anu.[UserName] LIKE ''%''' 
END
ELSE
BEGIN
 SET @Where = ' Where anu.[UserName] LIKE ''' + @UserName + ''''
END

If (@fromDate IS NOT NULL OR @toDate IS NOT NULL)
BEGIN
 Set @AND = ' AND CAST(si.si_date_sold as date) between ''' + @FromDate + ''' and ''' +  @ToDate + ''''
END
ELSE
BEGIN
 SET @AND = ' AND 1=1'
END

SET @SQL =
'SELECT [UserName]= anu.[UserName], [User] = anu.[LastName] + '', '' + anu.[FirstName], Count(*) as CountOfCarsSold, Sum(si.si_purchase_price) as TotalSales
  FROM [GuildCars].[dbo].[AspNetUsers] anu
  Join [GuildCars].[dbo].[AspNetUserRoles] anur ON anu.id = anur.UserId
  Join [GuildCars].[dbo].[AspNetRoles] anr ON anr.id = anur.RoleId
  Join [GuildCars].[dbo].[SalesInvoice] si ON si.si_uname = anu.UserName'

  SET @SQL = @SQL + @Where
  SET @SQL = @SQL + @AND
  SET @SQL = @SQL + ' Group By anu.[UserName], anu.[LastName] + '', '' + anu.[FirstName]'

 PRINT (@SQL)
 EXEC (@SQL)

END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetSalesUsers]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_GetSalesUsers]

AS
BEGIN
	SET NOCOUNT ON;
SELECT Distinct [UserName] = LEFT(anu.[FirstName],1) + anu.[LastName]
FROM [GuildCars].[dbo].[AspNetUsers] anu
Join [GuildCars].[dbo].[AspNetUserRoles] anur ON anu.id = anur.UserId
Join [GuildCars].[dbo].[AspNetRoles] anr ON anr.id = anur.RoleId
Join [GuildCars].[dbo].[SalesInvoice] si ON si.si_uname = anu.UserName

END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetSpecials]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_GetSpecials]

AS
BEGIN
	SET NOCOUNT ON;
	Select 
	   [ID] = [s_id]
      ,[Title] = [s_title]
      ,[Description] = [s_description]
      ,[ImageFileName] = [s_imagefilename]
      ,[s_startdate]
      ,[s_enddate]
  FROM [GuildCars].[dbo].[Specials]
  Order by ID


END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetStates]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetStates] 

AS
BEGIN
	SET NOCOUNT ON;
	Select [State_Abbrev] = [st_abbrev] From [GuildCars].[dbo].[States] Order By [st_abbrev]
END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetUserById]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_GetUserById]
@id varchar(100)

AS
BEGIN
	SET NOCOUNT ON;
SELECT anu.[FirstName]
      ,anu.[LastName]
	  ,anu.[Email]
	  ,anr.[Name]
	  ,anur.[UserId]
	  ,[RoleId] = anr.Id
	  ,[RoleName] = anr.Name

  FROM [GuildCars].[dbo].[AspNetUsers] anu
  Join [GuildCars].[dbo].[AspNetUserRoles] anur ON anu.id = anur.UserId
  Join [GuildCars].[dbo].[AspNetRoles] anr ON anr.id = anur.RoleId
  where anu.id = @id


END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetUsers]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_GetUsers]

AS
BEGIN
	SET NOCOUNT ON;
SELECT anu.[FirstName]
      ,anu.[LastName]
	  ,anu.[Email]
	  ,anur.[UserId]
	  ,[Role] = anr.Name
	  ,[RoleId] = anr.Id
  FROM [GuildCars].[dbo].[AspNetUsers] anu
  Join [GuildCars].[dbo].[AspNetUserRoles] anur ON anu.id = anur.UserId
  Join [GuildCars].[dbo].[AspNetRoles] anr ON anr.id = anur.RoleId


END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetVehicleById]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_GetVehicleById]
@id int 

AS
BEGIN
	SET NOCOUNT ON;
Select [CarId] = [cfs_id]
	  ,[ModelId] = [cfs_modelid]
      ,[MakeId] = [cfs_cm_id]
      ,[CarYr] = [cfs_year]
      ,[CarType] = [cfs_type]
      ,[CarBodyStyle] = [cfs_body_style]
      ,[MSRP] = [cfs_msrp]
      ,[SalePrice] = [cfs_saleprice]
      ,[VIN] = [cfs_vin]
      ,[ExtColor] = [cfs_ext_color]
      ,[IntColor] = [cfs_int_color]
      ,[CarTrans] = [cfs_transmission]
      ,[Mileage] = [cfs_mileage]
      ,[Desc] = [cfs_description]
      ,[PhotoPath] = [cfs_photo]
      ,[IsFeatured] = [cfs_Isfeatured]
  FROM [GuildCars].[dbo].[CarsForSale]
  where cfs_id = @id


END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetYears]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_GetYears] 

AS
BEGIN
	SET NOCOUNT ON;
	
with yearlist as 
(
    select 2000 as year
    union all
    select yl.year + 1 as year
    from yearlist yl
    where yl.year + 1 <= YEAR(GetDate())+1
)

select year as syear, year as year_value from yearlist order by year desc;





END
GO
/****** Object:  StoredProcedure [dbo].[usp_GuildCars_Reset]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_GuildCars_Reset] 

AS
BEGIN
	SET NOCOUNT ON;
	
Delete from CarBodyStyle
Delete from CarMakes
Delete from CarModels
Delete from CarsForSale
Delete from ContactForm
Delete from CustomerAddresses
Delete from Customers
Delete from ExteriorColors
Delete from InteriorColors
Delete from SalesInvoice
Delete from Specials
Delete from States

DBCC CHECKIDENT (CarBodyStyle,reseed, 0)
DBCC CHECKIDENT (CarModels,reseed, 0)
DBCC CHECKIDENT (CarsForSale,reseed, 0)
DBCC CHECKIDENT (ContactForm, reseed, 0)
DBCC CHECKIDENT (CustomerAddresses,reseed, 0)
DBCC CHECKIDENT (Customers,reseed, 0)
DBCC CHECKIDENT (ExteriorColors,reseed, 0)
DBCC CHECKIDENT (InteriorColors,reseed, 0)
DBCC CHECKIDENT (SalesInvoice,reseed, 0)
DBCC CHECKIDENT (Specials,reseed, 0)
DBCC CHECKIDENT (States,reseed, 0)

--SET IDENTITY_INSERT [dbo].[CarBodyStyle] ON

INSERT [dbo].[CarBodyStyle] (cbs_catdesc) VALUES ('Car')
INSERT [dbo].[CarBodyStyle] (cbs_catdesc) VALUES ('SUV')
INSERT [dbo].[CarBodyStyle] (cbs_catdesc) VALUES ('Truck')
INSERT [dbo].[CarBodyStyle] (cbs_catdesc) VALUES ('Van')

--SET IDENTITY_INSERT [dbo].[CarBodyStyle] OFF

--SET IDENTITY_INSERT [dbo].[Customers] ON
INSERT [dbo].[Customers] (c_name, c_phone, c_email, c_notes) VALUES ('Duck, Donald', '502-555-1234', 'donaldduck@disney.com','')
INSERT [dbo].[Customers] (c_name, c_phone, c_email, c_notes) VALUES ('Bunny, Buggs', '502-555-2345', 'buggsbunny@looneytunes.com','')
INSERT [dbo].[Customers] (c_name, c_phone, c_email, c_notes) VALUES ('Duck, Daffy', '502-555-3456', 'daffyduck@looneytunes.com','')
INSERT [dbo].[Customers] (c_name, c_phone, c_email, c_notes) VALUES ('Sam, Yosemite', '502-555-4567', 'yosemtiesam@looneytunes.com','')
SET IDENTITY_INSERT [dbo].[Customers] OFF


--SET IDENTITY_INSERT [dbo].[CustomerAddresses] ON
INSERT [dbo].[CustomerAddresses] (ca_c_id, ca_address1, ca_address2, ca_city, ca_state, ca_zip, ca_country)
Values (1, '123 Disney Blvd','', 'KISSIMMEE','FL','34741','USA')
INSERT [dbo].[CustomerAddresses] (ca_c_id, ca_address1, ca_address2, ca_city, ca_state, ca_zip, ca_country)
Values (2, '3400 Waner Blvd','', 'Burbank','CA','91505','USA')
INSERT [dbo].[CustomerAddresses] (ca_c_id, ca_address1, ca_address2, ca_city, ca_state, ca_zip, ca_country)
Values (3, '3400 Waner Blvd','', 'Burbank','CA','91505','USA')
INSERT [dbo].[CustomerAddresses] (ca_c_id, ca_address1, ca_address2, ca_city, ca_state, ca_zip, ca_country)
Values (4, '3400 Waner Blvd','', 'Burbank','CA','91505','USA')
--SET IDENTITY_INSERT [dbo].[CustomerAddresses] OFF


--States
--SET IDENTITY_INSERT [dbo].[States] ON
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Alabama', 'AL')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Alaska', 'AK')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Arizona', 'AZ')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Arkansas', 'AR')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('California', 'CA')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Colorado', 'CO')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Connecticut', 'CT')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Delaware', 'DE')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Florida', 'FL')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Georgia', 'GA')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Hawaii', 'HI')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Idaho', 'ID')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Illinois', 'IL')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Indiana', 'IN')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Iowa', 'IA')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Kansas', 'KS')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Kentucky', 'KY')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Louisiana', 'LA')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Maine', 'ME')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Maryland', 'MD')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Massachusetts', 'MA')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Michigan', 'MI')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Minnesota', 'MN')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Mississippi', 'MS')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Missouri', 'MO')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Montana', 'MT')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Nebraska', 'NE')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Nevada', 'NV')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('New Hampshire', 'NH')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('New Jersey', 'NJ')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('New Mexico', 'NM')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('New York', 'NY')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('North Carolina', 'NC')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('North Dakota', 'ND')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Ohio', 'OH')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Oklahoma', 'OK')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Oregon', 'OR')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Pennsylvania', 'PA')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Rhode Island', 'RI')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('South Carolina', 'SC')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('South Dakota', 'SD')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Tennessee', 'TN')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Texas', 'TX')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Utah', 'UT')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Vermont', 'VT')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Virginia', 'VA')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Washington', 'WA')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('West Virginia', 'WV')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Wisconsin', 'WI')
INSERT [dbo].[States] (st_name,st_abbrev) Values ('Wyoming', 'WY')
--SET IDENTITY_INSERT [dbo].[States] OFF


--Car Makes
SET IDENTITY_INSERT [dbo].[CarMakes] ON
INSERT [dbo].CarMakes ([cmk_id],[cmk_make],[cmk_date_added],[cmk_updated_by]) 
Values 
(1, 'Ford', GetDate(), 'Twhitehouse'),
(2,'Toyota', GetDate(), 'Twhitehouse'),
(3,'Chevrolet', GetDate(), 'Twhitehouse')
SET IDENTITY_INSERT [dbo].[CarMakes] OFF

--Car Models
--SET IDENTITY_INSERT [dbo].[CarModels] ON
INSERT [dbo].CarModels (cm_makeid, cm_makeName, cm_model, cm_date_added, cm_updated_by) 
Values 
(1, 'Ford', 'F-150', GetDate(), 'Twhitehouse'),
(1,'Ford', 'Escort', GetDate(), 'Twhitehouse'),
(2,'Toyota', 'Camry', GetDate(), 'Twhitehouse'),
(2,'Toyota', 'Corolla', GetDate(), 'Twhitehouse'),
(3,'Chevrolet', 'Camero', GetDate(), 'Twhitehouse'),
(3,'Toyota', 'Tacoma', GetDate(), 'Twhitehouse')
--SET IDENTITY_INSERT [dbo].[CarModels] OFF


Declare @Blah varchar(1000) = 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.'
--Set Identity_Insert Specials On
	INSERT INTO Specials (s_title, s_description, s_imagefilename, s_startdate, s_enddate)
	VALUES 
	('Special 1', @Blah,'/images/Inventory-1.png',getdate(),getdate()),
	('Special 2', @Blah,'/images/Inventory-2.png',getdate(),getdate()),
	('Special 3', @Blah,'/images/Inventory-3png',getdate(),getdate()),
	('Special 4', @Blah,'/images/Inventory-4.png',getdate(),getdate()),
	('Special 5', @Blah,'/images/Inventory-5.png',getdate(),getdate()),
	('Special 6', @Blah,'/images/Inventory-6.png',getdate(),getdate())

--Set Identity_Insert Specials Off



Set Identity_Insert InteriorColors On
	INSERT INTO InteriorColors (ic_id, ic_colorname)
	VALUES (1, 'Grey'),
	(2, 'Black'),
	(3, 'White'),
	(4, 'Tan'),
	(5, 'Beige'),
	(6, 'Maroon')
--Set Identity_Insert InteriorColors Off

	INSERT INTO ExteriorColors (ec_colorname)
	VALUES ('White'),
	('Black'),
	('Tan'),
	('Gold'),
	('Red'),
	('Blue'),
	('Green'),
	('Orange'),
	('Silver'),
	('Brown')


  INSERT INTO [GuildCars].[dbo].[CarsForSale] 
  ([cfs_cm_id], [cfs_year],[cfs_type], [cfs_body_style],[cfs_msrp],[cfs_saleprice],[cfs_vin],[cfs_ext_color],
  [cfs_int_color],[cfs_transmission],[cfs_mileage],[cfs_description],[cfs_photo],[cfs_sold],[cfs_isFeatured],
  [cfs_modelid])
	  Values 
	  (1,2017,2,1,21579.61,20999.52,'SAJWA0ES6DPS56028',1,1,1,30000,'Description','/images/Inventory-1.png',0,1,1),
	  (1,2016,1,1,32566.22,32500.02,'JT4RN61D8F5061251',1,1,2,100,'Description','/images/Inventory-2.png',0,1,2),
	  (1,2014,2,2,32566.22,32500.02,'JT4RN61D8F5061251',1,1,2,10000,'Description','/images/Inventory-3.png',0,1,3),
	  (1,2019,1,2,32566.22,32500.02,'JT4RN61D8F5061251',1,1,2,10,'Description','/images/Inventory-4.png',0,1,4),
	  (1,2020,1,1,32566.22,32500.02,'JT4RN61D8F5061251',1,1,2,10,'Description','/images/Inventory-5.png',0,1,5),
	  (1,2021,1,1,32566.22,32500.02,'JT4RN61D8F5061251',1,1,2,0,'Description','/images/Inventory-6.png',0,1,6)


Update Specials 
Set s_imagefilename = (select cfs_photo from CarsForSale where cfs_id = Specials.s_id)



INSERT INTO [dbo].[SalesInvoice]
           ([si_uname]
           ,[si_cid]
           ,[si_cfsid]
           ,[si_purchase_price]
           ,[si_purchase_type]
           ,[si_date_sold])
     VALUES
           ('JWite',1,1,'29000.00','Bank Finance','2020-01-05'),
		   ('JWite',1,2,'30000.00','Bank Finance','2020-01-07'),
		   ('JWite',1,3,'31000.00','Bank Finance','2020-01-09'),
		   ('JWite',1,4,'32000.00','Bank Finance','2020-02-15'),
		   ('JWite',1,5,'33000.00','Bank Finance','2020-02-16'),
		   ('JWite',1,6,'34000.00','Bank Finance','2020-03-05'),
		   ('JWite',1,7,'35000.00','Bank Finance','2020-04-05'),
		   ('JWite',1,8,'32500.00','Bank Finance','2020-05-05'),
		   ('JWite',1,9,'29500.00','Bank Finance','2020-06-05'),
  		   ('twhitehouse',1,10,'44500.00','Bank Finance','2020-01-05'),
   		   ('twhitehouse',1,11,'34500.00','Bank Finance','2020-02-05'),
  		   ('twhitehouse',1,12,'33900.00','Bank Finance','2020-03-05'),
  		   ('twhitehouse',1,13,'25500.00','Bank Finance','2020-04-05'),
  		   ('twhitehouse',1,14,'33500.00','Bank Finance','2020-05-05'),
  		   ('twhitehouse',1,15,'44500.00','Bank Finance','2020-07-05'),
  		   ('twhitehouse',1,16,'43500.00','Bank Finance','2020-06-05'),
  		   ('twhitehouse',1,17,'54500.00','Bank Finance','2020-08-05')




--select * from CarBodyStyle
--select * from Customers
--select * from CustomerAddresses
--Select * from CarFeatures
















END
GO
/****** Object:  StoredProcedure [dbo].[usp_NewInventoryCars]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[usp_NewInventoryCars]
AS
BEGIN



	SET NOCOUNT ON;

	   SELECT Top 20
	   [Year] = [cfs_year]
	   ,[Make] = cmk.cmk_make
       ,[Model] = cm.cm_model
	   ,Count(*) as [Count]
       ,[MSRP] = SUM([cfs_msrp])
	  FROM [GuildCars].[dbo].[CarsForSale] cfs
	  LEFT JOIN [GuildCars].[dbo].[CarMakes] cmk ON cmk.cmk_id = cfs.cfs_cm_id
	  LEFT JOIN [GuildCars].[dbo].[CarModels] cm ON cm.cm_modelid = cfs.cfs_modelid
	  LEFT JOIN [GuildCars].[dbo].[ExteriorColors] ex ON cfs.cfs_ext_color = ex.ec_id
	  LEFT JOIN [GuildCars].[dbo].[InteriorColors] ic ON cfs.cfs_int_color = ic.ic_id
	  LEFT JOIN [GuildCars].[dbo].[CarBodyStyle] cbs ON cbs.cbs_catid = cfs.cfs_body_style
	  Where cfs_type = 1  --New Cars
	  Group BY [cfs_year],cm.cm_model, cmk.cmk_make




  END
GO
/****** Object:  StoredProcedure [dbo].[usp_NewPurchase]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_NewPurchase]
@UserName varchar(25),
@CustName varchar(30),
@CustPhone varchar(12) = Null,
@CustEmail varchar(25) = Null,
@CustStreet1 varchar(25),
@CustStreet2 varchar(25) = Null,
@CustCity varchar(25),
@CustState varchar(25),
@CustZip varchar(5),
@SalePrice decimal(10,2),
@PurchaseType varchar(25),
@CarId int



AS
BEGIN
	SET NOCOUNT ON;

Declare
@CID int

	INSERT INTO [GuildCars].[dbo].[Customers] ([c_name],[c_phone], [c_email])
	OUTPUT inserted.c_id
	Values (@CustName, @CustPhone, @CustEmail)

	SET @CID = SCOPE_IDENTITY()

	INSERT INTO  [GuildCars].[dbo].[SalesInvoice]( [si_uname],[si_cid],[si_cfsid],[si_purchase_price],[si_purchase_type],[si_date_sold])
	VALUES (@UserName, @CID, @CarId, @SalePrice, @PurchaseType, GetDate() )

	INSERT INTO [GUILDCARS].[dbo].[CustomerAddresses] ([ca_c_id],[ca_address1],[ca_address2],[ca_city],[ca_state],[ca_zip])
	VALUES (@CID, @CustStreet1, @CustStreet2, @CustCity, @CustState, @CustZip)

	Update [GuildCars].[dbo].[CarsForSale]
	Set [cfs_sold] = 1
	Where cfs_id = @CarId


END
GO
/****** Object:  StoredProcedure [dbo].[usp_SearchAllCars]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_SearchAllCars]
@SearchTerm varchar(100) = N'%',
@MinPrice varchar(max),
@MaxPrice varchar(max),
@MinYear varchar(max),
@MaxYear varchar(max),
@Type INT

As
BEGIN

Declare @t1 int, @t2 int, @t3 int


If (@Type = 3)
Begin
	SET @t1 = 1
	SET @t2 = 2
End
If (@Type = 2)
Begin
	SET @t1 = 2
	SET @t2 = 2
End
If (@Type = 1)
Begin
	SET @t1 = 1
	SET @t2 = 1
End



	SET NOCOUNT ON;

	   SELECT TOP 20 
	   [CarId]=[cfs_id]
      ,[Model] = [cm_model]
	  ,[Make] = [cm_makeName]
      ,[Year] = [cfs_year]
      ,[Type] = [cfs_type]
	  ,[BodyStyle] = [cbs_catdesc]
      ,[MSRP] = [cfs_msrp]
      ,[SalePrice] = [cfs_saleprice]
      ,[VIN] = [cfs_vin]
      ,[ExtColor] = [ec_colorname]
      ,[IntColor] = [ic_colorname]
      ,[Trans] =
	  CASE
	  When [cfs_transmission] = 1 then 'Automatic'
	  When  [cfs_transmission] = 2 then 'Manual'
	  End 
      ,[Mileage] = [cfs_mileage]
      ,[Description] = [cfs_description]
      ,[Photo_Name] = [cfs_photo_name]
      ,[Photo_Path] = [cfs_photo]
      ,[Sold] = [cfs_sold]
  FROM [GuildCars].[dbo].[CarsForSale] cfs
  LEFT JOIN [GuildCars].[dbo].[CarMakes] cm ON cm.cmk_id = cfs.cfs_cm_Id
  LEFT JOIN [GuildCars].[dbo].[CarModels] cmdl ON cmdl.cm_modelid = cfs.cfs_modelid
  JOIN [GuildCars].[dbo].[ExteriorColors] ex ON cfs.cfs_ext_color = ex.ec_id
  JOIN [GuildCars].[dbo].[InteriorColors] ic ON cfs.cfs_int_color = ic.ic_id
  JOIN [GuildCars].[dbo].[CarBodyStyle] cbs ON cbs.cbs_catid = cfs.cfs_body_style
	where cfs_sold = 0 AND
	(([cm_makeName] LIKE '%'+ @SearchTerm +'%')
	OR (cm_model LIKE '%'+ @SearchTerm +'%')
	OR (cfs_year LIKE '%'+ @SearchTerm +'%'))
	AND (cfs_saleprice >= + CAST(@MinPrice as varchar) AND cfs_saleprice <= + CAST(@MaxPrice as varchar)) 
	AND (cfs_year >= + CAST(@MinYear as varchar) AND cfs_year <=  + CAST(@MaxYear as varchar))
	AND (cfs_type = @t1 OR cfs_type = @t2)
	ORDER BY cfs_msrp, [cm_makeName], cm_model, cfs_year

 

 --Print 'searchTerm1: ' + @searchTerm
 --Print 'minPrice: ' + CAST(@MinPrice as varchar(max))
 --Print 'maxPrice: ' + CAST(@MaxPrice as varchar(max))
 --Print 'minYear: ' +CAST(@MinYear as varchar(max))
 --Print 'maxYear: ' +CAST(@MaxYear as varchar(max))
  


  END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateUser]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_UpdateUser](
   @FName CHAR(100),
   @LName CHAR(100),
   @Email CHAR(256),
   @RoleId INT,
   @UserId nvarchar(256)
)
AS
   begin

	Update [GuildCars].[dbo].[AspNetUsers]
	Set 
	FirstName = @FName,
	LastName = @LName,
	Email = @Email
	Where id = @UserId

	Update [GuildCars].[dbo].[AspNetUserRoles]
	Set RoleId = @RoleId
	where UserId = @UserId
   
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateVehicle]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_UpdateVehicle](
   @CarId INT,
   @MakeId INT,
   @ModelId INT,
   @CarType INT,
   @BodyStyle varchar(25),
   @Yr varchar(4),
   @CarTrans varchar(25),
   @ExtColor varchar(25),
   @IntColor varchar(25),
   @Mileage INT,
   @VIN varchar(18),
   @MSRP decimal(10,2),
   @SalePrice decimal(10,2),
   @Desc varchar(200),
   @PhotoPath varchar(50),
   @IsFeatured int = 0

)
AS
   begin

	Update [GuildCars].[dbo].[CarsForSale]
	Set [cfs_cm_id] = @MakeId
	   ,[cfs_modelid] = @ModelId
      , [cfs_year] = @Yr
      ,[cfs_type] = @CarType
      ,[cfs_body_style] = @BodyStyle
      ,[cfs_msrp] = @MSRP
      ,[cfs_saleprice] = @SalePrice
      ,[cfs_vin] =  @VIN
      ,[cfs_ext_color] = @ExtColor
      ,[cfs_int_color] = @IntColor
      ,[cfs_transmission] = @CarTrans
      ,[cfs_mileage] = @Mileage
      ,[cfs_description] = @Desc
      ,[cfs_photo] = @PhotoPath
      ,[cfs_isfeatured] = @IsFeatured
	 where cfs_id = @CarId


   
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_UsedInventoryCars]    Script Date: 11/4/2020 8:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UsedInventoryCars]
AS
BEGIN
	SET NOCOUNT ON;
	   SELECT Top 20
	   [Year] = [cfs_year]
	   ,[Make] = [cm_makeName]
       ,[Model] = [cm_model]
	   ,Count(*) as [Count]
       ,[MSRP] = SUM([cfs_msrp])
	  FROM [GuildCars].[dbo].[CarsForSale] cfs
	  JOIN [GuildCars].[dbo].[CarModels] cm ON cm.cm_modelid = cfs.cfs_modelid
	  JOIN [GuildCars].[dbo].[ExteriorColors] ex ON cfs.cfs_ext_color = ex.ec_id
	  JOIN [GuildCars].[dbo].[InteriorColors] ic ON cfs.cfs_int_color = ic.ic_id
	  JOIN [GuildCars].[dbo].[CarBodyStyle] cbs ON cbs.cbs_catid = cfs.cfs_body_style
	  Where cfs_type = 2  --Used Cars
	  Group BY [cfs_year],[cm_model], [cm_makeName]
  END
GO
