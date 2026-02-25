-- 1. Create the Database (Check if it exists first to avoid errors)
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'BengaluruCaresDB')
BEGIN
    CREATE DATABASE BengaluruCaresDB;
END
GO

USE BengaluruCaresDB;
GO

-- 2. Create the Users Table (For Login & Signup)
-- Matches your Signup.cs logic
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Users' AND xtype='U')
BEGIN
    CREATE TABLE Users (
        UserID INT IDENTITY(1,1) PRIMARY KEY,
        Username NVARCHAR(50) NOT NULL UNIQUE, -- Prevents duplicate usernames
        Email NVARCHAR(100) NOT NULL UNIQUE,   -- Prevents duplicate emails
        Mobile NVARCHAR(15) NOT NULL,
        PinCode NVARCHAR(10) NOT NULL,
        PasswordHash NVARCHAR(256) NOT NULL,   -- Stores the encrypted password
        CreatedAt DATETIME DEFAULT GETDATE()
    );
END
GO

-- 3. Create the VolunteerLog Table (For History, Rewards & Opportunities)
-- Matches your LogEvent.cs and OpportunitiesPage.cs logic
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='VolunteerLog' AND xtype='U')
BEGIN
    CREATE TABLE VolunteerLog (
        LogID INT IDENTITY(1,1) PRIMARY KEY,
        VolunteerName NVARCHAR(100) NOT NULL,
        EventName NVARCHAR(100) NOT NULL,
        DateWorked DATETIME NOT NULL,
        HoursWorked DECIMAL(10, 2) DEFAULT 0,
        -- Status can be: 'Pending' (waiting for approval), 'Done' (hours counted), or 'Upcoming' (applied)
        ReceiptStatus NVARCHAR(50) DEFAULT 'Pending' 
    );
END
GO

-- 4. (Optional) Insert some Dummy Data to test immediately
INSERT INTO VolunteerLog (VolunteerName, EventName, DateWorked, HoursWorked, ReceiptStatus)
VALUES 
('Simran', 'Lake Cleanup', '2025-01-15', 4.5, 'Done'),
('Simran', 'Teaching Kids', '2025-01-20', 2.0, 'Pending'),
('Simran', 'Food Drive', '2025-02-10', 0, 'Upcoming');
GO