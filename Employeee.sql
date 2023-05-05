create database MachineTest

use MachineTest


create table Employeee (EmpID int primary key, Empname varchar(250), City varchar(50))
insert into Employeee (EmpID, Empname, City)
values (101, 'satyam', 'Kolhapur'),
(102, 'Pragati', 'Pune'),
(103, 'vikas', 'Mumbai')

select * from Employeee