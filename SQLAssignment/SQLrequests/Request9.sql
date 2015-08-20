﻿--List the department number, department name and the number of employees for each department that has more than 2 employees grouping by department number and department name.
SELECT Departments.Department_No, Department_Name, COUNT(Employee_No) AS 'Number Of Employees' FROM Departments JOIN Employees ON (Departments.Department_No=Employees.Department_No) GROUP BY Departments.Department_No, Department_Name HAVING COUNT(Employee_No)>2