
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 06/19/2014 17:35:29
-- Generated from EDMX file: C:\Users\Gabriel\Documents\Visual Studio 2010\Projects\pbr-rent-a-car\PBR Rent a car\Dados.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PBR.Dados];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_VeículoHistórico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VeículoSet] DROP CONSTRAINT [FK_VeículoHistórico];
GO
IF OBJECT_ID(N'[dbo].[FK_ReservaVeículo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReservaSet] DROP CONSTRAINT [FK_ReservaVeículo];
GO
IF OBJECT_ID(N'[dbo].[FK_HistóricoRelatório]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HistóricoSet] DROP CONSTRAINT [FK_HistóricoRelatório];
GO
IF OBJECT_ID(N'[dbo].[FK_VeículoModelo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VeículoSet] DROP CONSTRAINT [FK_VeículoModelo];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionárioRelatório]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RelatórioSet] DROP CONSTRAINT [FK_FuncionárioRelatório];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionárioVeículo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VeículoSet] DROP CONSTRAINT [FK_FuncionárioVeículo];
GO
IF OBJECT_ID(N'[dbo].[FK_HistóricoManutenção]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ManutençãoSet] DROP CONSTRAINT [FK_HistóricoManutenção];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionárioManutenção]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ManutençãoSet] DROP CONSTRAINT [FK_FuncionárioManutenção];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionárioReserva]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReservaSet] DROP CONSTRAINT [FK_FuncionárioReserva];
GO
IF OBJECT_ID(N'[dbo].[FK_HistóricoLocação]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LocaçãoSet] DROP CONSTRAINT [FK_HistóricoLocação];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionárioLocação]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LocaçãoSet] DROP CONSTRAINT [FK_FuncionárioLocação];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteLocação]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LocaçãoSet] DROP CONSTRAINT [FK_ClienteLocação];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteReserva]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReservaSet] DROP CONSTRAINT [FK_ClienteReserva];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteEndereço]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClienteSet] DROP CONSTRAINT [FK_ClienteEndereço];
GO
IF OBJECT_ID(N'[dbo].[FK_LoginCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClienteSet] DROP CONSTRAINT [FK_LoginCliente];
GO
IF OBJECT_ID(N'[dbo].[FK_LoginFuncionário]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FuncionárioSet] DROP CONSTRAINT [FK_LoginFuncionário];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[VeículoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VeículoSet];
GO
IF OBJECT_ID(N'[dbo].[HistóricoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HistóricoSet];
GO
IF OBJECT_ID(N'[dbo].[RelatórioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RelatórioSet];
GO
IF OBJECT_ID(N'[dbo].[ModeloSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ModeloSet];
GO
IF OBJECT_ID(N'[dbo].[FuncionárioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FuncionárioSet];
GO
IF OBJECT_ID(N'[dbo].[LocaçãoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LocaçãoSet];
GO
IF OBJECT_ID(N'[dbo].[ReservaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReservaSet];
GO
IF OBJECT_ID(N'[dbo].[ManutençãoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ManutençãoSet];
GO
IF OBJECT_ID(N'[dbo].[ClienteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClienteSet];
GO
IF OBJECT_ID(N'[dbo].[EndereçoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EndereçoSet];
GO
IF OBJECT_ID(N'[dbo].[LoginSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LoginSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'VeículoSet'
CREATE TABLE [dbo].[VeículoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Cor] nvarchar(max)  NOT NULL,
    [Ano] int  NOT NULL,
    [Categoria] nvarchar(max)  NOT NULL,
    [Quilometragem] int  NOT NULL,
    [Estado] tinyint  NOT NULL,
    [Histórico_Id] int  NOT NULL,
    [Modelo_Id] int  NOT NULL,
    [Funcionário_Id] int  NOT NULL
);
GO

-- Creating table 'HistóricoSet'
CREATE TABLE [dbo].[HistóricoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Relatório_Id] int  NOT NULL
);
GO

-- Creating table 'RelatórioSet'
CREATE TABLE [dbo].[RelatórioSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Funcionário_Id] int  NOT NULL
);
GO

-- Creating table 'ModeloSet'
CREATE TABLE [dbo].[ModeloSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Fornecedor] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FuncionárioSet'
CREATE TABLE [dbo].[FuncionárioSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [CarteiraDeTrabalho] nvarchar(max)  NOT NULL,
    [Salário] float  NOT NULL,
    [Função] tinyint  NOT NULL,
    [Login_Id] int  NOT NULL
);
GO

-- Creating table 'LocaçãoSet'
CREATE TABLE [dbo].[LocaçãoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Inicio] nvarchar(max)  NOT NULL,
    [Fim] nvarchar(max)  NOT NULL,
    [Histórico_Id] int  NOT NULL,
    [Funcionário_Id] int  NOT NULL,
    [Cliente_Id] int  NOT NULL
);
GO

-- Creating table 'ReservaSet'
CREATE TABLE [dbo].[ReservaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Data] nvarchar(max)  NOT NULL,
    [Veículo_Id] int  NOT NULL,
    [Funcionário_Id] int  NOT NULL,
    [Cliente_Id] int  NOT NULL
);
GO

-- Creating table 'ManutençãoSet'
CREATE TABLE [dbo].[ManutençãoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Inicio] nvarchar(max)  NOT NULL,
    [Fim] nvarchar(max)  NOT NULL,
    [Motivo] nvarchar(max)  NOT NULL,
    [Histórico_Id] int  NOT NULL,
    [Funcionário_Id] int  NOT NULL
);
GO

-- Creating table 'ClienteSet'
CREATE TABLE [dbo].[ClienteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [CPF] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Notificação] nvarchar(max)  NOT NULL,
    [Endereço_Id] int  NOT NULL,
    [Login_Id] int  NOT NULL
);
GO

-- Creating table 'EndereçoSet'
CREATE TABLE [dbo].[EndereçoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UF] nvarchar(max)  NOT NULL,
    [Cidade] nvarchar(max)  NOT NULL,
    [Bairro] nvarchar(max)  NOT NULL,
    [Rua] nvarchar(max)  NOT NULL,
    [Número] int  NOT NULL,
    [CEP] int  NOT NULL
);
GO

-- Creating table 'LoginSet'
CREATE TABLE [dbo].[LoginSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Usuário] nvarchar(max)  NOT NULL,
    [Senha] nvarchar(max)  NOT NULL,
    [Permissão] tinyint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'VeículoSet'
ALTER TABLE [dbo].[VeículoSet]
ADD CONSTRAINT [PK_VeículoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HistóricoSet'
ALTER TABLE [dbo].[HistóricoSet]
ADD CONSTRAINT [PK_HistóricoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RelatórioSet'
ALTER TABLE [dbo].[RelatórioSet]
ADD CONSTRAINT [PK_RelatórioSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ModeloSet'
ALTER TABLE [dbo].[ModeloSet]
ADD CONSTRAINT [PK_ModeloSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FuncionárioSet'
ALTER TABLE [dbo].[FuncionárioSet]
ADD CONSTRAINT [PK_FuncionárioSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LocaçãoSet'
ALTER TABLE [dbo].[LocaçãoSet]
ADD CONSTRAINT [PK_LocaçãoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ReservaSet'
ALTER TABLE [dbo].[ReservaSet]
ADD CONSTRAINT [PK_ReservaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ManutençãoSet'
ALTER TABLE [dbo].[ManutençãoSet]
ADD CONSTRAINT [PK_ManutençãoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClienteSet'
ALTER TABLE [dbo].[ClienteSet]
ADD CONSTRAINT [PK_ClienteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EndereçoSet'
ALTER TABLE [dbo].[EndereçoSet]
ADD CONSTRAINT [PK_EndereçoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LoginSet'
ALTER TABLE [dbo].[LoginSet]
ADD CONSTRAINT [PK_LoginSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Histórico_Id] in table 'VeículoSet'
ALTER TABLE [dbo].[VeículoSet]
ADD CONSTRAINT [FK_VeículoHistórico]
    FOREIGN KEY ([Histórico_Id])
    REFERENCES [dbo].[HistóricoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VeículoHistórico'
CREATE INDEX [IX_FK_VeículoHistórico]
ON [dbo].[VeículoSet]
    ([Histórico_Id]);
GO

-- Creating foreign key on [Veículo_Id] in table 'ReservaSet'
ALTER TABLE [dbo].[ReservaSet]
ADD CONSTRAINT [FK_ReservaVeículo]
    FOREIGN KEY ([Veículo_Id])
    REFERENCES [dbo].[VeículoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ReservaVeículo'
CREATE INDEX [IX_FK_ReservaVeículo]
ON [dbo].[ReservaSet]
    ([Veículo_Id]);
GO

-- Creating foreign key on [Relatório_Id] in table 'HistóricoSet'
ALTER TABLE [dbo].[HistóricoSet]
ADD CONSTRAINT [FK_HistóricoRelatório]
    FOREIGN KEY ([Relatório_Id])
    REFERENCES [dbo].[RelatórioSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HistóricoRelatório'
CREATE INDEX [IX_FK_HistóricoRelatório]
ON [dbo].[HistóricoSet]
    ([Relatório_Id]);
GO

-- Creating foreign key on [Modelo_Id] in table 'VeículoSet'
ALTER TABLE [dbo].[VeículoSet]
ADD CONSTRAINT [FK_VeículoModelo]
    FOREIGN KEY ([Modelo_Id])
    REFERENCES [dbo].[ModeloSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VeículoModelo'
CREATE INDEX [IX_FK_VeículoModelo]
ON [dbo].[VeículoSet]
    ([Modelo_Id]);
GO

-- Creating foreign key on [Funcionário_Id] in table 'RelatórioSet'
ALTER TABLE [dbo].[RelatórioSet]
ADD CONSTRAINT [FK_FuncionárioRelatório]
    FOREIGN KEY ([Funcionário_Id])
    REFERENCES [dbo].[FuncionárioSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionárioRelatório'
CREATE INDEX [IX_FK_FuncionárioRelatório]
ON [dbo].[RelatórioSet]
    ([Funcionário_Id]);
GO

-- Creating foreign key on [Funcionário_Id] in table 'VeículoSet'
ALTER TABLE [dbo].[VeículoSet]
ADD CONSTRAINT [FK_FuncionárioVeículo]
    FOREIGN KEY ([Funcionário_Id])
    REFERENCES [dbo].[FuncionárioSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionárioVeículo'
CREATE INDEX [IX_FK_FuncionárioVeículo]
ON [dbo].[VeículoSet]
    ([Funcionário_Id]);
GO

-- Creating foreign key on [Histórico_Id] in table 'ManutençãoSet'
ALTER TABLE [dbo].[ManutençãoSet]
ADD CONSTRAINT [FK_HistóricoManutenção]
    FOREIGN KEY ([Histórico_Id])
    REFERENCES [dbo].[HistóricoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HistóricoManutenção'
CREATE INDEX [IX_FK_HistóricoManutenção]
ON [dbo].[ManutençãoSet]
    ([Histórico_Id]);
GO

-- Creating foreign key on [Funcionário_Id] in table 'ManutençãoSet'
ALTER TABLE [dbo].[ManutençãoSet]
ADD CONSTRAINT [FK_FuncionárioManutenção]
    FOREIGN KEY ([Funcionário_Id])
    REFERENCES [dbo].[FuncionárioSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionárioManutenção'
CREATE INDEX [IX_FK_FuncionárioManutenção]
ON [dbo].[ManutençãoSet]
    ([Funcionário_Id]);
GO

-- Creating foreign key on [Funcionário_Id] in table 'ReservaSet'
ALTER TABLE [dbo].[ReservaSet]
ADD CONSTRAINT [FK_FuncionárioReserva]
    FOREIGN KEY ([Funcionário_Id])
    REFERENCES [dbo].[FuncionárioSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionárioReserva'
CREATE INDEX [IX_FK_FuncionárioReserva]
ON [dbo].[ReservaSet]
    ([Funcionário_Id]);
GO

-- Creating foreign key on [Histórico_Id] in table 'LocaçãoSet'
ALTER TABLE [dbo].[LocaçãoSet]
ADD CONSTRAINT [FK_HistóricoLocação]
    FOREIGN KEY ([Histórico_Id])
    REFERENCES [dbo].[HistóricoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HistóricoLocação'
CREATE INDEX [IX_FK_HistóricoLocação]
ON [dbo].[LocaçãoSet]
    ([Histórico_Id]);
GO

-- Creating foreign key on [Funcionário_Id] in table 'LocaçãoSet'
ALTER TABLE [dbo].[LocaçãoSet]
ADD CONSTRAINT [FK_FuncionárioLocação]
    FOREIGN KEY ([Funcionário_Id])
    REFERENCES [dbo].[FuncionárioSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionárioLocação'
CREATE INDEX [IX_FK_FuncionárioLocação]
ON [dbo].[LocaçãoSet]
    ([Funcionário_Id]);
GO

-- Creating foreign key on [Cliente_Id] in table 'LocaçãoSet'
ALTER TABLE [dbo].[LocaçãoSet]
ADD CONSTRAINT [FK_ClienteLocação]
    FOREIGN KEY ([Cliente_Id])
    REFERENCES [dbo].[ClienteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteLocação'
CREATE INDEX [IX_FK_ClienteLocação]
ON [dbo].[LocaçãoSet]
    ([Cliente_Id]);
GO

-- Creating foreign key on [Cliente_Id] in table 'ReservaSet'
ALTER TABLE [dbo].[ReservaSet]
ADD CONSTRAINT [FK_ClienteReserva]
    FOREIGN KEY ([Cliente_Id])
    REFERENCES [dbo].[ClienteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteReserva'
CREATE INDEX [IX_FK_ClienteReserva]
ON [dbo].[ReservaSet]
    ([Cliente_Id]);
GO

-- Creating foreign key on [Endereço_Id] in table 'ClienteSet'
ALTER TABLE [dbo].[ClienteSet]
ADD CONSTRAINT [FK_ClienteEndereço]
    FOREIGN KEY ([Endereço_Id])
    REFERENCES [dbo].[EndereçoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteEndereço'
CREATE INDEX [IX_FK_ClienteEndereço]
ON [dbo].[ClienteSet]
    ([Endereço_Id]);
GO

-- Creating foreign key on [Login_Id] in table 'ClienteSet'
ALTER TABLE [dbo].[ClienteSet]
ADD CONSTRAINT [FK_LoginCliente]
    FOREIGN KEY ([Login_Id])
    REFERENCES [dbo].[LoginSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LoginCliente'
CREATE INDEX [IX_FK_LoginCliente]
ON [dbo].[ClienteSet]
    ([Login_Id]);
GO

-- Creating foreign key on [Login_Id] in table 'FuncionárioSet'
ALTER TABLE [dbo].[FuncionárioSet]
ADD CONSTRAINT [FK_LoginFuncionário]
    FOREIGN KEY ([Login_Id])
    REFERENCES [dbo].[LoginSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LoginFuncionário'
CREATE INDEX [IX_FK_LoginFuncionário]
ON [dbo].[FuncionárioSet]
    ([Login_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------