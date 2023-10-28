--create database Electronics
--use Electronics
--create table Brands(
--ID int primary key identity,
--[Name] nvarchar(50) unique
--)
--insert into Brands(Name)
--Values 
--('Apple'),
--('HP'),
--('Xiaomi'),
--('Huawei'),
--('Asus'),
--('Lenovo'),
--('Dell')


--create table Notebooks(
--ID int primary key identity,
--[Name] nvarchar(50) unique,
--Price float 
--)

--insert into Notebooks (Name, Price)
--Values 
--('Macbook Air', 4000),
--('Macbook Pro', 5879.99),
--('ThinkPad 470', 2000),
--('Omen 15', 3599.99)

--create table Phones(
--ID int primary key identity,
--[Name] nvarchar(50) unique,
--Price money
--)

--insert into Phones(Name, Price)
--Values 
--('Iphone 15 pro', 3500.80),
--('Redmi Note 8', 500.99),
--('Iphone 14', 2000),
--('Redmi Note 20', 1200),
--('Iphone 14 pro max', 3000)


---- TASK 1
--alter table Notebooks 
--add BrandID int

--alter table Notebooks
--ADD CONSTRAINT FK_Brand_Notebook Foreign Key(BrandID)
--references Brands(Id)


---- TASK 2
--alter table Phones
--add BrandID int
--alter table Phones
--ADD CONSTRAINT FK_Brand_Phones Foreign Key(BrandID)
--references Brands(Id)

---- TASK 3

--update Notebooks
--set BrandID = 2 where Id=4 
---- hamisi uchun eyni code u isletdik

--update Notebooks
--set BrandID =1 where [Name] like '%Macbook%'

--select Notebooks.Name, Price, Brands.Name as 'Brand Name' from Notebooks 
--Join Brands on Notebooks.BrandID = Brands.ID

---- TASK 4

--select *from Phones
--select *from Brands

--update Phones
--set BrandID =1 where [Name] like '%Iphone%'

--update Phones
--set BrandID =3 where [Name] like '%Redmi%'

--select Phones.Name, Price, Brands.Name as 'Brand Name' from Phones 
--Join Brands on Phones.BrandID = Brands.ID

---- TASK 5

--Select [Name] from Brands where [Name] like '%a%'


--Select * From Notebooks 
--Where Exists(Select *from Brands 
--where Id =Notebooks.BrandID and [Name] like '%a%')

---- TASK 6

--Select * from Notebooks
--where Price Between 2000 and 5000 Or Price<5000

---- TASK 7

--Select * from Phones
--where Price Between 1000 and 1500 Or Price>1500

---- TASK 8

--Select b.Name, Count(*) 'Count' from Brands b
--join Notebooks n on n.BrandID = b.ID
--Group By b.Name

---- TASK 9

--Select b.Name, Count(*) 'Count' from Brands b
--join Phones p on p.BrandID = b.ID
--Group By b.Name

---- TASK 10

--Select [Name], BrandID from Notebooks 
--union all
--Select [Name], BrandID from Phones

---- TASK 11

--Select Products.BrandID, Products.Name, Products.Price, b.Name from
--(Select n.Name, n.Price, n.BrandID from Notebooks n
--union all
--Select p.Name, p.Price, p.BrandID from Phones p) Products
--join Brands b on b.ID = Products.BrandID

---- TASK 12

--Select Products.BrandID, Products.Name, Products.Price, b.Name 'Brand Name' from
--(Select n.Name, n.Price, n.BrandID from Notebooks n
--union all
--Select p.Name, p.Price, p.BrandID from Phones p) Products
--join Brands b on b.ID = Products.BrandID

---- TASK 13

--Select Products.BrandID, Products.Name, Products.Price, b.Name 'Brand Name' from
--(Select n.Name, n.Price, n.BrandID from Notebooks n
--union all
--Select p.Name, p.Price, p.BrandID from Phones p) Products
--join Brands b on b.ID = Products.BrandID
--where Products.Price>3000

---- TASK 14

--Select b.Name, SUM(p.Price) 'Total Price', COUNT(*) 'Product Count' 
--from Phones p
--join Brands b on b.ID =p.BrandID
--Group By b.Name

---- TASK 15

--Select b.Name 'Brand Name', SUM(n.Price) 'Total Price', COUNT(*) 'Product Count' 
--from Notebooks n
--join Brands b on b.ID =n.BrandID
--Group By b.Name