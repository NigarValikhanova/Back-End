create database Company
use Company
create table Customers(
ID int primary key identity,
[Name] nvarchar(35) not null,
Surname nvarchar(50),
Salary float not null
)
insert into Customers (Name, Surname, Salary)
Values 
('George', 'Clinton', 2300),
('Michael', 'Mstar', 1500),
('Kate', 'Cooper', 1800),
('Gloria', 'Gomez', 3000),
('Verenica', 'Santiago', 2000),
('John', 'Winchester', 3500),
('Leonard', 'Parkinson', 1200),
('Stuart', 'Johnson', 1800),
('Lucas', 'Herminson', 2300),
('Rachel', 'Green', 2500),
('Monica', 'Geller', 3000),
('Chandler', 'Bing', 3000),
('Joey', 'Tribiani', 2000),
('Ted', 'Mosby', 1500),
('Marshall', 'Erikson', 3000)

Select *from Customers

Update Customers
Set Surname = 'Quinn', [Name] = 'Harley'
Where ID =5

Select *from Customers

DELETE FROM Customers WHERE [Name]='Lucas'

Select *from Customers

Select AVG(Salary) as 'Average Salary'
from Customers

Select * from Customers
Where Salary > (Select AVG(Salary) from Customers)

Select Name from Customers
Where Salary = (Select MAX(Salary) from Customers)

Select Surname from Customers
Where Salary = (Select MIN(Salary) from Customers)