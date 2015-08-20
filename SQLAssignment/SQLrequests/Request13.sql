--Update all the maximum salaries for jobs with an increase of 1000.
SELECT Max_Salary FROM Jobs;
UPDATE Jobs SET Max_Salary += 1000;
SELECT Max_Salary FROM Jobs;