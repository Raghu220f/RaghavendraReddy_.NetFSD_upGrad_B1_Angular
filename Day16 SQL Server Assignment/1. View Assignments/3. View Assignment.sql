--  ================= Assignment 3 : Exam Result View ===================

use Assignment_Edu_Domain

-- Create View – vw_ExamResults
CREATE VIEW vw_ExamResults
AS
SELECT s.StudentID, s.FirstName + ' ' + s.LastName AS StudentName, c.CourseName, e.ExamCategory AS ExamType, m.MarksObtained
FROM Students s JOIN Marks m 
ON s.StudentID = m.StudentID
JOIN Exams e 
ON m.ExamID = e.ExamID
JOIN Courses c 
ON e.CourseID = c.CourseID;

-- Retrieve Students Scoring More Than 80
SELECT *
FROM vw_ExamResults
WHERE MarksObtained > 80;

-- Retrieve Top Scorers in Each Exam
SELECT StudentName, CourseName, ExamType, MarksObtained
FROM vw_ExamResults v
WHERE MarksObtained = ( SELECT MAX(MarksObtained)
                        FROM vw_ExamResults
                        WHERE CourseName = v.CourseName );
                        
-- Find Students Who Failed
SELECT *
FROM vw_ExamResults
WHERE MarksObtained < 40;
