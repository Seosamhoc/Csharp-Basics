--List the dept no and name for all depts where no stock clerks work
SELECT Department_No, Department_Name 
FROM Departments 
WHERE Department_No != (
	SELECT DISTINCT(Department_No) 
	FROM Employees
	WHERE Job_ID = (SELECT Job_ID FROM Jobs WHERE Job_Title='stock clerk')
);


SELECT DISTINCT Departments.Department_Name, Departments.Department_No
FROM Departments INNER JOIN Employees ON Employees.Department_No=Departments.Department_No
WHERE Employees.Job_ID NOT LIKE 'ST%'