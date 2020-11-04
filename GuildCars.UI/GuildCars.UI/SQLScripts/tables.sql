USE GuildCars
GO

IF EXISTS(SELECT * FROM sys.views WHERE name='v_SalesPurchase')
	DROP VIEW [dbo].[v_SalesPurchase]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE name='Customers')
	DROP TABLE Customers
GO

IF EXISTS(SELECT * FROM sys.tables WHERE name='CustomerAddresses')
	DROP TABLE CustomerAddresses
GO

IF EXISTS(SELECT * FROM sys.tables WHERE name='CarBodyStyle')
	DROP TABLE CarBodyStyle
GO
IF EXISTS(SELECT * FROM sys.tables WHERE name='CarMakes')
	DROP TABLE CarMakes
GO

IF EXISTS(SELECT * FROM sys.tables WHERE name='CarModels')
	DROP TABLE CarModels
GO

IF EXISTS(SELECT * FROM sys.tables WHERE name='CarsForSale')
	DROP TABLE CarsForSale
GO

IF EXISTS(SELECT * FROM sys.tables WHERE name='SalesInvoice')
	DROP TABLE SalesInvoice
GO

IF EXISTS(SELECT * FROM sys.tables WHERE name='Specials')
	DROP TABLE Specials
GO

IF EXISTS(SELECT * FROM sys.tables WHERE name='States')
	DROP TABLE States
GO

IF EXISTS(SELECT * FROM sys.tables WHERE name='InteriorColors')
	DROP TABLE InteriorColors
GO

IF EXISTS(SELECT * FROM sys.tables WHERE name='ExteriorColors')
	DROP TABLE ExteriorColors
GO

IF EXISTS(SELECT * FROM sys.tables WHERE name='ContactForm')
	DROP TABLE ContactFrom
GO

CREATE VIEW [dbo].[v_SalesPurchase]
AS
SELECT        si.si_id, si.si_uname, si.si_cid, si.si_cfsid, si.si_purchase_price, si.si_purchase_type, si.si_date_sold, c.c_id, c.c_name, c.c_phone, c.c_email, c.c_notes, ca.ca_address_id, ca.ca_c_id, ca.ca_address1, ca.ca_address2, 
                         ca.ca_city, ca.ca_state, ca.ca_zip, ca.ca_country, dbo.CarsForSale.cfs_sold
FROM            dbo.SalesInvoice AS si INNER JOIN
                         dbo.CarsForSale ON si.si_cfsid = dbo.CarsForSale.cfs_id LEFT OUTER JOIN
                         dbo.Customers AS c ON c.c_id = si.si_cid LEFT OUTER JOIN
                         dbo.CustomerAddresses AS ca ON ca.ca_c_id = c.c_id
GO


