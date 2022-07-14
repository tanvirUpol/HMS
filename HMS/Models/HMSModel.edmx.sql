
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/10/2022 11:30:12
-- Generated from EDMX file: D:\C#_101\HMS\HMS\Models\HMSModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HMS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Admins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Admins];
GO
IF OBJECT_ID(N'[dbo].[CalGros]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CalGros];
GO
IF OBJECT_ID(N'[dbo].[MealInfos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MealInfos];
GO
IF OBJECT_ID(N'[dbo].[Members]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Members];
GO
IF OBJECT_ID(N'[dbo].[Request_Services]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Request_Services];
GO
IF OBJECT_ID(N'[dbo].[Staffs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Staffs];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Admins'
CREATE TABLE [dbo].[Admins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NOT NULL,
    [Phone] varchar(50)  NOT NULL,
    [Email] varchar(50)  NOT NULL,
    [Password] varchar(50)  NOT NULL,
    [Type] int  NOT NULL
);
GO

-- Creating table 'CalGros'
CREATE TABLE [dbo].[CalGros] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] varchar(50)  NOT NULL,
    [Price] int  NOT NULL,
    [Product] varchar(50)  NOT NULL
);
GO

-- Creating table 'MealInfos'
CREATE TABLE [dbo].[MealInfos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Member_ID] int  NOT NULL,
    [Lunch] int  NOT NULL,
    [Dinner] int  NOT NULL,
    [breakfast] int  NOT NULL
);
GO

-- Creating table 'Members'
CREATE TABLE [dbo].[Members] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NOT NULL,
    [Password] varchar(50)  NOT NULL,
    [Age] int  NOT NULL,
    [Gname] varchar(50)  NOT NULL,
    [Gender] varchar(50)  NOT NULL,
    [Phone] varchar(50)  NOT NULL,
    [Type] int  NOT NULL
);
GO

-- Creating table 'Request_Services'
CREATE TABLE [dbo].[Request_Services] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NOT NULL,
    [Age] int  NOT NULL,
    [Gender] varchar(50)  NOT NULL,
    [Address] varchar(50)  NOT NULL,
    [Phone] varchar(50)  NOT NULL,
    [Password] varchar(50)  NOT NULL,
    [Type] int  NOT NULL,
    [member_ID] int  NOT NULL,
    [Service_Type] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Staffs'
CREATE TABLE [dbo].[Staffs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NOT NULL,
    [Age] int  NOT NULL,
    [Gender] varchar(50)  NOT NULL,
    [Address] varchar(50)  NOT NULL,
    [Phone] varchar(50)  NOT NULL,
    [Password] varchar(50)  NOT NULL,
    [Type] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Admins'
ALTER TABLE [dbo].[Admins]
ADD CONSTRAINT [PK_Admins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CalGros'
ALTER TABLE [dbo].[CalGros]
ADD CONSTRAINT [PK_CalGros]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MealInfos'
ALTER TABLE [dbo].[MealInfos]
ADD CONSTRAINT [PK_MealInfos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Members'
ALTER TABLE [dbo].[Members]
ADD CONSTRAINT [PK_Members]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Request_Services'
ALTER TABLE [dbo].[Request_Services]
ADD CONSTRAINT [PK_Request_Services]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Staffs'
ALTER TABLE [dbo].[Staffs]
ADD CONSTRAINT [PK_Staffs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------