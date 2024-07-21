use Assignmentss
-------------------------------

--1--- Write a T-Sql based procedure to generate complete payslip of a given employee with respect to the following condition

     --a) HRA as 10% of Salary
   --b) DA as 20% of Salary
   --c) PF as 8% of Salary
   --d) IT as 5% of Salary
   --e) Deductions as sum of PF and IT
   --f) Gross Salary as sum of Salary, HRA, DA
   --g) Net Salary as Gross Salary - Deductions

--Print the payslip neatly with all details


 create or alter proc Generate_Payslips
 @empid int
 as
 begin

 declare @EName Varchar(100)
   declare  @Sal float 
   declare  @HRA float 
   declare  @DA float 
   declare  @PF float
   declare  @IT float
   declare  @Deductions float
   declare  @GrossSalary float
   declare  @NetSalary float


   Select @EName = EName, @Sal = Sal From tblEMP Where empno = @empid

   Set @HRA = 0.1 * @Sal
   Set @DA = 0.2 * @Sal
   Set @PF = 0.08 * @Sal
   Set @IT = 0.05 * @Sal
   Set @Deductions = @PF + @IT
   Set @GrossSalary = @Sal + @HRA + @DA
   Set @NetSalary = @GrossSalary - @Deductions

   Print '- Payslip of Employee ' + Cast(@Empid AS VARCHAR(10)) + ' is generated as below: ---'
   Print 'Employee ID = ' + Cast(@Empid AS VARCHAR(10))
   Print 'Employee Name = ' + cast(@eName as varchar(10))
   Print 'Basic salary = ' + Cast(@Sal AS VARCHAR(10))
   Print 'HRA = ' + Cast(@HRA AS VARCHAR(10))
   Print 'DA = ' + Cast(@DA AS VARCHAR(10))
   Print 'PF Deductions = ' + Cast(@PF AS VARCHAR(10))
   Print 'IT Deductions = ' + Cast(@IT AS VARCHAR(10))
   Print 'Total Deductions (PF+IT) = ' + Cast(@Deductions AS VARCHAR(10))
   Print 'Total Gross salary = ' + cast(@GrossSalary AS VARCHAR(10))
   Print 'Total Net Salary = ' + Cast(@NetSalary AS VARCHAR(10))
   Print 'Payslip Generated Successfully'

   Select empno as 'Employee id', ename as 'Employee Name', @Sal as 'Basic salary',
          @HRA as 'HRA',
          @DA as 'DA',
          @PF as 'PF Deductions',
          @IT as 'IT Deductions',
          @Deductions as 'Total Deductions',
          @GrossSalary as 'Total Gross salary',
          @NetSalary as 'Net salary'
   From tblEMP Where empno = @Empid
  
End
Generate_Payslips 7499