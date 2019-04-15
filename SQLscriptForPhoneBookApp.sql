/**********************************************************/
-- Script: NETAssignment5.sql
-- Author:Norman Potts
-- Date: 04/12/2015
-- Description: This creates the database necessary for Assignment 5 to function.




/**********************************************************/

-- Setting NOCOUNT ON suppresses completion messages for each INSERT
SET NOCOUNT ON

-- Set date format to year, month, day
SET DATEFORMAT ymd;

-- Make the master database the current database
USE master

-- If database co859 exists, drop it
IF EXISTS ( SELECT  * FROM sysdatabases WHERE name = 'PhoneBookDatabase' )
  DROP DATABASE PhoneBookDatabase;
GO

-- Create the co859 database
CREATE DATABASE PhoneBookDatabase;
GO

-- Make the co859 database the current database
USE PhoneBookDatabase;

-- Create Items table
CREATE TABLE PhoneBook ( 
  ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY , 
  firstname VARCHAR(30) NULL , 
  lastname VARCHAR(30) NULL , 
  phone VARCHAR(10) NULL ,
  email VARCHAR(365) NULL ,
  CONSTRAINT PK_PhoneBook PRIMARY KEY ( ID )
  );

 
-- Insert Items records
INSERT INTO PhoneBook VALUES( 'Norman' , 'Potts' , '5151734572', 'myemail@email.com' );
INSERT INTO PhoneBook VALUES( 'Snowball' , 'Parkway' , '5151745572', 'myemail@email.com' );
INSERT INTO PhoneBook VALUES( 'Jess' , 'Sam' , '5151734512', 'myemail@email.com' );
GO



CREATE INDEX IX_Table_ColumnName
ON PhoneBook (lastname);
GO


