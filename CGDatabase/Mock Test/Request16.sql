--Create a new view for clerks’s details only using all the fields from the employee table.
--*HINT* '%CLERK'

CREATE VIEW Clerks AS SELECT * FROM Employees WHERE Job_ID LIKE '%CLERK'