--a) The job history for employee number 102 is no longer required. Delete this record
DELETE FROM Job_History WHERE Employee_No = 102;
--b) List all the data for job history sorted in ascending order of employee number.
SELECT * FROM Job_History ORDER BY Employee_No ASC
