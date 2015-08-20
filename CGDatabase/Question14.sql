--Show the avg salary for employees for one year rounded to 2 decimal places)
SELECT CAST(ROUND(AVG(Annual_Salary),2) AS decimal(10,2)) AS 'Average Salary' FROM Employees