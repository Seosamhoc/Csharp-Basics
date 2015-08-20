--List the last name, first name, employee number of all stock clerks who were hired 
--on or before 26th August 1998 sorted in ascending order of last name

SELECT Last_Name, First_Name, Employee_No FROM Employees WHERE Job_ID=(SELECT Job_ID FROM Jobs WHERE Job_Title='Stock Clerk') AND Hire_Date <= '1998-08-26' ORDER BY Last_Name ASC