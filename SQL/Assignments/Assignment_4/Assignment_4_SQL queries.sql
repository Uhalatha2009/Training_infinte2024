--1--	Write a T-SQL Program to find the factorial of a given number.

create or alter proc factorial
@num int
as
begin
declare @i int = 1
declare @s int = 1
while   @i <=@num
	begin
	set @s=@s*@i
	set @i = @i+1
	end
end
print ' factorial of given number is ' + cast(@s as varchar(10))

factorial 6

--2--	Create a stored procedure to generate multiplication table that accepts a number and generates up to a given number. 

create or alter proc multiplication
@num1 int,@num2 int
as
begin
declare @i int = 1
while @i<=@num2
begin
print cast(@num1 as varchar(10))+' * '+ cast(@i as varchar(10))+'='+cast(@num1*@i as varchar(10))
set @i = @i+1
end
end

multiplication 6,10

      
--3--  Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like �Due to Independence day you cannot manipulate data� or "Due To Diwali", you cannot manipulate" etc

--Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. try to match and stop manipulation 

create  table tblholidays
(
   holiday_date date,
   holiday_name varchar(100),
 )
 insert into tblholidays values('2024-07-18', 'Sankranti '),
                                 ('2024-07-19', 'Independence day is today '),
								 ('2024-09-20', 'Diwali '),
								 ('2025-03-01', 'Holi')
select * from tblholidays


create or alter trigger trg_no_modification_emp_holiday
on tblemployees
instead of insert,update,delete
as
begin
	declare @holiday int
    select @holiday = count(*) from tblholidays where holiday_date = cast(getdate() as date)
    if @holiday>0
    begin
		declare @h_name varchar(10);
		select @h_name = holiday_name from tblholidays where holiday_date = cast(getdate() as date)
		select 'you cannot modify data because of ' + cast(@h_name as varchar(20))
	end
end
update tblemployees
set Salary=20000 where empid = 102








