IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'MalikaTechMarketDB')
    CREATE DATABASE MalikaTechMarketDB;
GO

USE MalikaTechMarketDB;
GO

DECLARE @sql NVARCHAR(MAX) = '';
SELECT @sql += 'DROP PROCEDURE ' + QUOTENAME(name) + ';' + CHAR(10)
FROM sys.procedures;
EXEC sp_executesql @sql;
GO

IF OBJECT_ID('AuditLog',        'U') IS NOT NULL DROP TABLE AuditLog;
IF OBJECT_ID('ProductRequests', 'U') IS NOT NULL DROP TABLE ProductRequests;
IF OBJECT_ID('Products',        'U') IS NOT NULL DROP TABLE Products;
IF OBJECT_ID('Categories',      'U') IS NOT NULL DROP TABLE Categories;
IF OBJECT_ID('Users',           'U') IS NOT NULL DROP TABLE Users;
IF OBJECT_ID('Stores',          'U') IS NOT NULL DROP TABLE Stores;
IF OBJECT_ID('Roles',           'U') IS NOT NULL DROP TABLE Roles;
GO

-- ============================================================
--  TABLES
-- ============================================================

CREATE TABLE Roles (
    RoleId   INT          PRIMARY KEY IDENTITY(1,1),
    RoleName NVARCHAR(50) NOT NULL UNIQUE
);
GO

CREATE TABLE Stores (
    StoreId      INT           PRIMARY KEY IDENTITY(1,1),
    StoreName    NVARCHAR(100) NOT NULL,
    ContactPhone NVARCHAR(20)  NULL,
    IsActive     BIT           NOT NULL DEFAULT 1,
    CreatedAt    DATETIME      NOT NULL DEFAULT GETDATE()
);
GO

CREATE TABLE Users (
    UserId       INT           PRIMARY KEY IDENTITY(1,1),
    StoreId      INT           NULL REFERENCES Stores(StoreId),
    RoleId       INT           NOT NULL REFERENCES Roles(RoleId),
    Username     NVARCHAR(50)  NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    FullName     NVARCHAR(100) NOT NULL,
    IsActive     BIT           NOT NULL DEFAULT 1,
    CreatedAt    DATETIME      NOT NULL DEFAULT GETDATE()
);
GO

CREATE TABLE Categories (
    CategoryId   INT           PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(100) NOT NULL UNIQUE
);
GO

CREATE TABLE Products (
    ProductId    INT           PRIMARY KEY IDENTITY(1,1),
    StoreId      INT           NOT NULL REFERENCES Stores(StoreId),
    CategoryId   INT           NOT NULL REFERENCES Categories(CategoryId),
    ProductName  NVARCHAR(150) NOT NULL,
    SKU          NVARCHAR(50)  NOT NULL UNIQUE,
    Quantity     INT           NOT NULL DEFAULT 0,
    UnitPrice    DECIMAL(18,2) NOT NULL DEFAULT 0,
    MinThreshold INT           NOT NULL DEFAULT 5,
    Visibility   NVARCHAR(10)  NOT NULL DEFAULT 'PRIVATE'
                 CONSTRAINT CHK_Visibility CHECK (Visibility IN ('PUBLIC','PRIVATE')),
    Description  NVARCHAR(MAX) NULL,
    IsActive     BIT           NOT NULL DEFAULT 1,
    UpdatedAt    DATETIME      NOT NULL DEFAULT GETDATE()
);
GO

CREATE TABLE ProductRequests (
    RequestId         INT           PRIMARY KEY IDENTITY(1,1),
    RequesterStoreId  INT           NOT NULL REFERENCES Stores(StoreId),
    SupplierStoreId   INT           NOT NULL REFERENCES Stores(StoreId),
    ProductId         INT           NOT NULL REFERENCES Products(ProductId),
    QuantityRequested INT           NOT NULL,
    ProposedPrice     DECIMAL(18,2) NOT NULL,
    Status            NVARCHAR(10)  NOT NULL DEFAULT 'PENDING'
                      CONSTRAINT CHK_Status CHECK (Status IN ('PENDING','ACCEPTED','REJECTED')),
    RejectionNote     NVARCHAR(500) NULL,
    CreatedAt         DATETIME      NOT NULL DEFAULT GETDATE(),
    RespondedAt       DATETIME      NULL
);
GO

