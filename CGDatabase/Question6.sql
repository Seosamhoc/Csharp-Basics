--List the department number and name for all departments where no sales representatives work
SELECT Department_No, Department_Name FROM Departments d 
WHERE NOT (SELECT Job_ID FROM Jobs WHERE Job_Title='Sales Representative') in 
(SELECT Job_ID FROM Employees e WHERE d.Department_No=e.Department_No) 