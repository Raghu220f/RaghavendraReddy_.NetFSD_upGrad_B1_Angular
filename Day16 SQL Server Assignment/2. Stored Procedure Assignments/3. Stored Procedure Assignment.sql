--  ================= Assignment 3 : Course Enrollment Procedure ===================

use Assignment_Edu_Domain

-- Create Procedure
CREATE PROCEDURE sp_EnrollStudent ( @StudentID INT, @CourseID INT )
AS
BEGIN
    INSERT INTO Enrollments (StudentID, CourseID, EnrollmentDate)
    VALUES (@StudentID, @CourseID, GETDATE());
END;

-- Execute Procedure
EXEC sp_EnrollStudent 5, 3;

-- Verify Data
SELECT * FROM Enrollments
WHERE StudentID = 5 AND CourseID = 3;

