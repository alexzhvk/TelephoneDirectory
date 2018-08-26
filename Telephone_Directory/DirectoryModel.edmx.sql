
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/25/2018 01:00:36
-- Generated from EDMX file: C:\Users\TRR\Desktop\Telephone_Directory\Telephone_Directory\DirectoryModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DirectoryDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_SubscribersInfoConnectionsInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConnectionsInfoSet] DROP CONSTRAINT [FK_SubscribersInfoConnectionsInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_OperatorsInfoConnectionsInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConnectionsInfoSet] DROP CONSTRAINT [FK_OperatorsInfoConnectionsInfo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[SubscribersInfoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SubscribersInfoSet];
GO
IF OBJECT_ID(N'[dbo].[ConnectionsInfoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConnectionsInfoSet];
GO
IF OBJECT_ID(N'[dbo].[OperatorsInfoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OperatorsInfoSet];
GO
IF OBJECT_ID(N'[dbo].[UsersInfoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsersInfoSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'SubscribersInfoSet'
CREATE TABLE [dbo].[SubscribersInfoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PassportData] nvarchar(max)  NOT NULL,
    [FullName] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ConnectionsInfoSet'
CREATE TABLE [dbo].[ConnectionsInfoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PhoneNumber] nchar(10)  NOT NULL,
    [Arrear] decimal(18,0)  NOT NULL,
    [Tariff] nvarchar(max)  NOT NULL,
    [InstallationDate] datetime  NOT NULL,
    [SubscribersInfo_Id] int  NOT NULL,
    [OperatorsInfo_Id] int  NOT NULL
);
GO

-- Creating table 'OperatorsInfoSet'
CREATE TABLE [dbo].[OperatorsInfoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Code] nchar(3)  NOT NULL,
    [AmountOfUsers] int  NOT NULL
);
GO

-- Creating table 'UsersInfoSet'
CREATE TABLE [dbo].[UsersInfoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Access_level] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'SubscribersInfoSet'
ALTER TABLE [dbo].[SubscribersInfoSet]
ADD CONSTRAINT [PK_SubscribersInfoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ConnectionsInfoSet'
ALTER TABLE [dbo].[ConnectionsInfoSet]
ADD CONSTRAINT [PK_ConnectionsInfoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OperatorsInfoSet'
ALTER TABLE [dbo].[OperatorsInfoSet]
ADD CONSTRAINT [PK_OperatorsInfoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UsersInfoSet'
ALTER TABLE [dbo].[UsersInfoSet]
ADD CONSTRAINT [PK_UsersInfoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SubscribersInfo_Id] in table 'ConnectionsInfoSet'
ALTER TABLE [dbo].[ConnectionsInfoSet]
ADD CONSTRAINT [FK_SubscribersInfoConnectionsInfo]
    FOREIGN KEY ([SubscribersInfo_Id])
    REFERENCES [dbo].[SubscribersInfoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SubscribersInfoConnectionsInfo'
CREATE INDEX [IX_FK_SubscribersInfoConnectionsInfo]
ON [dbo].[ConnectionsInfoSet]
    ([SubscribersInfo_Id]);
GO

-- Creating foreign key on [OperatorsInfo_Id] in table 'ConnectionsInfoSet'
ALTER TABLE [dbo].[ConnectionsInfoSet]
ADD CONSTRAINT [FK_OperatorsInfoConnectionsInfo]
    FOREIGN KEY ([OperatorsInfo_Id])
    REFERENCES [dbo].[OperatorsInfoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OperatorsInfoConnectionsInfo'
CREATE INDEX [IX_FK_OperatorsInfoConnectionsInfo]
ON [dbo].[ConnectionsInfoSet]
    ([OperatorsInfo_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------