CREATE TABLE [dbo].[Customers](
	[c_id] [int] IDENTITY(1,1) NOT NULL,
	[c_name] [varchar](15) NOT NULL,
	[c_phone] [varchar](12) NULL,
	[c_email] [varchar](50) NULL,
	[c_notes] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[c_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CustomerAddresses](
	[ca_address_id] [int] IDENTITY(1,1) NOT NULL,
	[ca_c_id] [int] NOT NULL,
	[ca_address1] [varchar](25) NULL,
	[ca_address2] [varchar](25) NULL,
	[ca_city] [varchar](25) NULL,
	[ca_state] [varchar](25) NULL,
	[ca_zip] [varchar](5) NULL,
	[ca_country] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[ca_address_id] ASC,
	[ca_c_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CustomerAddresses] ADD  CONSTRAINT [DF_CustomerAddresses_ca_country]  DEFAULT ('United States') FOR [ca_country]
GO

ALTER TABLE [dbo].[CustomerAddresses]  WITH CHECK ADD  CONSTRAINT [FK_CustomerAddresses_Customers] FOREIGN KEY([ca_c_id])
REFERENCES [dbo].[Customers] ([c_id])
GO

ALTER TABLE [dbo].[CustomerAddresses] CHECK CONSTRAINT [FK_CustomerAddresses_Customers]
GO

CREATE TABLE [dbo].[CarBodyStyle](
	[cbs_catid] [int] IDENTITY(1,1) NOT NULL,
	[cbs_catdesc] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[cbs_catid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[CarModels](
	[cm_modelid] [int] IDENTITY(1,1) NOT NULL,
	[cm_model] [varchar](130) NOT NULL,
	[cm_makeId] [int] NOT NULL,
	[cm_makeName] [varchar](130) NOT NULL,
	[cm_date_added] [datetime] NULL,
	[cm_updated_by] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[cm_modelid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CarsForSale](
	[cfs_id] [int] IDENTITY(1,1) NOT NULL,
	[cfs_cm_id] [int] NOT NULL,
	[cfs_year] [varchar](4) NULL,
	[cfs_type] [int] NULL,
	[cfs_body_style] [varchar](25) NULL,
	[cfs_msrp] [decimal](10, 2) NULL,
	[cfs_saleprice] [decimal](10, 2) NULL,
	[cfs_vin] [varchar](18) NULL,
	[cfs_ext_color] [varchar](25) NULL,
	[cfs_int_color] [varchar](25) NULL,
	[cfs_mileage] [int] NULL,
	[cfs_description] [varchar](200) NULL,
	[cfs_photo_name] [varchar](50) NULL,
	[cfs_photo] [varchar](50) NULL,
	[cfs_sold] [bit] NULL,
	[cfs_transmission] [int] NULL,
	[cfs_modelid] [int] NULL,
	[cfs_IsFeatured] [bit] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[cfs_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CarsForSale] ADD  DEFAULT ((1)) FOR [cfs_type]
GO

ALTER TABLE [dbo].[CarsForSale] ADD  CONSTRAINT [DF_CarsForSale_cfs_body_style]  DEFAULT ((0)) FOR [cfs_body_style]
GO

ALTER TABLE [dbo].[CarsForSale] ADD  DEFAULT ((0)) FOR [cfs_mileage]
GO

ALTER TABLE [dbo].[CarsForSale] ADD  DEFAULT ((0)) FOR [cfs_sold]
GO

ALTER TABLE [dbo].[CarsForSale] ADD  CONSTRAINT [DF_CarsForSale_cfs_transmission]  DEFAULT ((1)) FOR [cfs_transmission]
GO

ALTER TABLE [dbo].[CarsForSale] ADD  CONSTRAINT [DF_CarsForSale_cfs_IsFeatured]  DEFAULT ((0)) FOR [cfs_IsFeatured]
GO

CREATE TABLE [dbo].[SalesInvoice](
	[si_id] [int] IDENTITY(1,1) NOT NULL,
	[si_uname] [varchar](25) NULL,
	[si_cid] [int] NULL,
	[si_cfsid] [int] NULL,
	[si_purchase_price] [decimal](10, 2) NULL,
	[si_purchase_type] [varchar](25) NULL,
	[si_date_sold] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[si_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

--CREATE TABLE Users (
--	u_id varchar(100),
--	u_current_pw BINARY(64),
--	u_old_pw BINARY(64),
--	u_lastname varchar(25),
--	u_firstname varchar(25),
--	u_email varchar(50),
--	u_roleid int,
--	Constraint [PK_Users_u_id] PRIMARY KEY CLUSTERED (u_id asc)
--)

--CREATE TABLE UserRoles (
--	ur_roleid int,
--	ur_rolename varchar(25)
--	Constraint [PK_UserRoles_ur_roleid] PRIMARY KEY CLUSTERED (ur_roleid asc)
--)

CREATE TABLE [dbo].[Specials](
	[s_id] [int] IDENTITY(1,1) NOT NULL,
	[s_title] [varchar](50) NULL,
	[s_description] [varchar](1000) NULL,
	[s_imagefilename] [varchar](100) NULL,
	[s_startdate] [date] NOT NULL,
	[s_enddate] [date] NOT NULL,
 CONSTRAINT [PK_Specials_s_id] PRIMARY KEY CLUSTERED 
(
	[s_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Specials] ADD  CONSTRAINT [DF_Specials_s_imagefilename]  DEFAULT ('/Images/DefaultDesk_Style_COUPE.png') FOR [s_imagefilename]
GO


CREATE TABLE [dbo].[States](
	[st_id] [int] IDENTITY(1,1) NOT NULL,
	[st_abbrev] [char](2) NULL,
	[st_name] [varchar](50) NULL,
 CONSTRAINT [PK_States_st_id] PRIMARY KEY CLUSTERED 
(
	[st_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[InteriorColors](
	[ic_id] [int] IDENTITY(1,1) NOT NULL,
	[ic_colorname] [varchar](25) NULL,
 CONSTRAINT [PK_InteriorColors_ic_id] PRIMARY KEY CLUSTERED 
(
	[ic_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[ExteriorColors](
	[ec_id] [int] IDENTITY(1,1) NOT NULL,
	[ec_colorname] [varchar](25) NULL,
 CONSTRAINT [PK_ExteriorColors_ec_id] PRIMARY KEY CLUSTERED 
(
	[ec_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ContactForm](
	[cf_id] [int] IDENTITY(1,1) NOT NULL,
	[cf_name] [nvarchar](50) NOT NULL,
	[cf_phone] [nvarchar](20) NULL,
	[cf_email] [nvarchar](30) NULL,
	[cf_message] [varchar](1000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cf_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CarMakes](
	[cmk_id] [int] IDENTITY(1,1) NOT NULL,
	[cmk_make] [varchar](60) NOT NULL,
	[cmk_date_added] [datetime] NULL,
	[cmk_updated_by] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[cmk_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO