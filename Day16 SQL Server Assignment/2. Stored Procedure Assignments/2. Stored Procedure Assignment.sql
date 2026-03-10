--  ================= Assignment 2 : Get Students By Department ===================

use Assignment_Edu_Domain

-- Create Procedure
CREATE PROCEDURE sp_GetStudentsByDepartment (@DepartmentID INT)
AS
BEGIN
    SELECT StudentID, FirstName + ' ' + LastName AS StudentName, AdmissionDate
    FROM Students
    WHERE DepartmentID = @DepartmentID;
END;

-- Execute for Department 2
EXEC sp_GetStudentsByDepartment 2;

-- Execute for Department 3
EXEC sp_GetStudentsByDepartment 3;