--  ================= Assignment 4 : Aggregate View ===================

use Assignment_Edu_Domain

-- Create View – vw_DepartmentStudentCount
CREATE VIEW vw_DepartmentStudentCount
AS
SELECT d.DepartmentName, COUNT(s.StudentID) AS TotalStudents
FROM Departments d
LEFT JOIN Students s
ON d.DepartmentID = s.DepartmentID
GROUP BY d.DepartmentName;

-- Departments with more than 10 students
SELECT *
FROM vw_DepartmentStudentCount
WHERE TotalStudents > 10;

-- Sort by highest student count
SELECT *
FROM vw_DepartmentStudentCount
ORDER BY TotalStudents DESC;