CREATE TABLE AuditLog (
    LogId        INT           PRIMARY KEY IDENTITY(1,1),
    UserId       INT           NULL REFERENCES Users(UserId),
    ActionType   NVARCHAR(50)  NOT NULL,
    ActionDetail NVARCHAR(500) NULL,
    LoggedAt     DATETIME      NOT NULL DEFAULT GETDATE()
);
GO

CREATE TABLE Contracts (
    ContractId     INT            PRIMARY KEY IDENTITY(1,1),
    StoreId        INT            NOT NULL REFERENCES Stores(StoreId),
    StartDate      DATE           NOT NULL,
    EndDate        DATE           NOT NULL,
    MonthlyRent    DECIMAL(10,2)  NOT NULL,
    ContractFile   NVARCHAR(500)  NULL,
    CreatedAt      DATETIME       NOT NULL DEFAULT GETDATE()
);
GO

-- ============================================================
--  SEED DATA
-- ============================================================

-- 1. Roles
INSERT INTO Roles (RoleName)
VALUES ('SuperAdmin'), ('StoreManager'), ('StoreStaff');

-- 2. Stores
INSERT INTO Stores (StoreName, IsActive) 
VALUES ('SYSTEM', 1);

INSERT INTO Stores (StoreName, ContactPhone) VALUES 
('A-21 Bekzod',      '+998977702121'),
('A-22 Mansur Aka',  '+998901234567'),
('B-05 Flash-Store', '+998935550011');

-- 3. Categories
INSERT INTO Categories (CategoryName) VALUES
    ('Laptops'), ('Desktops'), ('Components'),
    ('Peripherals'), ('Networking'), ('Storage'),
    ('Mobile Devices'), ('Accessories'), ('Other');

-- 4. Users
INSERT INTO Users (StoreId, RoleId, Username, PasswordHash, FullName)
VALUES (NULL, 1, 'admin', '1234', 'Super Administrator');

INSERT INTO Users (StoreId, RoleId, Username, PasswordHash, FullName) VALUES 
(2, 2, 'bekzod21',   '1234', 'Bekzod Abdullaev'),
(2, 3, 'jasur_pro',  '1234', 'Jasur Shogird'),
(3, 2, 'mansur_aka', '1234', 'Mansur Ismoilov'),
(4, 2, 'flash_aziz', '1234', 'Aziz Flash');

-- 5. Products
INSERT INTO Products 
(StoreId, CategoryId, ProductName, SKU, Quantity, UnitPrice, MinThreshold, Visibility, Description)
VALUES
(2, 1, 'MacBook Air M2 / 8 / 256',      'MAC-M2-SGR',   5,  12400000, 2, 'PUBLIC',  'Space Gray, 2023 model'),
(2, 7, 'iPhone 15 Pro 128GB',            'IPH-15P-NT',   2,  13500000, 3, 'PUBLIC',  'Natural Titanium'),
(2, 3, 'RTX 4090 ROG Strix',             'GPU-4090-ROG', 1,  28000000, 1, 'PRIVATE', 'Special order for client'),
(2, 4, 'Logitech G Pro X Superlight',   'MSE-LOG-GPRO', 15, 1800000,  5, 'PUBLIC',  'Best gaming mouse'),
(3, 1, 'ASUS TUF Gaming F15',           'LAP-ASU-TUF',  8,  10200000, 2, 'PUBLIC',  'i5-12500H / RTX 3050'),
(3, 7, 'Samsung S24 Ultra',             'MOB-SAM-S24U', 4,  14200000, 2, 'PUBLIC',  'Titanium Black, 256GB'),
(4, 5, 'MikroTik Cloud Core Router',    'NET-MIK-CCR',  3,  5600000,  1, 'PUBLIC',  'Enterprise router'),
(4, 3, 'Core i9-14900K',                'CPU-INT-I9',   10, 8500000,  2, 'PUBLIC',  'Box version, local warranty');

