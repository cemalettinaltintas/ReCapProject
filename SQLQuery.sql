CREATE TABLE Cars(
Id int PRIMARY KEY IDENTITY(1,1), 
BrandId int,
ColorId int,
ModelYear int,
DailyPrice decimal,
Descriptions nvarchar(250),
)

CREATE TABLE Brands(
Id int PRIMARY KEY IDENTITY(1,1),
Name nvarchar(50),
)

CREATE TABLE Colors(
Id int PRIMARY KEY IDENTITY(1,1),
Name nvarchar(50),
)



INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions) VALUES
(1,1,2018,500,'SUV'),
(1,2,2020,600,'4x4'),
(2,2,2016,700,'2.el Arac'),
(2,1,2015,300,'Klasik Arac'),
(3,3,2021,450,'Spor Arac')