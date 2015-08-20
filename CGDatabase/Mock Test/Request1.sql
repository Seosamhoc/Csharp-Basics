--List the last name, first name and employee number of all employees that have a last name starting with M.
SELECT Last_Name, First_Name, Employee_No 
FROM Employees
WHERE Last_Name LIKE 'M%';