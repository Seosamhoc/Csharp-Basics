--List the department name, location, last name and salary of employees who work in location 1700 sorted in ascending order of department name.
--*HINT* JOIN Employees
SELECT Department_Name, Location_ID, Last_Name, Annual_Salary FROM Employees JOIN Departments ON (Departments.Department_No=Employees.Department_No)
WHERE Location_ID= 1700
ORDER BY Department_Name ASC