-- 6. Product Requests
-- Mansur (A-22) wants 2 MacBooks from Bekzod (A-21) - PENDING
INSERT INTO ProductRequests 
(RequesterStoreId, SupplierStoreId, ProductId, QuantityRequested, ProposedPrice, Status)
VALUES (3, 2, 1, 2, 12100000, 'PENDING');

-- Bekzod (A-21) wants 1 Samsung from Mansur (A-22) - ACCEPTED
INSERT INTO ProductRequests 
(RequesterStoreId, SupplierStoreId, ProductId, QuantityRequested, ProposedPrice, Status, RespondedAt)
VALUES (2, 3, 6, 1, 14000000, 'ACCEPTED', GETDATE());

-- Flash-Store wants RTX 4090 cheap - REJECTED
INSERT INTO ProductRequests 
(RequesterStoreId, SupplierStoreId, ProductId, QuantityRequested, ProposedPrice, Status, RejectionNote, RespondedAt)
VALUES (4, 2, 3, 1, 22000000, 'REJECTED', 'Uka, this price is impossible!', GETDATE());
GO

-- ============================================================
--  STORED PROCEDURES
-- ============================================================

-- ── ROLES ────────────────────────────────────────────────────
CREATE PROCEDURE sp_Roles_GetAll
AS
    SELECT RoleId, RoleName FROM Roles ORDER BY RoleId;
GO

-- ── STORES ───────────────────────────────────────────────────
CREATE PROCEDURE sp_Stores_GetAll
AS
    SELECT StoreId, StoreName, ContactPhone, IsActive, CreatedAt
    FROM   Stores WHERE StoreName != 'SYSTEM'
    ORDER  BY StoreName;
GO

CREATE PROCEDURE sp_Stores_GetAllActive
AS
    SELECT StoreId, StoreName, ContactPhone, IsActive, CreatedAt
    FROM   Stores WHERE IsActive = 1 AND StoreName != 'SYSTEM'
    ORDER  BY StoreName;
GO

CREATE PROCEDURE sp_Stores_GetById
    @StoreId INT
AS
    SELECT StoreId, StoreName, ContactPhone, IsActive, CreatedAt
    FROM   Stores WHERE StoreId = @StoreId;
GO

CREATE PROCEDURE sp_Stores_Insert
    @StoreName    NVARCHAR(100),
    @ContactPhone NVARCHAR(20)
AS
    INSERT INTO Stores (StoreName, ContactPhone)
    VALUES (@StoreName, @ContactPhone);
    SELECT SCOPE_IDENTITY() AS NewStoreId;
GO

CREATE PROCEDURE sp_Stores_Update
    @StoreId      INT,
    @StoreName    NVARCHAR(100),
    @ContactPhone NVARCHAR(20)
AS
    UPDATE Stores
    SET StoreName = @StoreName, ContactPhone = @ContactPhone
    WHERE StoreId = @StoreId;
GO

CREATE PROCEDURE sp_Stores_SetActiveStatus
    @StoreId INT, @IsActive BIT
AS
    UPDATE Stores SET IsActive = @IsActive WHERE StoreId = @StoreId;
GO

-- ── USERS ────────────────────────────────────────────────────
CREATE PROCEDURE sp_Users_GetAll
AS
    SELECT u.UserId,
           u.StoreId,
           ISNULL(s.StoreName, 'SYSTEM') AS StoreName,
           u.RoleId, r.RoleName,
           u.Username, u.FullName, u.IsActive, u.CreatedAt
    FROM   Users u
    LEFT JOIN Stores s ON u.StoreId = s.StoreId
    JOIN      Roles  r ON u.RoleId  = r.RoleId
    ORDER BY  u.FullName;
GO

CREATE PROCEDURE sp_Users_GetById
    @UserId INT
