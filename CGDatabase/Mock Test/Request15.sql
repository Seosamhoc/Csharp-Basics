--a) The job history for employee number 125 is no longer required. Delete this record.
DELETE FROM Job_History WHERE Employee_No = 125

--b) List all the data for job history sorted in descending order of employee number.
SELECT * FROM Job_History ORDER BY Employee_No DESC