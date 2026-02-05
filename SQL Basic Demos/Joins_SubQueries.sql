create table tbl_products
(
	ProductID int constraint pk_products_key primary key,
	ProductName nvarchar(100) not null,
	Price decimal(10, 2) not null,
	StockQuantity int not null
);

insert into tbl_products (ProductID, ProductName, Price, StockQuantity) values
(6, 'Camera', 599.99, 80),
(7, 'Printer', 149.99, 60),
(8, 'Monitor', 249.99, 70),
(9, 'Keyboard', 49.99, 400),
(10, 'Mouse', 29.99, 500);



create table tbl_customers
(
	CustomerID int constraint pk_customers primary key,
	CustName nvarchar(50) not null,
	
);

insert into tbl_customers (CustomerID, CustName) values

(6, 'Fiona Gallagher'),
(7, 'George Clooney'),
(8, 'Hannah Montana'),
(9, 'Ian Somerhalder'),
(10, 'Jessica Alba');

create table tbl_orders
(
	OrderID int constraint pk_orders primary key,
	CustomerID int constraint fk_orders_customers references tbl_customers(CustomerID),
	productID int constraint fk_orders_products references tbl_products(ProductID)
);

insert into tbl_orders (OrderID, CustomerID, productID) values
(1, 1, 2),
(2, 2, 1),
(3, 3, 4),
(4, 4, 3),
(5, 5, 5);

select * from tbl_products;
select * from tbl_customers;
select * from tbl_orders;

select o.OrderID,c.Custname, p.ProductName from tbl_customers c, tbl_products p,tbl_orders o
where o.CustomerID=c.CustomerID and o.ProductID=p.productID;

select o.OrderID,c.Custname, p.ProductName from tbl_customers c inner join tbl_orders o on o.CustomerID=c.CustomerID
join tbl_products p on o.ProductID=p.productID;

-- left join return all records from left table and matching records from right table
-- right join return all records from right table and matching records from left table
-- full join return all records when there is a match in either left or right table


--list all customers with or without orders
select c.Custname, o.productid from tbl_customers c left join tbl_orders o on o.CustomerID=c.CustomerID;

-- cross join means there is condition it will return all combinations of rows from both tables
-- cartesian product of both tables
--first table has m rows and second table has n rows then cross join will return m*n rows

select c.Custname, p.ProductName from tbl_customers c cross join tbl_products p;

-- self join is used to join a table with itself

create table Staff
(
	StaffID int constraint pk_staff primary key,
	StaffName nvarchar(50) not null,
	salary int not null,
	ManagerID int constraint fk_staff_manager references Staff(StaffID)
);

insert into Staff (StaffID, StaffName, salary, ManagerID) values
(1, 'Alice', 80000, 3),
(2, 'Bob', 60000, 4),
(3, 'Charlie', 55000, null),
(4, 'David', 50000, 5),
(5, 'Eve', 45000, 1);

insert into Staff (StaffID, StaffName, salary, ManagerID) values
(6, 'Frank', 70000, 3),
(7, 'Grace', 65000, 4);


select * from staff

 select s1.StaffName, s2.StaffName 'Manager' from staff s1 join staff s2 on s1.ManagerID=s2.StaffID

  select s1.StaffName+' Reports to '+ s2.StaffName from staff s1 join staff s2 on s1.ManagerID=s2.StaffID


  -- Subqueries
  -- A subquery is a query nested inside another query
  -- Outer Query (subquery)
  drop table officers
  -- create a table Officers with columns OfficerID, OfficerName, Salary, departmentname
  create table officers
  (officerID int constraint pk_officers primary key,
  OfficerName nvarchar(50) not null,
  Salary int not null,
  DepartmentName nvarchar(50) not null
  );
  
  insert into officers (officerID, OfficerName, Salary, DepartmentName) values
  (1, 'John Doe', 95000, 'Finance'),
  (2, 'Jane Smith', 85000, 'HR'),
  (3, 'Mike Johnson', 105000, 'IT'),
  (4, 'Emily Davis', 75000, 'Marketing'),
  (5, 'Anna White', 90000, 'Sales'),
  (6, 'David Brown', 110000, 'IT'),
  (7, 'Linda Green', 80000, 'Finance'),
  (8, 'James Black', 95000, 'HR'),
  (9, 'Susan Blue', 70000, 'Marketing'),
  (10, 'Robert Yellow', 120000, 'Sales'),
  (11, 'Patricia Purple', 88000, 'Finance'),
  (12, 'Michael Orange', 99000, 'IT');


  
  


  select * from officers

  select * from officers where salary>90000

  -- fetch officers whose salary is greater than Anna White's salary
    select * from officers where salary>(select Salary from officers where OfficerName='Anna White')

	-- single row subquery, operators : =, <, >, <=, >=, <>
	 select * from officers where salary>(select Salary from officers where OfficerName='Anna White')
	-- multiple row subquery , operators : IN, ANY, ALL, not in
	 select * from officers where DepartmentName in (select DepartmentName from officers where Salary>100000)
	 -- display officers whose salary is greater than any officer in IT department
	 	 select * from officers where salary>any(select salary from officers where DepartmentName='IT')
	 -- usually (outer query) => depends on the (Subquery)
	 -- first the subquery will be executed and its result will be passed to outer query for further processing


	-- corelated subquery
	-- (Outer Query ) <===> (SubQuery)
	-- select col1,col2,col3 from table t1 where col1 > (select col1,col3 from table t2 where t2.col3=t1.col3)



	-- display officers whose salary is greater than the average salary of their respective departments
	select * from officers o1 where salary>
	(select avg(salary) from officers o2 where o1.DepartmentName=o2.DepartmentName)
	 







