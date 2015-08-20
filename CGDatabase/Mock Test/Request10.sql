--List the department number, department name and the number of employees for the department that has the lowest number of employees using appropriate grouping
--*HINT* JOIN Employees

--CREATE VIEW DepartmentEmployeeCount AS
--(SELECT Departments.Department_No, Department_Name, COUNT(Employee_No) AS 'NumberOfEmployees'
--FROM Departments JOIN Employees ON (Departments.Department_No=Employees.Department_No)
--GROUP BY Departments.Department_No, Department_Name);

SELECT * FROM DepartmentEmployeeCount WHERE NumberOfEmployees = (SELECT MIN(NumberOfEmployees) FROM DepartmentEmployeeCount)