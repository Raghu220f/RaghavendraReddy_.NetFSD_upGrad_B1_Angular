--  ================= Assignment 6 – Delete Enrollment ===================

use Assignment_Edu_Domain

-- Create Procedure
CREATE PROCEDURE sp_DeleteEnrollment
    @EnrollmentID INT
AS
BEGIN
    DELETE FROM Enrollments
    WHERE EnrollmentID = @EnrollmentID;

    SELECT *
    FROM Enrollments
    WHERE EnrollmentID = @EnrollmentID;
END;

-- Execute Procedure
EXEC sp_DeleteEnrollment 5;