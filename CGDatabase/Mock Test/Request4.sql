--List all the data for all jobs where the minimum salary is less than or equal to 4500 sorted in descending order of the minimum salary.
SELECT * FROM Jobs 
WHERE Min_Salary <= 4500
ORDER BY Min_Salary DESC