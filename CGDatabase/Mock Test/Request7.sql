--Show the total salaries figure for one week displayed with no decimal places.
SELECT CAST(SUM(Annual_Salary)/52 AS INT ) AS 'Total Week of Salary' 
FROM Employees