--  ================= Assignment 4 : Student Marks Procedure ===================

use Assignment_Edu_Domain

-- Create Procedure
CREATE PROCEDURE sp_GetStudentMarks
    @StudentID INT
AS
BEGIN
    SELECT 
        s.FirstName + ' ' + s.LastName AS StudentName,
        c.CourseName,
        e.ExamCategory AS ExamType,
        m.MarksObtained
    FROM Students s
    JOIN Marks m ON s.StudentID = m.StudentID
    JOIN Exams e ON m.ExamID = e.ExamID
    JOIN Courses c ON e.CourseID = c.CourseID
    WHERE s.StudentID = @StudentID;
END;

-- Execute Procedure
EXEC sp_GetStudentMarks 5;