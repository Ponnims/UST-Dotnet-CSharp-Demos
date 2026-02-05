-- Stored Procedure is -- What is Stored Procedure?
-- A stored procedure is a precompiled collection of one or more SQL statements 
--that are stored under a name and processed as a unit.
-- Stored procedures can accept input parameters and return output parameters,
-- Why Stored Procedures?
-- 1. Performance: Stored procedures are precompiled, which means that the database engine 
--can execute them more quickly than ad-hoc SQL queries.
-- 2. Reusability: Once a stored procedure is created, it can be reused multiple times
--without the need to rewrite the SQL code.
-- 3. Security: Stored procedures can help enhance security by controlling access to data
--and reducing the risk of SQL injection attacks.


create proc usp_GetAllProducts
as
begin
	select * from dbo.tbl_products
end

exec usp_GetAllProducts

create procedure usp_GetProductByID @ProductID int
	as
	begin
	select * from dbo.tbl_products where ProductID=@ProductID
	end

	exec usp_GetProductByID 2

	create procedure usp_GetProductsByPriceRange @MinPrice decimal, @MaxPrice decimal
	as
	begin
	select * from dbo.tbl_products where Price between @MinPrice and @MaxPrice
	end



	alter proc usp_Add_Product @ProductId int, @ProductName nvarchar(100), @Price decimal, @StockQuantity int
	as
	begin
	begin try
		insert tbl_products values (@ProductId, @ProductName, @Price, @StockQuantity)
	end try
	begin catch
	print 'Product Already Available'
	end catch
	end

	exec usp_Add_Product 20, 'Tablet', 299.99, 150

	select * from tbl_products

	create proc usp_GetProductCount @TotalProducts int output
	as
	begin
	  --declare @samplevariable int
	  --set @samplevariable=100
	  --declare @maxprice int
	  --select @maxprice=max(price) from dbo.tbl_products
	  select @TotalProducts=count(*) from dbo.tbl_products
	   
	end

	declare @result int
	exec usp_GetProductCount @result output;
	--select @result as TotalProducts
	print 'Total Products: '+ cast(@result as nvarchar)


	create proc usp_GetProductprice_byname @ProductName nvarchar(100),@Price decimal output
	as
	begin 
	select @Price=price from dbo.tbl_products where ProductName=@ProductName
	end

	declare @result int
	exec usp_GetProductprice_byname 'Laptop', @result output;
	print 'Price of Laptop: '+ cast(@result as nvarchar)



	-- User Defined Functions
	-- A user-defined function (UDF) is a named set of SQL statements that perform a specific task
	-- similar to methods in programming languages. 
	--UDFs can accept parameters, perform operations, and return a value.

	-- 2 important types of UDFs
	-- Scalar Valued Functions: These functions return a single value (scalar) based on the input parameters.
	-- Table Valued Functions: These functions return a table data type, allowing you to work with sets of rows.


	select * from officers

	create function ufn_GetMaxSalary()
	returns int
	as
	begin
	    declare @MaxSalary int
		select @MaxSalary = max(Salary) from dbo.officers
		return @MaxSalary
	end

	select dbo.ufn_GetMaxSalary() as MaximumSalary

	select officername,upper(officername) Lengthofname from officers

	create function ufn_GetOfficerSalaryByName (@OfficerName nvarchar(100))
	returns int
	as
	begin
	 declare @Salary int
	 select @Salary=Salary from dbo.officers where OfficerName=@OfficerName
	 return @Salary
	end

	select * from Officers
	select dbo.ufn_GetOfficerSalaryByName('John Doe') as SalaryOfAlice

	--create function ufn_CalculateBonusByDepartment (@DepartmentName nvarchar(100))
	--returns int
	--as
	--begin
	--declare @Bonus int
	--select 1,
	--case 
	--when @DepartmentName='Finance' then set @Bonus= 10000
	--when @DepartmentName='HR' then set @Bonus= 8000
	--when @DepartmentName='IT' then set @Bonus= 12000
	--when @DepartmentName='Sales' then set @Bonus= 9000
	--else set @Bonus= 5000
	--end
	--end
	

	select * from officers
	
	
	select officername,Departmentname, case 
	when DepartmentName='Finance' then 10000
	when DepartmentName='HR' then 8000
	when DepartmentName='IT' then 20000
	when DepartmentName='Sales' then 50000
	else 0
	end as BonusAmount
	from officers








	create schema myschema

	create table myschema.sampleeee(id int, name nvarchar(50))


	select * from tbl_products

	create function ufn_CalculateDiscountedPrice (@ProductID int, @DiscountPercent decimal)
	returns decimal
	as
	begin
	declare @OriginalPrice decimal
	 declare @DiscountedPrice decimal
	 select @OriginalPrice=Price from dbo.tbl_products where ProductID=@ProductID
	 set @DiscountedPrice=@OriginalPrice - (@OriginalPrice * @DiscountPercent / 100)
	 return @DiscountedPrice
	end

	select dbo.ufn_CalculateDiscountedPrice(2, 10) as DiscountedPriceForProduct2

	select *, dbo.ufn_CalculateDiscountedPrice(ProductID, 15) as PriceAfter15PercentDiscount
	from tbl_products


	--Table Valued Function

	select * from tbl_UST_Chennai_Employees

	create function ufn_GetEmployeesByDesignation (@Desig nvarchar(100))
	returns table
	as
	return(select * from tbl_UST_Chennai_Employees where Designation=@Desig);

	select * from dbo.ufn_GetEmployeesByDesignation('Manager')

	-- Triggers are special types of stored procedures 
	--that gets automatically executed based on certain events 
	--such as insert, update or delete on a table.

	-- inserted and deleted tables are special tables/ Virtual tables in triggers

	--select * from inserted -- this will throw error outside trigger
	-- select * from deleted -- this will throw error outside trigger, 
	--because these are special tables available only inside triggers

	select * from tbl_UST_Chennai_Employees

	--create trigger trg_after_insert_Employee
	--on dbo.tbl_UST_Chennai_Employees
	--after insert
	--as
	--begin
	--   print 'A new employee has joined.'
	--end

	--alter trigger trg_after_insert_Employee
	--on dbo.tbl_UST_Chennai_Employees
	--after insert,update,delete
	--as
	--begin
	--  select * from inserted
	--  select * from deleted
	--end

	--alter trigger trg_after_insert_Employee
	--on dbo.tbl_UST_Chennai_Employees
	--after insert
	--as
	--begin
	--  declare @name nvarchar(100), @desig nvarchar(100)
	--  select @name=FirstName,@desig=Designation from inserted

	--  print 'Employee '+ @name + ' with Designation '+ @desig + ' has joined the organization.'
	  
	--end



	insert into dbo.tbl_UST_Chennai_Employees values (13, 'RamKrishna', 8000, 'Manager')

	update dbo.tbl_UST_Chennai_Employees set Salary=9000,FirstName='Charles Bob', Designation='Sr.Developer'
	where EmployeeID=11

	delete from dbo.tbl_UST_Chennai_Employees where EmployeeID=11


	create table ust_employee_insert_log(empid int, Action nvarchar(50), ActionDate datetime)

	alter trigger trg_after_insert_Employee
	on dbo.tbl_UST_Chennai_Employees
	after insert
	as
	begin
	  declare @empid int
	  select @empid=EmployeeID from inserted
	  insert into dbo.ust_employee_insert_log values(@empid, 'INSERT',GETDATE())
	end

	insert into dbo.tbl_UST_Chennai_Employees values (14, 'Suresh Kumar', 7500, 'Developer')

	select * from dbo.ust_employee_insert_log


	--instead of Trigger
	-- This trigger will execute instead of the actual  operation on the table.this will execute 
	-- the trigger body. instead of the insert, update or delete operation on the table.

	create trigger trg_instead_of_delete_Employee
	on tbl_UST_Chennai_Employees
	instead of delete
	as
	begin
	  print 'Delete operation is not allowed on tbl_UST_Chennai_Employees table.'
	end


	select * from tbl_UST_Chennai_Employees where EmployeeID=14
	delete from tbl_UST_Chennai_Employees where EmployeeID=14


	set statistics io on

	select * from tbl_products where Price > 500