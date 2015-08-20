--List the last name job and commission percentage of employees where
--the commission percentage is less than or equal to 15% sorted in
-- desc order of commission percentage

SELECT Last_Name, Job_Title, CONCAT(Commission_Percent*100,'%') AS 'Commission Percentage' FROM Employees JOIN Jobs ON Employees.Job_ID=Jobs.Job_ID WHERE Commission_Percent <= 0.15 ORDER BY Commission_Percent DESC