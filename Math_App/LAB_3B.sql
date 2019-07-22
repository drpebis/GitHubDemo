--1
--SELECT e.EmployeeID EmployeeID, e.firstname FirstName, e.lastname LastName, o.orderid OrderID, o.orderdate OrderDate
--FROM dbo.orders as o
--inner join dbo.employees as e
--on o.employeeid = e.employeeid
--order by employeeid;

--2
--Select t.TerritoryDescription as Territory, r.RegionDescription as Region
--from dbo.Territories as t
--inner join dbo.Region as r
--on t.RegionID = r.RegionID
--order by RegionDescription, TerritoryDescription;

--3
--select s.companyName as Supplier, p.ProductName as Product
--from dbo.Products as p
--inner join dbo.suppliers as s
--on s.SupplierID = p.SupplierID
--order by CompanyName, productname;

--4
Select od.OrderID as OrderID, od.quantity as Qty, od.UnitPrice as Price
From dbo.[Order Details] as od
	inner join dbo.orders as o
	on od.OrderID = o.OrderID
where year(o.orderdate) = 1998
and month(o.orderdate) = 5
and day(o.orderdate) = 5
order by o.orderid, od.Quantity, od.UnitPrice;

--5
Select od.OrderID as OrderID, p.productname as ProductName, od.quantity as Qty, od.UnitPrice as Price
From dbo.[Order Details] as od
	inner join dbo.orders as o
	on od.OrderID = o.OrderID
	inner join dbo.products as p
	on od.ProductID = p.ProductID
where year(o.orderdate) = 1998
and month(o.orderdate) = 5
and day(o.orderdate) = 5
order by o.orderid, p.ProductName, od.Quantity, od.UnitPrice;

--6
Select distinct c.CompanyName CustomerName, s.CompanyName as ShipperName
From dbo.Orders as o
	inner join dbo.customers as c
	on o.CustomerID = c.CustomerID
	inner join Shippers as s
	on s.ShipperID = o.ShipVia
where year(o.orderdate) = 1998
and month(o.orderdate) = 5
order by c.CompanyName;

--7
select c.CompanyName as CustomerName, e.firstname + ' ' + e.lastname as EmployeeName
from dbo.orders as o
	inner join dbo.customers as c
	on o.CustomerID = c.CustomerID
	inner join dbo.employees as e
	on o.EmployeeID = e.EmployeeID
where o.ShipCountry = 'France'
order by c.CompanyName, e.LastName;

--8
select p.productname as Product
from dbo.products as p
	inner join dbo.[Order Details] od
	on p.ProductID = od.ProductID
	inner join dbo.orders as o
	on od.OrderID = o.OrderID
where o.shipcountry like 'Germany'
order by p.ProductName;