AS
    SELECT u.UserId,
           u.StoreId,
           ISNULL(s.StoreName, 'SYSTEM') AS StoreName,
           u.RoleId, r.RoleName,
           u.Username, u.PasswordHash, u.FullName, u.IsActive
    FROM   Users u
    LEFT JOIN Stores s ON u.StoreId = s.StoreId
    JOIN      Roles  r ON u.RoleId  = r.RoleId
    WHERE  u.UserId = @UserId;
GO

CREATE PROCEDURE sp_Users_GetByUsername
    @Username NVARCHAR(50)
AS
    SELECT u.UserId,
           u.StoreId,
           ISNULL(s.StoreName, 'SYSTEM') AS StoreName,
           u.RoleId, r.RoleName,
           u.Username, u.PasswordHash, u.FullName, u.IsActive
    FROM   Users u
    LEFT JOIN Stores s ON u.StoreId = s.StoreId
    JOIN      Roles  r ON u.RoleId  = r.RoleId
    WHERE  u.Username = @Username;
GO

CREATE PROCEDURE sp_Users_GetByStore
    @StoreId INT
AS
    SELECT u.UserId,
           u.StoreId,
           ISNULL(s.StoreName, '') AS StoreName,
           u.RoleId, r.RoleName,
           u.Username, u.PasswordHash, u.FullName, u.IsActive
    FROM   Users u
    LEFT JOIN Stores s ON u.StoreId = s.StoreId
    JOIN      Roles  r ON u.RoleId  = r.RoleId
    WHERE  u.StoreId = @StoreId
    ORDER BY u.FullName;
GO

CREATE PROCEDURE sp_Users_Insert
    @StoreId      INT,
    @RoleId       INT,
    @Username     NVARCHAR(50),
    @PasswordHash NVARCHAR(255),
    @FullName     NVARCHAR(100)
AS
    INSERT INTO Users (StoreId, RoleId, Username, PasswordHash, FullName)
    VALUES (@StoreId, @RoleId, @Username, @PasswordHash, @FullName);
    SELECT SCOPE_IDENTITY() AS NewUserId;
GO

CREATE PROCEDURE sp_Users_UpdateDetails
    @UserId INT, @StoreId INT, @RoleId INT, @FullName NVARCHAR(100)
AS
    UPDATE Users
    SET StoreId = @StoreId, RoleId = @RoleId, FullName = @FullName
    WHERE UserId = @UserId;
GO

CREATE PROCEDURE sp_Users_UpdatePassword
    @UserId INT, @PasswordHash NVARCHAR(255)
AS
    UPDATE Users SET PasswordHash = @PasswordHash WHERE UserId = @UserId;
GO

CREATE PROCEDURE sp_Users_SetActiveStatus
    @UserId INT, @IsActive BIT
AS
    UPDATE Users SET IsActive = @IsActive WHERE UserId = @UserId;
GO

-- ── CATEGORIES ───────────────────────────────────────────────
CREATE PROCEDURE sp_Categories_GetAll
AS
    SELECT CategoryId, CategoryName FROM Categories ORDER BY CategoryName;
GO

-- ── PRODUCTS ─────────────────────────────────────────────────
CREATE PROCEDURE sp_Products_GetByStore
    @StoreId INT
AS
    SELECT p.ProductId, p.StoreId, p.CategoryId, c.CategoryName,
           p.ProductName, p.SKU, p.Quantity, p.UnitPrice,
           p.MinThreshold, p.Visibility, p.Description, p.UpdatedAt
    FROM   Products p
    JOIN   Categories c ON p.CategoryId = c.CategoryId
    WHERE  p.StoreId = @StoreId AND p.IsActive = 1
    ORDER  BY p.ProductName;
GO

CREATE PROCEDURE sp_Products_GetById
    @ProductId INT
AS
    SELECT p.ProductId, p.StoreId, p.CategoryId, c.CategoryName,
           p.ProductName, p.SKU, p.Quantity, p.UnitPrice,
           p.MinThreshold, p.Visibility, p.Description, p.UpdatedAt
    FROM   Products p
    JOIN   Categories c ON p.CategoryId = c.CategoryId
    WHERE  p.ProductId = @ProductId;
