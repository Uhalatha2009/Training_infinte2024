use Assignmentss

create table tblDEPT
(
	deptno int primary key,
	dname varchar(30),
	loc varchar(30)
)

insert into tblDEPT values
(10,'ACCOUNTING','NEW YORK'),
(20,'RESEARCH','DALLAS'),
(30,'SALES','CHICAGO'),
(40,'OPERATIONS','BOSTON')



select * from tblDEPT

---------------------------------------------------------

create table tblEMP
(
	empno int primary key,
	ename varchar(30),
	job varchar (30),
	mgr_id int,
	hiredate DATE,
	sal float,
	comm int,
	Deptno int references tblDEPT(deptno)
)

insert into tblEMP values
(7369, 'SMITH', 'CLERK', 7902,'1980-12-17' , 800, NULL, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975, NULL, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL, 30),
(7782, 'CLARK', 'MANAGER', 7839, '1981-06-09', 2450, NULL, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '1987-04-19', 3000, NULL, 20),
(7839, 'KING', 'PRESIDENT', NULL, '1981-11-17', 5000, NULL, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30),
(7876, 'ADAMS', 'CLERK', 7788, '1987-05-23', 1100, NULL, 20),
(7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30),
(7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20),
(7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, NULL, 10)


select * from tblEMP


-----------------------------queries------------------------
--1 Retrieve a list of MANAGERS. 
select ename from tblEMP where job='manager';
 
--2 Find out the names and salaries of all employees earning more than 1000 per 
--month. 
select ename,sal from tblEMP where sal > 1000;
 
--3 Display the names and salaries of all employees except JAMES.
select ename,sal from tblEMP where ename <> 'JAMES';
 
--4 Find out the details of employees whose names begin with ‘S’. 
select * from tblEMP where ename like 'S%';
 
--5 Find out the names of all employees that have ‘A’ anywhere in their name. 
select * from tblEMP where ename like '%A%';
 
--6 Find out the names of all employees that have ‘L’ as their third character in 
--their name. 
select * from tblEMP where ename like'__L%';
 
--7 Compute daily salary of JONES. 
select sal/30 as 'daily salary' from tblEMP where ename = 'JONES';
 
--8 Calculate the total monthly salary of all employees.
select Sum(sal) as 'Totalmonthlysalary' from tblEMP
 
 
--9 Print the average annual salary . 
select avg(sal*12) as 'annual salary'from tblEMP
 
--10 Select the name, job, salary, department number of all employees except 
--SALESMAN from department number 30. 
select ename,job,sal,deptno from tblEMP where deptno= 30 and job <> 'SALESMAN';
 
--11 List unique departments of the EMP table.
select distinct Deptno 
from tblEMP;

 
--12 List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select ename as Employee, sal as Monthly_Salary 
from tblEMP
where sal>1500 and deptno=10 or deptno=30

--13 Display the name, job, and salary of all the employees whose job is MANAGER or 
--ANALYST and their salary is not equal to 1000, 3000, or 5000.
select ename, job,sal from tblEMP where (job like'manager' or job like 'analyst') and (sal !=1000 or sal !=3000 or sal !=5000)

--14 Display the name, salary and commission for all employees whose commission 
--amount is greater than their salary increased by 10%.
select ename,sal,comm from tblEMP where comm > sal*0.1
 
--15 Display the name of all employees who have two Ls in their name and are in 
--department 30 or their manager is 7782. 
select ename from tblEMP where ename like' %L%L% 'and Deptno=30 or mgr_id = 7782
 
--16 Display the names of employees with experience of over 30 years and under 40 yrs.
--Count the total number of employees. 
select ename as 'names of employees' from tblEMP where DATEDIFF(yy,HIREDATE,GETDATE()) between 30 and 40

--17 Retrieve the names of departments in ascending order and their employees in 
--descending order.
select t1.dname as 'department',t2.ename as 'employees'from tblDEPT t1 left join tblEMP t2 on t1.deptno=t2.deptno order by t1.dname asc,t2.ename desc
 
--18 Find out experience of MILLER.
select DATEDIFF(year,HIREDATE,getdate()) as'experience un years' from tblEMP where ename ='MILLER'

 