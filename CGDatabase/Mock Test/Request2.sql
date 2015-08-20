--List the last name, first name and employee number of all programmers who were hired on or before 11 Feburary 1994 sorted in descending order of last name
--*HINT* JOIN Jobs
SELECT Last_Name, First_Name, Employee_No
FROM Employees
WHERE Hire_Date <= '1994/02/11' AND Job_ID = (SELECT Job_ID FROM Jobs WHERE Job_Title='programmer')
ORDER BY Last_Name DESC