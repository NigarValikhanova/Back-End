create database Academy
 --ctrl c+k commente atir
 use Academy
create table Students(
ID int Primary Key,
Fullname nvarchar(100) Not null,
Birthdate date Not null,
GroupNo nvarchar(50) Not null,
Grade tinyint
)
alter table Students
add Region nvarchar(50)
drop column Region
select *from Students
insert into Students(Fullname, Birthdate, GroupNo, Region, Grade, ID)
Values
('Nigar Valikhanova', '1997-03-05', 'E141', 'Baku', 96, 1),
('Lala Yusubova', '1996-10-13', 'E141', 'Baku', 92,2),
('Shamkhal Oqtayzada', '1997-09-06', 'E141', 'Baku', 96,3),
('Aysel Ahmadova', '1997-06-05', 'E141', 'Baku', 96,4)

UPDATE Students
SET Fullname = 'Ali Mammadov'
where ID = 5
select *from Students
delete from Students 
where Fullname='Nurlan Kazimov'