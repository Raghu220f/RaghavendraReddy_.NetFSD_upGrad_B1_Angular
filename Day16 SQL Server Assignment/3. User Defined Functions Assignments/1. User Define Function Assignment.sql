--  ================= Assignment 1 – Calculate Grade (Scalar Function). ===================

use Assignment_Edu_Domain

-- Create Scalar Function – fn_GetGrade
CREATE FUNCTION fn_GetGrade ( @MarksObtained INT )
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @Grade VARCHAR(10)

    IF @MarksObtained >= 90
        SET @Grade = 'A'
    ELSE IF @MarksObtained >= 75
        SET @Grade = 'B'
    ELSE IF @MarksObtained >= 60
        SET @Grade = 'C'
    ELSE
        SET @Grade = 'Fail'

    RETURN @Grade
END;

-- Use the Function to Display Grades in Exam Results
SELECT s.FirstName + ' ' + s.LastName AS StudentName, c.CourseName, e.ExamCategory AS ExamType, m.MarksObtained,
    dbo.fn_GetGrade(m.MarksObtained) AS Grade
FROM Students s JOIN Marks m 
ON s.StudentID = m.StudentID
JOIN Exams e 
ON m.ExamID = e.ExamID
JOIN Courses c 
ON e.CourseID = c.CourseID;