GO

CREATE PROCEDURE sp_Products_GetPublicExcludingStore
    @StoreId INT
AS
    SELECT p.ProductId, p.StoreId, s.StoreName,
           p.CategoryId, c.CategoryName,
           p.ProductName, p.SKU, p.Quantity, p.UnitPrice, p.Description
    FROM   Products p
    JOIN   Categories c ON p.CategoryId = c.CategoryId
    JOIN   Stores     s ON p.StoreId    = s.StoreId
    WHERE  p.Visibility = 'PUBLIC'
      AND  p.IsActive   = 1
      AND  p.StoreId   != @StoreId
      AND  p.Quantity   > 0
    ORDER  BY s.StoreName, p.ProductName;
GO

CREATE PROCEDURE sp_Products_Insert
    @StoreId INT, @CategoryId INT, @ProductName NVARCHAR(150),
    @SKU NVARCHAR(50), @Quantity INT, @UnitPrice DECIMAL(18,2),
    @MinThreshold INT, @Visibility NVARCHAR(10), @Description NVARCHAR(MAX)
AS
    INSERT INTO Products
        (StoreId, CategoryId, ProductName, SKU, Quantity,
         UnitPrice, MinThreshold, Visibility, Description)
    VALUES
        (@StoreId, @CategoryId, @ProductName, @SKU, @Quantity,
         @UnitPrice, @MinThreshold, @Visibility, @Description);
    SELECT SCOPE_IDENTITY() AS NewProductId;
GO

CREATE PROCEDURE sp_Products_Update
    @ProductId INT, @CategoryId INT, @ProductName NVARCHAR(150),
    @SKU NVARCHAR(50), @Quantity INT, @UnitPrice DECIMAL(18,2),
    @MinThreshold INT, @Visibility NVARCHAR(10), @Description NVARCHAR(MAX)
AS
    UPDATE Products
    SET CategoryId = @CategoryId, ProductName = @ProductName, SKU = @SKU,
        Quantity = @Quantity, UnitPrice = @UnitPrice, MinThreshold = @MinThreshold,
        Visibility = @Visibility, Description = @Description, UpdatedAt = GETDATE()
    WHERE ProductId = @ProductId;
GO

CREATE PROCEDURE sp_Products_ToggleVisibility
    @ProductId INT, @Visibility NVARCHAR(10)
AS
    UPDATE Products
    SET Visibility = @Visibility, UpdatedAt = GETDATE()
    WHERE ProductId = @ProductId;
GO

CREATE PROCEDURE sp_Products_SoftDelete
    @ProductId INT
AS
    UPDATE Products SET IsActive = 0, UpdatedAt = GETDATE()
    WHERE ProductId = @ProductId;
GO

-- ── PRODUCT REQUESTS ─────────────────────────────────────────
CREATE PROCEDURE sp_Requests_GetByRequester
    @RequesterStoreId INT
AS
    SELECT r.RequestId, ss.StoreName AS SupplierStoreName,
           p.ProductName, p.SKU,
           r.QuantityRequested, r.ProposedPrice,
           r.Status, r.RejectionNote, r.CreatedAt, r.RespondedAt
    FROM   ProductRequests r
    JOIN   Stores   ss ON r.SupplierStoreId = ss.StoreId
    JOIN   Products p  ON r.ProductId       = p.ProductId
    WHERE  r.RequesterStoreId = @RequesterStoreId
    ORDER  BY r.CreatedAt DESC;
GO

CREATE PROCEDURE sp_Requests_GetBySupplier
    @SupplierStoreId INT
AS
    SELECT r.RequestId, rs.StoreName AS RequesterStoreName,
           p.ProductName, p.SKU, p.UnitPrice AS OwnListedPrice,
           r.QuantityRequested, r.ProposedPrice,
           r.Status, r.RejectionNote, r.CreatedAt, r.RespondedAt
    FROM   ProductRequests r
    JOIN   Stores   rs ON r.RequesterStoreId = rs.StoreId
    JOIN   Products p  ON r.ProductId        = p.ProductId
    WHERE  r.SupplierStoreId = @SupplierStoreId
    ORDER  BY r.CreatedAt DESC;
