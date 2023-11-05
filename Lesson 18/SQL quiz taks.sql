--create database Store
--use Store
--create table Catagories(
--ID int primary key,
--[Name] nvarchar(155) unique
--)

--create table Products(
--ID int primary key,
--ProductCode nvarchar(155) unique,
--CategoryID int 
--foreign key references Catagories (ID)
--)

--create table Stocks(
--ID int primary key,
--ProductID int
--foreign key references Products (ID),
--CreatedDate datetime DEFAULT '02.11.2023',
--[Count] int
--)

--create table Sizes(
--ID int primary key,
--Letter nvarchar(50))

--alter table Stocks
--add Size int 

--insert into Catagories (ID, [Name])
--values 
--(1, 'T-shirt'),
--(2, 'Jeans'),
--(3, 'Shoes'),
--(4, 'Jacket')

--insert into Products(ID, ProductCode, CategoryID)
--values
--(001, 'V yaxa', 1),
--(002, 'uzunqol', 1),
--(003, 'qisaqol', 1),
--(004, 'dar cins', 2),
--(005, 'boyfriend', 2),
--(006, 'sneakers', 3),
--(007, 'bot', 3),
--(008, 'qalin jacket', 4),
--(009, 'nazik jacket', 4)

--select *from Stocks

--insert into Stocks (ID, ProductID, [Count], Size)
--values
--(200, 001, 50, 38),
--(201, 001, 40, 39),
--(202, 002, 30, 40),
--(203, 002, 20, 41),
--(204, 003, 25, 36),
--(205, 003, 35, 37),
--(206, 004, 45, 38),
--(207, 004, 55, 39),
--(208, 005, 10, 35),
--(209, 005, 12, 36),
--(210, 006, 13, 37),
--(211, 006, 14, 38),
--(212, 007, 15, 39),
--(213, 007, 16, 40),
--(214, 008, 17, 41),
--(215, 008, 18, 42)


--select ProductID, ProductCode, [Count]  from Stocks 
--join Products on Products.ID = Stocks.ProductID

--Create View ProductView AS
--Select p.ProductCode, c.Name AS CategroyName, S.Letter
--From Products p
--Join Catagories c on p.CategoryID = c.ID
--Join Sizes s on p.ID = s.ID

--select *from ProductView

--Create View ProductViewS AS
--Select p.ProductCode, c.Name AS CategroyName
--From Products p
--Join Catagories c on p.CategoryID = c.ID

--Create Procedure GetProductsByCat @catID int
--AS
--Begin
--Select *from ProductViewS Where CategroyName = @catID
--End

--Create Function GetProductsByCategory (@CategoryName nvarchar(255))
--Returns Table
--As Return (Select *from ProductViewS Where CategroyName=@CategoryName)