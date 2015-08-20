--Create a new table called SAL_HISTORY to include the fields Employee_No, 
--First_Name, Last_Name, Hire_Date And Annual_Salary with 
--the same datatypes as the employee table


CREATE TABLE SAL_HISTORY (
    Employee_No        INT            NOT NULL,
    First_Name         VARCHAR (20)   NULL,
    Last_Name          VARCHAR (25)   NOT NULL,
    Hire_Date         DATETIME       NOT NULL,
    Annual_Salary      DECIMAL (8, 2) NULL
);