CREATE TABLE LogEventTable (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    VolunteerName NVARCHAR(100),
    EventName NVARCHAR(100),
    DateWorked DATETIME,
    HoursWorked DECIMAL(10, 2)
);