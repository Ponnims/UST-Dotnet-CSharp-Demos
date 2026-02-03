
create table tbl_UST_Chennai_Employees
(
	EmployeeID int primary key,
	FirstName nvarchar(50),
	Salary int,
	Designation nvarchar(50)
);

insert tbl_UST_Chennai_Employees values(1,'Anna',75000,'Developer')
insert tbl_UST_Chennai_Employees values(2,'Sreyas',85000,'Manager')
insert tbl_UST_Chennai_Employees values(3,'Kumar',95000,'Lead')
insert tbl_UST_Chennai_Employees values(4,'Ravi',65000,'Developer')
insert tbl_UST_Chennai_Employees values(5,'Priya',72000,'Tester')
insert tbl_UST_Chennai_Employees values(6,'Pasupathi',88000,'Manager')




select * into tbl_UST_Trivandrum_WH from tbl_UST_Chennai_Employees


select * from tbl_UST_Chennai_Employees
select * from tbl_UST_Trivandrum_WH

insert tbl_UST_Chennai_Employees values(7,'Kisanth',78000,'Developer'),
(8,'Yashashvini',83000,'Tester'),
(9,'Rijo',92000,'Lead')

update tbl_UST_Chennai_Employees set Designation='Senior Developer' where EmployeeID=1

delete from tbl_UST_Chennai_Employees where EmployeeID =3

-- Merge into targettablename using sourcetablename on condition
-- when matched then update 
-- when not matched by targt then insert
-- when not matched by source then delete; semicolon is mandatory at the end of merge statement

merge into tbl_UST_Trivandrum_WH as t using tbl_UST_Chennai_Employees as s
on t.EmployeeID = s.EmployeeID
when matched then 
	update set t.Firstname=s.firstname, t.Salary= s.Salary, t.Designation = s.Designation
when not matched by target then 
	insert (EmployeeID, FirstName, Salary, Designation) values (s.EmployeeID, s.FirstName, s.Salary, s.Designation)
when not matched by source then 
	delete;


	-- select statements
	select * from tbl_UST_Chennai_Employees
	select * from tbl_UST_Trivandrum_WH where Salary > 80000
	select * from tbl_UST_Trivandrum_WH where Salary between 70000 and 90000
	select * from tbl_UST_Trivandrum_WH where Designation in ('Developer','Tester') -- list operator
	select * from tbl_UST_Trivandrum_WH where FirstName like 'R%'  -- pattern matching wildcard operator %,_
	select * from tbl_UST_Trivandrum_WH where FirstName like '_a%'  -- pattern matching wildcard operator %,_
	select * from tbl_UST_Trivandrum_WH where FirstName like '%i%'  -- pattern matching wildcard operator %,_

	-- logical operators AND, OR, NOT
	select * from tbl_UST_Trivandrum_WH where Salary > 80000 and Designation='Manager'
	select * from tbl_UST_Trivandrum_WH where Salary > 80000 or Designation='Developer'
	select * from tbl_UST_Trivandrum_WH where not Designation='Tester'

	-- sorting the data
	select * from tbl_UST_Trivandrum_WH order by Salary desc
	select * from tbl_UST_Trivandrum_WH order by Designation asc, Salary desc
	-- Top N rows
	select top 3 * from tbl_UST_Trivandrum_WH order by Salary desc
	-- Aggregate functions
	select count(*) as TotalEmployees from tbl_UST_Trivandrum_WH
	select avg(Salary) as AverageSalary from tbl_UST_Trivandrum_WH
	select sum(Salary) as TotalSalary from tbl_UST_Trivandrum_WH
	select max(Salary) as HighestSalary from tbl_UST_Trivandrum_WH
	select min(Salary) as LowestSalary from tbl_UST_Trivandrum_WH
	-- Group by and Having
	select Designation, count(*) as TotalEmployees from tbl_UST_Trivandrum_WH group by Designation
	select Designation, avg(Salary) as AverageSalary from tbl_UST_Trivandrum_WH group by Designation 

		select Designation, max(Salary) as maxsal from tbl_UST_Trivandrum_WH group by Designation 

		-- Having clause can hold aggregate function based conditions
		select Designation, max(Salary) as Maxsal from tbl_UST_Trivandrum_WH group by Designation 
		having max(Salary) > 80000

		-- Constraints
				-- Primary Key, Foreign Key, Unique, Check, Default, Not Null

				-- Practice on Constraints
				--pRIMARY TABLE creation with constraints
				--CReate a table called Courses with CourseID, CourseName, Credits
				-- CourseID is primary key, CourseName is unique, Credits should have default value 3

				--crEATE A TABLE called Students with StudentID, StudentName, Age, CourseID
				-- StudentID is primary key, Age should have check constraint to allow only age > 18
				-- CourseID is foreign key referencing Courses table
				-- WITH ON DELETE CASCADE OPTION, so that when a course is deleted, all students enrolled in that course are also deleted.









