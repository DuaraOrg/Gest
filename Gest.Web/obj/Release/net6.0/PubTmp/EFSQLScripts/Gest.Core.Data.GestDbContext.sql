IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE TABLE [Users] (
        [Id] uniqueidentifier NOT NULL,
        [FirstName] nvarchar(max) NOT NULL,
        [LastName] nvarchar(max) NOT NULL,
        [ProfileUrl] nvarchar(max) NULL,
        [Email] nvarchar(450) NOT NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PasswordHash] nvarchar(max) NOT NULL,
        [PasswordSalt] nvarchar(max) NOT NULL,
        [CreatedAt] datetime2 NOT NULL,
        [UpdatedAt] datetime2 NOT NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE TABLE [Wallets] (
        [Id] uniqueidentifier NOT NULL,
        [Cash_Amount] decimal(18,2) NOT NULL,
        [Cash_LastUpdated] datetime2 NOT NULL,
        [Credit_Amount] decimal(18,2) NOT NULL,
        [Credit_LastUpdated] datetime2 NOT NULL,
        [Bank_AccountNumber] nvarchar(max) NOT NULL,
        [Bank_Amount] decimal(18,2) NOT NULL,
        [Bank_LastUpdated] datetime2 NOT NULL,
        [CreatedAt] datetime2 NOT NULL,
        [UpdatedAt] datetime2 NOT NULL,
        CONSTRAINT [PK_Wallets] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE TABLE [Companies] (
        [Id] uniqueidentifier NOT NULL,
        [Name] nvarchar(max) NOT NULL,
        [Adress] nvarchar(max) NULL,
        [FCToDollarRate] decimal(18,2) NOT NULL,
        [WalletId] uniqueidentifier NULL,
        [CreatedAt] datetime2 NOT NULL,
        [UpdatedAt] datetime2 NOT NULL,
        CONSTRAINT [PK_Companies] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Companies_Wallets_WalletId] FOREIGN KEY ([WalletId]) REFERENCES [Wallets] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE TABLE [WalletMovement] (
        [Id] uniqueidentifier NOT NULL,
        [FromWalletId] uniqueidentifier NULL,
        [FromAccountType] nvarchar(max) NOT NULL,
        [ToWalletId] uniqueidentifier NOT NULL,
        [ToAccountType] nvarchar(max) NOT NULL,
        [TransType] nvarchar(max) NOT NULL,
        [Amount] decimal(18,2) NOT NULL,
        [Date] datetime2 NOT NULL,
        CONSTRAINT [PK_WalletMovement] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_WalletMovement_Wallets_ToWalletId] FOREIGN KEY ([ToWalletId]) REFERENCES [Wallets] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE TABLE [Branches] (
        [Id] uniqueidentifier NOT NULL,
        [Name] nvarchar(max) NOT NULL,
        [FCToDollarRate] decimal(18,2) NOT NULL,
        [CompanyId] uniqueidentifier NOT NULL,
        [CreatedAt] datetime2 NOT NULL,
        [UpdatedAt] datetime2 NOT NULL,
        CONSTRAINT [PK_Branches] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Branches_Companies_CompanyId] FOREIGN KEY ([CompanyId]) REFERENCES [Companies] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE TABLE [Clients] (
        [Id] uniqueidentifier NOT NULL,
        [Names] nvarchar(max) NOT NULL,
        [Email] nvarchar(max) NULL,
        [Phone] nvarchar(max) NULL,
        [Type] nvarchar(max) NULL,
        [CompanyId] uniqueidentifier NOT NULL,
        [WalletId] uniqueidentifier NULL,
        [CreatedAt] datetime2 NOT NULL,
        [UpdatedAt] datetime2 NOT NULL,
        CONSTRAINT [PK_Clients] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Clients_Companies_CompanyId] FOREIGN KEY ([CompanyId]) REFERENCES [Companies] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Clients_Wallets_WalletId] FOREIGN KEY ([WalletId]) REFERENCES [Wallets] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE TABLE [UserCompanies] (
        [UserId] uniqueidentifier NOT NULL,
        [CompanyId] uniqueidentifier NOT NULL,
        [Role] nvarchar(max) NOT NULL,
        [Joined] datetime2 NOT NULL,
        [UpdatedAt] datetime2 NOT NULL,
        CONSTRAINT [PK_UserCompanies] PRIMARY KEY ([UserId], [CompanyId]),
        CONSTRAINT [FK_UserCompanies_Companies_CompanyId] FOREIGN KEY ([CompanyId]) REFERENCES [Companies] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_UserCompanies_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE TABLE [Articles] (
        [Id] uniqueidentifier NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [UnitOfMeasure] nvarchar(max) NOT NULL,
        [ImageUrl] nvarchar(max) NULL,
        [Stock_Minimum] float NOT NULL,
        [Stock_Maximum] float NULL,
        [Stock_Qty] float NOT NULL,
        [Conditionnement_Name] nvarchar(max) NULL,
        [Conditionnement_QtyPerUnitOfMeasure] float NULL,
        [Category] nvarchar(max) NOT NULL,
        [Price_BuyingPricePerUnitOfMeasure] decimal(18,2) NOT NULL,
        [Price_BuyingPricePerConditionnement] decimal(18,2) NULL,
        [Price_SellingPricePerUnitOfMeasure] decimal(18,2) NOT NULL,
        [Price_SellingPricePerConditionnement] decimal(18,2) NULL,
        [CompanyId] uniqueidentifier NOT NULL,
        [BranchId] uniqueidentifier NOT NULL,
        [CreatedAt] datetime2 NOT NULL,
        [UpdatedAt] datetime2 NOT NULL,
        CONSTRAINT [PK_Articles] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Articles_Branches_BranchId] FOREIGN KEY ([BranchId]) REFERENCES [Branches] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Articles_Companies_CompanyId] FOREIGN KEY ([CompanyId]) REFERENCES [Companies] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE TABLE [Sales] (
        [Id] uniqueidentifier NOT NULL,
        [ClientId] uniqueidentifier NOT NULL,
        [PayStatus] nvarchar(max) NOT NULL,
        [DeliverStatus] nvarchar(max) NOT NULL,
        [TotalAmount] decimal(18,2) NOT NULL,
        [AmountPaid] decimal(18,2) NOT NULL,
        [CompanyId] uniqueidentifier NOT NULL,
        [BranchId] uniqueidentifier NOT NULL,
        [SellerId] uniqueidentifier NOT NULL,
        [ArticleId] uniqueidentifier NULL,
        [CreatedAt] datetime2 NOT NULL,
        [UpdatedAt] datetime2 NOT NULL,
        CONSTRAINT [PK_Sales] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Sales_Articles_ArticleId] FOREIGN KEY ([ArticleId]) REFERENCES [Articles] ([Id]),
        CONSTRAINT [FK_Sales_Branches_BranchId] FOREIGN KEY ([BranchId]) REFERENCES [Branches] ([Id]),
        CONSTRAINT [FK_Sales_Clients_ClientId] FOREIGN KEY ([ClientId]) REFERENCES [Clients] ([Id]),
        CONSTRAINT [FK_Sales_Companies_CompanyId] FOREIGN KEY ([CompanyId]) REFERENCES [Companies] ([Id]),
        CONSTRAINT [FK_Sales_Users_SellerId] FOREIGN KEY ([SellerId]) REFERENCES [Users] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE TABLE [StockMouvements] (
        [Id] uniqueidentifier NOT NULL,
        [ArticleId] uniqueidentifier NOT NULL,
        [State] nvarchar(max) NOT NULL,
        [Qty] float NOT NULL,
        [PrevStock] float NOT NULL,
        [NewStock] float NOT NULL,
        [NewBuyingPrice] decimal(18,2) NOT NULL,
        [NewSellingPrice] decimal(18,2) NOT NULL,
        [PrevBuyingPrice] decimal(18,2) NOT NULL,
        [PrevSellingPrice] decimal(18,2) NOT NULL,
        [Date] datetime2 NOT NULL,
        CONSTRAINT [PK_StockMouvements] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_StockMouvements_Articles_ArticleId] FOREIGN KEY ([ArticleId]) REFERENCES [Articles] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE TABLE [Payments] (
        [Id] uniqueidentifier NOT NULL,
        [ClientId] uniqueidentifier NULL,
        [CompanyId] uniqueidentifier NOT NULL,
        [UserId] uniqueidentifier NOT NULL,
        [Amount] decimal(18,2) NOT NULL,
        [AccountType] nvarchar(max) NOT NULL,
        [TransType] nvarchar(max) NOT NULL,
        [SaleId] uniqueidentifier NULL,
        [CreatedAt] datetime2 NOT NULL,
        [UpdatedAt] datetime2 NOT NULL,
        CONSTRAINT [PK_Payments] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Payments_Clients_ClientId] FOREIGN KEY ([ClientId]) REFERENCES [Clients] ([Id]),
        CONSTRAINT [FK_Payments_Companies_CompanyId] FOREIGN KEY ([CompanyId]) REFERENCES [Companies] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Payments_Sales_SaleId] FOREIGN KEY ([SaleId]) REFERENCES [Sales] ([Id]),
        CONSTRAINT [FK_Payments_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE TABLE [SaleItem] (
        [SaleId] uniqueidentifier NOT NULL,
        [Id] int NOT NULL IDENTITY,
        [ArticleId] uniqueidentifier NOT NULL,
        [QtyInUnitOfMeasure] float NOT NULL,
        [QtyDelivered] float NOT NULL,
        [UnitPricePerUnitOfMeasure] decimal(18,2) NOT NULL,
        CONSTRAINT [PK_SaleItem] PRIMARY KEY ([SaleId], [Id]),
        CONSTRAINT [FK_SaleItem_Articles_ArticleId] FOREIGN KEY ([ArticleId]) REFERENCES [Articles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_SaleItem_Sales_SaleId] FOREIGN KEY ([SaleId]) REFERENCES [Sales] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Adress', N'CreatedAt', N'FCToDollarRate', N'Name', N'UpdatedAt', N'WalletId') AND [object_id] = OBJECT_ID(N'[Companies]'))
        SET IDENTITY_INSERT [Companies] ON;
    EXEC(N'INSERT INTO [Companies] ([Id], [Adress], [CreatedAt], [FCToDollarRate], [Name], [UpdatedAt], [WalletId])
    VALUES (''afdc3370-adb1-4de9-ad12-7678145b4485'', N''Bunia'', ''2022-03-08T18:58:14.1578906Z'', 2000.0, N''Ets TUUNGANE'', ''2022-03-08T18:58:14.1578903Z'', NULL)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Adress', N'CreatedAt', N'FCToDollarRate', N'Name', N'UpdatedAt', N'WalletId') AND [object_id] = OBJECT_ID(N'[Companies]'))
        SET IDENTITY_INSERT [Companies] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedAt', N'Email', N'FirstName', N'LastName', N'PasswordHash', N'PasswordSalt', N'PhoneNumber', N'ProfileUrl', N'UpdatedAt') AND [object_id] = OBJECT_ID(N'[Users]'))
        SET IDENTITY_INSERT [Users] ON;
    EXEC(N'INSERT INTO [Users] ([Id], [CreatedAt], [Email], [FirstName], [LastName], [PasswordHash], [PasswordSalt], [PhoneNumber], [ProfileUrl], [UpdatedAt])
    VALUES (''d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9'', ''2022-03-08T18:58:14.1578874Z'', N''admin@swala.com'', N''Admin'', N''Swala'', N''OntNV7WL9lhYeZ5LXVxX84XlcBv+d4mC8TpEUTZyD+xwbaLGwWJwcidKq7C3nXEasKrU+e09Pi7wu9BNgqDVBdFtogHMTcegtNzinL6gesSPsICv9XRiQo0nw60E8TmH/2yLJFcOTauDNMHiRFz6d+1dKVNhV92kHGrCIF7ODmuOk0yv2X2jzBgF6Dx4AdMxYZHS54po9dXwdUh/39ss3+JEqDyWtiQNDxK2vL6qXs85laKgtiOcUrE7wvEkfkwc1meyo0aZEzyukpQybCXinMQ2eCnOTYE5rVFWMxdSkRBunW/wqtWUUfaaPQ9I/zBHE+p4+nEa7cVggdEVIlqknA=='', N''sp66BJ8qsud3AkG2uSmiUD/b3BgX2UWwbBIJuFcYHvBsn75oxcy/m/AfoaTEQyirfzRygH0VIS6uxmRshZ9/8A=='', NULL, NULL, ''2022-03-08T18:58:14.1578847Z'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedAt', N'Email', N'FirstName', N'LastName', N'PasswordHash', N'PasswordSalt', N'PhoneNumber', N'ProfileUrl', N'UpdatedAt') AND [object_id] = OBJECT_ID(N'[Users]'))
        SET IDENTITY_INSERT [Users] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CompanyId', N'CreatedAt', N'FCToDollarRate', N'Name', N'UpdatedAt') AND [object_id] = OBJECT_ID(N'[Branches]'))
        SET IDENTITY_INSERT [Branches] ON;
    EXEC(N'INSERT INTO [Branches] ([Id], [CompanyId], [CreatedAt], [FCToDollarRate], [Name], [UpdatedAt])
    VALUES (''453412a3-578b-446b-9406-bd7077bdce01'', ''afdc3370-adb1-4de9-ad12-7678145b4485'', ''2022-03-08T18:58:14.1578915Z'', 2000.0, N''Default'', ''2022-03-08T18:58:14.1578909Z'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CompanyId', N'CreatedAt', N'FCToDollarRate', N'Name', N'UpdatedAt') AND [object_id] = OBJECT_ID(N'[Branches]'))
        SET IDENTITY_INSERT [Branches] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CompanyId', N'CreatedAt', N'Email', N'Names', N'Phone', N'Type', N'UpdatedAt', N'WalletId') AND [object_id] = OBJECT_ID(N'[Clients]'))
        SET IDENTITY_INSERT [Clients] ON;
    EXEC(N'INSERT INTO [Clients] ([Id], [CompanyId], [CreatedAt], [Email], [Names], [Phone], [Type], [UpdatedAt], [WalletId])
    VALUES (''654412a3-578b-446b-9406-bd7077bdce01'', ''afdc3370-adb1-4de9-ad12-7678145b4485'', ''2022-03-08T18:58:14.1578922Z'', N''clientanonyme@swala.com'', N''Client Anonyme'', NULL, NULL, ''2022-03-08T18:58:14.1578919Z'', NULL)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CompanyId', N'CreatedAt', N'Email', N'Names', N'Phone', N'Type', N'UpdatedAt', N'WalletId') AND [object_id] = OBJECT_ID(N'[Clients]'))
        SET IDENTITY_INSERT [Clients] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CompanyId', N'UserId', N'Joined', N'Role', N'UpdatedAt') AND [object_id] = OBJECT_ID(N'[UserCompanies]'))
        SET IDENTITY_INSERT [UserCompanies] ON;
    EXEC(N'INSERT INTO [UserCompanies] ([CompanyId], [UserId], [Joined], [Role], [UpdatedAt])
    VALUES (''afdc3370-adb1-4de9-ad12-7678145b4485'', ''d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9'', ''2022-03-08T18:58:14.1578883Z'', N''Propriétaire'', ''0001-01-01T00:00:00.0000000'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CompanyId', N'UserId', N'Joined', N'Role', N'UpdatedAt') AND [object_id] = OBJECT_ID(N'[UserCompanies]'))
        SET IDENTITY_INSERT [UserCompanies] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE INDEX [IX_Articles_BranchId] ON [Articles] ([BranchId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE INDEX [IX_Articles_CompanyId] ON [Articles] ([CompanyId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE UNIQUE INDEX [IX_Articles_Name] ON [Articles] ([Name]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE INDEX [IX_Branches_CompanyId] ON [Branches] ([CompanyId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE INDEX [IX_Clients_CompanyId] ON [Clients] ([CompanyId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE INDEX [IX_Clients_WalletId] ON [Clients] ([WalletId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE INDEX [IX_Companies_WalletId] ON [Companies] ([WalletId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE INDEX [IX_Payments_ClientId] ON [Payments] ([ClientId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE INDEX [IX_Payments_CompanyId] ON [Payments] ([CompanyId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE INDEX [IX_Payments_SaleId] ON [Payments] ([SaleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE INDEX [IX_Payments_UserId] ON [Payments] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE INDEX [IX_SaleItem_ArticleId] ON [SaleItem] ([ArticleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE INDEX [IX_Sales_ArticleId] ON [Sales] ([ArticleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE INDEX [IX_Sales_BranchId] ON [Sales] ([BranchId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE INDEX [IX_Sales_ClientId] ON [Sales] ([ClientId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE INDEX [IX_Sales_CompanyId] ON [Sales] ([CompanyId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE INDEX [IX_Sales_SellerId] ON [Sales] ([SellerId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE INDEX [IX_StockMouvements_ArticleId] ON [StockMouvements] ([ArticleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE INDEX [IX_UserCompanies_CompanyId] ON [UserCompanies] ([CompanyId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE UNIQUE INDEX [IX_Users_Email] ON [Users] ([Email]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    CREATE INDEX [IX_WalletMovement_ToWalletId] ON [WalletMovement] ([ToWalletId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220308185814_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220308185814_InitialCreate', N'6.0.3');
END;
GO

COMMIT;
GO

