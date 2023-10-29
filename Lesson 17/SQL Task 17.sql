--create database SupplyChain
--use SupplyChain


--create table Customers(
--C_ID int primary key,
--C_Name nvarchar(155) not null,
--City nvarchar(50) not null,
--Grade int,
--Salesman_ID int 
--)

--create procedure usp_CustomersData 
--@c_ID int, @c_name nvarchar(155), @city nvarchar(50), @grade int, @s_ID int
--as
--insert into Customers(C_ID, C_Name, City, Grade, Salesman_ID)
--values (@c_ID, @c_name, @city, @grade, @s_ID)

--exec usp_CustomersData 3002, 'Nick Rimando', 'New York', 100, 5001
--exec usp_CustomersData 3007, 'Brad Davis', 'New York', 200, 5001
--exec usp_CustomersData 3005, 'Graham Zusi', 'California', 200, 5002
--exec usp_CustomersData 3008, 'Julian Green', 'London', 300, 5002
--exec usp_CustomersData 3004, 'Fabian Johnson', 'Paris', 300, 5006
--exec usp_CustomersData 3009, 'Geoff Cameron', 'Berlin', 100, 5003
--exec usp_CustomersData 3003, 'Jozy Altidor', 'Moscow', 200, 5007
--exec usp_CustomersData 3001, 'Brad Guzan', 'London', null, 5005

--select *from Customers


--create table Orders(
--Order_No int primary key,
--Purch_Amt float not null,
--Order_Date date not null,
--C_ID int not null,
--Salesman_ID int not null
--)

--create procedure usp_OrdersData 
--@order int, @purch float, @date date, @c_id int, @s_id int
--as
--insert into Orders(Order_No, Purch_Amt, Order_Date, C_ID, Salesman_ID)
--values 
--(@order, @purch, @date, @c_id, @s_id)

--exec usp_OrdersData 70001, 150.5, '2012-10-05', 3005, 5002
--exec usp_OrdersData 70009, 270.65, '2012-09-10', 3001, 5005
--exec usp_OrdersData 70002, 65.26, '2012-10-05', 3002, 5001
--exec usp_OrdersData 70004, 110.5, '2012-08-17', 3009, 5003
--exec usp_OrdersData 70007, 948.5, '2012-09-10', 3005, 5002
--exec usp_OrdersData 70005, 2400.6, '2012-07-27', 3007, 5001
--exec usp_OrdersData 70008, 5760, '2012-09-10', 3002, 5001
--exec usp_OrdersData 70010, 1983.43, '2012-10-10', 3004, 5006
--exec usp_OrdersData 70003, 2480.4, '2012-10-10', 3009, 5003
--exec usp_OrdersData 70012, 250.45, '2012-06-27', 3008, 5002
--exec usp_OrdersData 70011, 75.29, '2012-08-17', 3003, 5007
--exec usp_OrdersData 70013, 3045.6, '2012-04-25', 3002, 5001

--select *from Orders

--create table Salesman(
--Salesman_ID int primary key,
--S_Name nvarchar(155) not null,
--City nvarchar(50) not null,
--Commission float not null
--)

--create procedure usp_SalesmanData 
--@id int, @name nvarchar(155), @city nvarchar(50), @com float
--as
--insert into Salesman(Salesman_ID, S_Name, City, Commission)
--values 
--(@id, @name, @city, @com)

--exec usp_SalesmanData 5001, 'James Hoog', 'New York', 0.15
--exec usp_SalesmanData 5002, 'Nail Knite', 'Paris', 0.13
--exec usp_SalesmanData 5005, 'Pit Alex', 'London', 0.11
--exec usp_SalesmanData 5006, 'Mc Lyon', 'Paris', 0.14
--exec usp_SalesmanData 5007, 'Paul Adam', 'Rome', 0.13
--exec usp_SalesmanData 5003, 'Lauson Hen', 'San Jose', 0.12

--select *from Salesman

----TASK 1
--select *from Orders
--select *from Salesman
--select *from Customers



--Select a.C_Name, a.City, b.Order_No,
--b.Order_Date, b.Purch_Amt AS 'Order Amount',
--c.S_Name, c.Commission
--FROM Customers a
--LEFT OUTER JOIN Orders b
--ON a.C_ID = b.C_ID
--LEFT OUTER JOIN Salesman c
--ON c.Salesman_ID = b.Salesman_ID