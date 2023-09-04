CREATE DATABASE DB_MVC_PRACTICE

USE DB_MVC_PRACTICE

CREATE TABLE Tbl_emp
(
	EID INT PRIMARY KEY IDENTITY,
	[NAME] VARCHAR(60),
	[ADDRESS] VARCHAR(60),
	AGE INT
)

select * from Tbl_emp

CREATE PROC sp_Insert
(
	@name varchar(60),
	@address varchar(60),
	@age int
)
as
begin
	insert into Tbl_emp(NAME,ADDRESS,AGE)
	values(@name,@address,@age)
end;