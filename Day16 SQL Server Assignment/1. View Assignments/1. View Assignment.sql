--  ================= Assignment 1 :  Student Department View ===================

use Assignment_Edu_Domain

-- Create View – vw_StudentDepartment
CREATE VIEW vw_StudentDepartment
AS
SELECT 
    s.StudentID,
    s.FirstName + ' ' + s.LastName AS StudentName,
    d.DepartmentName,
    s.AdmissionDate
FROM Students s
JOIN Departments d 
ON s.DepartmentID = d.DepartmentID;

-- Retrieve All Records from the View 
SELECT * FROM vw_StudentDepartment;

-- Filter Students from Computer Science Department
SELECT *
FROM vw_StudentDepartment
WHERE DepartmentName = 'Computer Science';

-- Drop the View
DROP VIEW vw_StudentDepartment;
