create database codetest7

use codetest7

--Create a book table with id as primary key and provide the appropriate data type to other attributes .isbn no should be unique for each book
 -- Write a query to fetch the details of the books written by author whose name ends with er.


Create table tblbooks (
    id int Primary key,
    title Varchar(100), 
    author Varchar(100), 
    isbn Varchar(20) unique,
    published_date date
)

select * from tblbooks

Insert Into tblbooks Values
(1, 'my first SQL book', 'mary parker', '981483029127', '2012-02-22'),
(2, 'my second SQL book', 'john moyer', '857300923713', '1972-07-03'),
(3, 'my Third SQL book', 'cary fint', '523120967812', '2015-10-22')

 --- Write a query to fetch the details of the books written by author whose name ends with er
 select * from tblbooks where lower(author) like '%er'
 -------------------------------------------------------------------------------------------------------------------

 --2
  create table tblreviews
  (

  id int primary key,
  bookid int,
  reviewername varchar(100),
  context varchar(100),
  rating int,
  published_date date,
  )

  Insert Into tblreviews  values
(1, 1, 'john smith', 'my first review', 4, '2017-12-12 05:50:11'),
(2, 2, 'john smith', 'my second review', 5, '2017-10-12 05:50:11'),
(3, 2, 'alice walker', 'another review', 5, '2017-10-22 05:50:12');

--Display the Title ,Author and ReviewerName for all the books from the above table 

Select b.title, b.author, r.reviewername
From tblreviews r
JOIN tblbooks b on r.bookid = b.id;
---------------------------------------------------------------------

--Display the  reviewer name who reviewed more than one book.

Select reviewername
From tblreviews
Group by reviewername
Having COUNT(Distinct bookid) > 1;

-------------------------------------------------------

create table tblcustomer
(
id int,
name varchar(100),
age int,
address varchar(100),
salary float,
)
Insert Into tblcustomer Values
(1, 'ramesh', 32, 'ahmedabad', 2000),
(2, 'khilan', 25, 'delhi', 1500),
(3, 'kaushik', 23, 'kota', 2000),
(4, 'chaitali', 25, 'mumbai', 6500),
(5, 'hardik', 27, 'bhopal', 8500),
(6, 'komal', 22, 'ahmedabad', 4500),
(7, 'muffy', 24, 'ahmedabad', 10000);

---Display the Name for the customer from above customer table  who live in same address which has character o anywhere in address
Select name From tblcustomer Where address LIKE '%o%'

create table tblorders
(
oid int,
Date date,
customer_id int,
amount float,
)
Insert into tblorders Values
(102, '2009-10-08', 3, 3000),
(100, '2009-10-08', 3, 1500),
(101, '2009-11-20', 2, 1500),
(103, '2008-05-20', 4, 2060)

--Write a query to display the   Date,Total no of customer  placed order on same Date 
Select Date, count(DISTINCT customer_id) as Total_Customers
From tblorders
Group By Date
Order By Date;
-----------------------------------------------------
--5

create table tblemployee
(
id int,
name varchar(100),
age int,
address varchar(100),
salary float,
)
Insert Into tblemployee Values
(1, 'ramesh', 32, 'ahmedabad', 2000),
(2, 'khilan', 25, 'delhi', 1500),
(3, 'kaushik', 23, 'kota', 2000),
(4, 'chaitali', 25, 'mumbai', 6500),
(5, 'hardik', 27, 'bhopal', 8500),
(6, 'komal', 22, 'ahmedabad', null),
(7, 'muffy', 24, 'ahmedabad', null)


--Display the Names of the Employee in lower case, whose salary is null 
Select LOWER(name) as lower_case_name
From tblcustomer
Where salary IS NULL;

----------------------------------------------------
create table StudentDetails
(
	sno int,
	RegisterNo int primary key,
	Name varchar(30),
	Age int,
	Qualification varchar(30), 
	MobileNo varchar(15),
	Mail_id varchar(40),
	Location varchar(30),
	Gender char(1)
)
insert into StudentDetails values
	(1, 2, 'Sai', 22, 'B.E', '9952836777', 'Sai@gmail.com', 'Chennai', 'M'),
	(2, 3, 'Kumar', 20, 'BSC', '7890125648', 'Kumar@gmail.com', 'Madurai', 'M'),
	(3, 4, 'Selvi', 22, 'B.Tech', '8904567342', 'selvi@gmail.com', 'Selam', 'F'),
	(4, 5, 'Nisha', 25, 'M.E', '7834672310', 'Nisha@gmail.com', 'Theni', 'F'),
	(5, 6, 'SaiSaran', 21, 'B.A', '7890345678', 'saran@gmail.com', 'Madurai', 'F'),
	(6, 7, 'Tom', 23, 'BCA', '8901234675', 'Tom@gmail.com', 'Pune', 'M')

	--Write a sql server query to display the Gender,Total no of male and female from the above 
                 --  relation 
select Gender,count(gender) from StudentDetails group by gender















 





