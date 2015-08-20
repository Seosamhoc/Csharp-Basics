--Which jobs are found in the Marketing and Accounting departments? 
--*HINT* JOIN Employees JOIN Jobs OR

SELECT Job_Title 
FROM Jobs
WHERE Job_ID IN (SELECT Job_ID FROM Employees WHERE Department_No IN 
		(SELECT Department_No FROM Departments WHERE Department_Name IN ('Marketing', 'Accounting')))