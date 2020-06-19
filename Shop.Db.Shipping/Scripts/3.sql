IF ( not EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'dbo' 
                 AND  TABLE_NAME = 'demo'))
BEGIN
    print ' table is not exist and creating now '
   CREATE TABLE demo(Id int primary key not null identity(1,1), CustomerId int not null, OrderReference nvarchar(128) not null, OrderDate datetime not null);
        INSERT INTO demo VALUES ( 100, SUBSTRING(CONVERT(varchar(40), NEWID()),0,9), dateadd(month, -11, getdate()))
        INSERT INTO demo VALUES ( 101, SUBSTRING(CONVERT(varchar(40), NEWID()),0,9), dateadd(month, -2, getdate()))
        INSERT INTO demo VALUES ( 102, SUBSTRING(CONVERT(varchar(40), NEWID()),0,9), dateadd(month, -3, getdate()))
        INSERT INTO demo VALUES ( 103, SUBSTRING(CONVERT(varchar(40), NEWID()),0,9), dateadd(month, -1, getdate()))
        INSERT INTO demo VALUES ( 104, SUBSTRING(CONVERT(varchar(40), NEWID()),0,9), dateadd(month, -4, getdate()))
        INSERT INTO demo VALUES ( 105, SUBSTRING(CONVERT(varchar(40), NEWID()),0,9), dateadd(month, -6, getdate()))
        INSERT INTO demo VALUES ( 106, SUBSTRING(CONVERT(varchar(40), NEWID()),0,9), dateadd(month, -1, getdate()))
        INSERT INTO demo VALUES ( 107, SUBSTRING(CONVERT(varchar(40), NEWID()),0,9), dateadd(month, -10, getdate()))
        INSERT INTO demo VALUES ( 108, SUBSTRING(CONVERT(varchar(40), NEWID()),0,9), dateadd(month, 0, getdate()))
END

else
begin
    print ' table exists'
end
 