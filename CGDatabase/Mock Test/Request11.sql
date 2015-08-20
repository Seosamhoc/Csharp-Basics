--List the department number and name for all departments where no sales representatives work.
--*HINT* JOIN Employees JOIN Jobs
SELECT Department_No, Department_Name FROM Departments WHERE Department_No NOT IN (SELECT Department_No FROM Employees WHERE Job_ID=(SELECT Job_ID FROM Jobs WHERE Job_Title='sales representative'))