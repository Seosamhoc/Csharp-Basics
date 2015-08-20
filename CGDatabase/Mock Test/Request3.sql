--List all the data for all jobs where the maximum salary is greater than 12000 sorted in ascending order of the maximum salary.
SELECT * FROM Jobs
WHERE Max_Salary > 12000
ORDER BY Max_Salary ASC