GO

CREATE PROCEDURE sp_Requests_GetPendingCount
    @SupplierStoreId INT
AS
    SELECT COUNT(*) AS PendingCount
    FROM   ProductRequests
    WHERE  SupplierStoreId = @SupplierStoreId AND Status = 'PENDING';
GO

CREATE PROCEDURE sp_Requests_Insert
    @RequesterStoreId INT, @SupplierStoreId INT, @ProductId INT,
    @QuantityRequested INT, @ProposedPrice DECIMAL(18,2)
AS
    INSERT INTO ProductRequests
        (RequesterStoreId, SupplierStoreId, ProductId, QuantityRequested, ProposedPrice)
    VALUES
        (@RequesterStoreId, @SupplierStoreId, @ProductId, @QuantityRequested, @ProposedPrice);
    SELECT SCOPE_IDENTITY() AS NewRequestId;
GO

CREATE PROCEDURE sp_Requests_Respond
    @RequestId INT, @Status NVARCHAR(10), @RejectionNote NVARCHAR(500)
AS
    UPDATE ProductRequests
    SET Status = @Status, RejectionNote = @RejectionNote, RespondedAt = GETDATE()
    WHERE RequestId = @RequestId;
GO

-- ── AUDIT LOG ────────────────────────────────────────────────
CREATE PROCEDURE sp_Audit_Insert
    @UserId INT, @ActionType NVARCHAR(50), @ActionDetail NVARCHAR(500)
AS
    INSERT INTO AuditLog (UserId, ActionType, ActionDetail)
    VALUES (@UserId, @ActionType, @ActionDetail);
GO

CREATE PROCEDURE sp_Audit_GetAll
AS
    SELECT l.LogId,
           ISNULL(u.Username, 'SYSTEM') AS Username,
           ISNULL(u.FullName, 'System') AS FullName,
           l.ActionType, l.ActionDetail, l.LoggedAt
    FROM   AuditLog l
    LEFT JOIN Users u ON l.UserId = u.UserId
    ORDER  BY l.LoggedAt DESC;
GO

-- ── DASHBOARD ────────────────────────────────────────────────
CREATE PROCEDURE sp_Dashboard_GetStoreStats
    @StoreId INT
AS
    SELECT
        (SELECT COUNT(*) FROM Products
         WHERE StoreId = @StoreId AND IsActive = 1)                     AS TotalProducts,
        (SELECT COUNT(*) FROM Products
         WHERE StoreId = @StoreId AND IsActive = 1
           AND Visibility = 'PUBLIC')                                   AS PublicProducts,
        (SELECT COUNT(*) FROM Products
         WHERE StoreId = @StoreId AND IsActive = 1
           AND Quantity <= MinThreshold)                                 AS LowStockCount,
        (SELECT COUNT(*) FROM ProductRequests
         WHERE SupplierStoreId = @StoreId AND Status = 'PENDING')       AS PendingIncoming,
        (SELECT COUNT(*) FROM ProductRequests
         WHERE RequesterStoreId = @StoreId AND Status = 'PENDING')      AS PendingSent,
        (SELECT ISNULL(SUM(CAST(Quantity AS DECIMAL(18,2)) * UnitPrice), 0)
         FROM Products WHERE StoreId = @StoreId AND IsActive = 1)       AS TotalInventoryValue;
GO

CREATE PROCEDURE sp_Dashboard_GetAdminStats
AS
    SELECT
        (SELECT COUNT(*) FROM Stores WHERE StoreName != 'SYSTEM' AND IsActive = 1) AS TotalActiveStores,
        (SELECT COUNT(*) FROM Users  WHERE IsActive = 1)                           AS TotalActiveUsers,
        (SELECT COUNT(*) FROM Products WHERE IsActive = 1)                         AS TotalProducts,
        (SELECT COUNT(*) FROM ProductRequests WHERE Status = 'PENDING')            AS TotalPendingRequests;
GO

