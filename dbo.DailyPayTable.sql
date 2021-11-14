CREATE TABLE [dbo].[DailyPayment]
(
	[DailyId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT (newid()), 
    [Date] DATE NOT NULL, 
    [TimeStart] TIME NOT NULL, 
    [TimeEnd] TIME NOT NULL, 
    [TotalMinutes] INT NULL, 
    [TotalHours] DECIMAL NULL, 
    [HourlyRate] SMALLMONEY NOT NULL DEFAULT 2500, 
    [DailyPayment] SMALLMONEY NULL
)
