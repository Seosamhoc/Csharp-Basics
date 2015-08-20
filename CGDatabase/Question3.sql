--List the dept number, lastname & salary of all employees who were hired
-- between 15/11/98 & 07/12/99 sorted asc order of last name
SELECT Department_No, Last_Name, Annual_Salary FROM Employees WHERE Hire_Date BETWEEN '1998/11/15' AND '1999/12/07' ORDER BY Last_Name ASC