USE [new-database]
GO

/****** Object: Table [dbo].[tblEmployee] Script Date: 6/21/2023 4:39:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblEmployeev2] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
	[Name] varchar(255) not null,
	[EmployeeId] varchar(255) not null,
	[PhoneNumber] varchar(20) not null,
	[Location] varchar(255) not null
);


