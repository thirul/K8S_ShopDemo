USE master;
GO

IF DB_ID (N'eShopOrder') IS NOT NULL
	print 'exists'
	DROP DATABASE eShopOrder;
GO

CREATE DATABASE eShopOrder;
GO
-- Verify the database files and sizes
SELECT name, size, size*1.0/128 AS [Size in MBs]
FROM sys.master_files
WHERE name = 'eShopOrder';
GO

---
USE [eShopOrder]
GO 
----
CREATE TABLE Orders(Id int primary key not null identity(1,1), CustomerId int not null, OrderReference nvarchar(128) not null, OrderDate datetime not null);

---- 
INSERT INTO Orders VALUES ( 100, SUBSTRING(CONVERT(varchar(40), NEWID()),0,9), dateadd(month, -11, getdate()))
INSERT INTO Orders VALUES ( 101, SUBSTRING(CONVERT(varchar(40), NEWID()),0,9), dateadd(month, -2, getdate()))
INSERT INTO Orders VALUES ( 102, SUBSTRING(CONVERT(varchar(40), NEWID()),0,9), dateadd(month, -3, getdate()))
INSERT INTO Orders VALUES ( 103, SUBSTRING(CONVERT(varchar(40), NEWID()),0,9), dateadd(month, -1, getdate()))
INSERT INTO Orders VALUES ( 104, SUBSTRING(CONVERT(varchar(40), NEWID()),0,9), dateadd(month, -4, getdate()))
INSERT INTO Orders VALUES ( 105, SUBSTRING(CONVERT(varchar(40), NEWID()),0,9), dateadd(month, -6, getdate()))
INSERT INTO Orders VALUES ( 106, SUBSTRING(CONVERT(varchar(40), NEWID()),0,9), dateadd(month, -1, getdate()))
INSERT INTO Orders VALUES ( 107, SUBSTRING(CONVERT(varchar(40), NEWID()),0,9), dateadd(month, -10, getdate()))
INSERT INTO Orders VALUES ( 108, SUBSTRING(CONVERT(varchar(40), NEWID()),0,9), dateadd(month, 0, getdate()))
-----

