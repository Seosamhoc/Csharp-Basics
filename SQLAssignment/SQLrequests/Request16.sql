--Produce a list of employees showing percentage raises, employee numbers and old and new salaries. 
--Employees in departments 20 and 10 are given a 5% rise, 
--employees in departments 50, 80, 90 and 110 are given a 10% rise and employees in other departments are not given a rise.
SELECT 
CASE WHEN Department_No IN (20, 10) THEN '5%' WHEN Department_No IN (50, 80, 90 , 110) THEN '10%' ELSE NULL END AS 'Percentage Raise',
Employee_No,
Annual_Salary AS 'Old Salary',
CASE WHEN Department_No IN (20, 10) THEN CAST(Annual_Salary*1.05 AS decimal(10,2))  WHEN Department_No IN (50, 80, 90 , 110) THEN CAST(Annual_Salary*1.1 AS decimal(10,2)) ELSE Annual_Salary END AS 'New Salary'
FROM Employees