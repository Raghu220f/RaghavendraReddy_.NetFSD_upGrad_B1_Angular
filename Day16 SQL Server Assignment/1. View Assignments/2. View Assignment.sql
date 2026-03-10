--  ================= Assignment 2 : Student Course Enrollment View ===================

use Assignment_Edu_Domain

-- Create View – vw_StudentCourses
CREATE VIEW vw_StudentCourses
AS
SELECT s.StudentID, s.FirstName + ' ' + s.LastName AS StudentName, c.CourseName, e.EnrollmentDate
FROM Students s JOIN Enrollments e 
ON s.StudentID = e.StudentID
JOIN Courses c 
ON e.CourseID = c.CourseID;

-- Show Courses Taken by StudentID = 5
SELECT *
FROM vw_StudentCourses
WHERE StudentID = 5;

-- Count Courses Taken by Each Student
SELECT StudentName, COUNT(CourseName) AS TotalCourses
FROM vw_StudentCourses
GROUP BY StudentName;

-- List Students Enrolled After 2024
SELECT *
FROM vw_StudentCourses
WHERE EnrollmentDate > '2024-01-01';