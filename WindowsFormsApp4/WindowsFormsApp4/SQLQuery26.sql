/****** Script for SelectTopNRows command from SSMS  ******/
SELECT [fld_matchRandomNumber]
      ,[fld_firstName]
      ,[fld_lastName]
      ,[fld_personalIDnumber]
      ,[fld_osName]
      ,[fld_osVersion]
      ,[fld_browserName]
      ,[fld_browserVersion]
      ,[fld_latitude]
      ,[fld_longitude]
      ,[fld_dateTime]
  FROM [dbo].[tbl_ClockIn]
  ORDER BY [fld_dateTime] desc;

  SELECT MAX([fld_dateTime]) 
FROM [tbl_ClockIn]
WHERE [fld_latitude] !='';

SELECT  top 1 [fld_latitude]
FROM [tbl_ClockIn]
WHERE [fld_latitude] !=''
ORDER BY [fld_dateTime] desc;

SELECT  top 1 [fld_longitude]
FROM [tbl_ClockIn]
WHERE [fld_latitude] !=''
ORDER BY [fld_dateTime] desc;

UPDATE tbl_ClockIn SET [fld_longitude] = (SELECT  top 1 [fld_longitude]
FROM [tbl_ClockIn]
WHERE [fld_latitude] !=''
ORDER BY [fld_dateTime] desc)
 WHERE [fld_longitude] = '';

 UPDATE tbl_ClockIn SET [fld_latitude] = (SELECT  top 1 [fld_latitude]
FROM [tbl_ClockIn]
WHERE [fld_latitude] !=''
ORDER BY [fld_dateTime] desc)
 WHERE [fld_latitude] = '';

 drop table tbl_ClockIn;

create table tbl_ClockIn (
	fld_firstName VARCHAR(50),
	fld_lastName VARCHAR(50),
	fld_personalIDnumber VARCHAR(500),
    fld_osName VARCHAR(500),
	fld_osVersion VARCHAR(500),
	fld_browserName VARCHAR(500),
	fld_browserVersion VARCHAR(500),
	fld_latitude VARCHAR(50),
	fld_longitude VARCHAR(50),
	fld_dateTime DATETIME
);

INSERT INTO tbl_ClockIn ( fld_firstName,fld_lastName,fld_personalIDnumber,fld_osName,fld_osVersion,fld_browserName,fld_browserVersion,fld_latitude,fld_longitude,fld_dateTime)
SELECT fld_firstName,fld_lastName,fld_personalIDnumber,fld_osName,fld_osVersion,fld_browserName,fld_browserVersion,fld_latitude,fld_longitude,fld_dateTime
FROM tbl_ClockIn2;