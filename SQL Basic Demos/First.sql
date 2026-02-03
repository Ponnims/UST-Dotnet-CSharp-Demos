use db_UST_Demos

create table Employees
(
	EmployeeID int primary key,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	BirthDate date,
	HireDate date,
	Salary decimal(18, 2)
);

-- DDL => create,alter, drop, truncate
-- DML => insert, update, delete, merge
-- DCL => Grant, Revoke
-- DQL => Select

alter table employees add email varchar(25)
alter table employees alter column salary int
alter table employees drop column hiredate

--alter table employees rename (we can rename it through stored procedure called sp_rename

drop table Employees

truncate table Employees --           => removes all data along with the memory footpeint

-- DML statement Delete from tablename => removes all data, but the memory is still occupied, it is not freed up

-- DML Statement

insert employees  values(2,'aaa','llll','12/12/26','11/12/2026',23432)
insert employees(Employeeid,Firstname,birthdate)  values(3,'new','11/12/2026')

select * from employees

alter table employees alter column salary int not null 

alter table employees drop constraint PK__Employee__7AD04FF16657A1D1

update employees set salary=10000000 

update employees set salary=6666666 where firstname='aaa'

delete from employees where firstname='new'