CREATE PROCEDURE sp_Dashboard_GetRequestStats
    @StoreId INT
AS
    SELECT
        (SELECT COUNT(*) FROM ProductRequests
         WHERE SupplierStoreId = @StoreId AND Status = 'ACCEPTED') AS AcceptedCount,
        (SELECT COUNT(*) FROM ProductRequests
         WHERE SupplierStoreId = @StoreId AND Status = 'REJECTED') AS RejectedCount;
GO

CREATE PROCEDURE sp_Dashboard_GetLastInventoryUpdate
    @StoreId INT
AS
    SELECT TOP 1 UpdatedAt
    FROM Products
    WHERE StoreId = @StoreId AND IsActive = 1
    ORDER BY UpdatedAt DESC;
GO

-- ── CONTRACTS ────────────────────────────────────────────────
CREATE PROCEDURE sp_Contracts_GetAll
AS
    SELECT c.ContractId, c.StoreId, s.StoreName,
           c.StartDate, c.EndDate, c.MonthlyRent,
           c.ContractFile, c.CreatedAt,
           DATEDIFF(DAY, GETDATE(), c.EndDate) AS DaysLeft
    FROM   Contracts c
    JOIN   Stores s ON c.StoreId = s.StoreId
    ORDER  BY c.EndDate ASC;
GO

CREATE PROCEDURE sp_Contracts_GetById
    @ContractId INT
AS
    SELECT c.ContractId, c.StoreId, s.StoreName,
           c.StartDate, c.EndDate, c.MonthlyRent,
           c.ContractFile, c.CreatedAt,
           DATEDIFF(DAY, GETDATE(), c.EndDate) AS DaysLeft
    FROM   Contracts c
    JOIN   Stores s ON c.StoreId = s.StoreId
    WHERE  c.ContractId = @ContractId;
GO

CREATE PROCEDURE sp_Contracts_GetExpiringSoon
AS
    SELECT c.ContractId, c.StoreId, s.StoreName,
           c.StartDate, c.EndDate, c.MonthlyRent,
           c.ContractFile,
           DATEDIFF(DAY, GETDATE(), c.EndDate) AS DaysLeft
    FROM   Contracts c
    JOIN   Stores s ON c.StoreId = s.StoreId
    WHERE  DATEDIFF(DAY, GETDATE(), c.EndDate) <= 15
      AND  DATEDIFF(DAY, GETDATE(), c.EndDate) >= 0
    ORDER  BY c.EndDate ASC;
GO

CREATE PROCEDURE sp_Contracts_Insert
    @StoreId      INT,
    @StartDate    DATE,
    @EndDate      DATE,
    @MonthlyRent  DECIMAL(10,2),
    @ContractFile NVARCHAR(500)
AS
    INSERT INTO Contracts (StoreId, StartDate, EndDate, MonthlyRent, ContractFile)
    VALUES (@StoreId, @StartDate, @EndDate, @MonthlyRent, @ContractFile);
    SELECT SCOPE_IDENTITY() AS NewContractId;
GO

CREATE PROCEDURE sp_Contracts_Update
    @ContractId   INT,
    @StoreId      INT,
    @StartDate    DATE,
    @EndDate      DATE,
    @MonthlyRent  DECIMAL(10,2),
    @ContractFile NVARCHAR(500)
AS
    UPDATE Contracts
    SET StoreId      = @StoreId,
        StartDate    = @StartDate,
        EndDate      = @EndDate,
        MonthlyRent  = @MonthlyRent,
        ContractFile = @ContractFile
    WHERE ContractId = @ContractId;
GO

CREATE PROCEDURE sp_Contracts_Delete
    @ContractId INT
AS
    DELETE FROM Contracts WHERE ContractId = @ContractId;
GO

-- ============================================================
PRINT '-------------------------------------------------------';
PRINT ' MalikaTechMarketDB setup complete!';
PRINT ' Tables  : 8';
PRINT ' Procs   : 32';
PRINT ' Login   -> Username: admin | Password: 1234';
PRINT '-------------------------------------------------------';
GO