--Show the total salaries figure for one month displayed with no decimal places
SELECT CAST(SUM(Annual_Salary)/12 AS INTEGER) AS 'Total Monthly Salary' FROM Employees