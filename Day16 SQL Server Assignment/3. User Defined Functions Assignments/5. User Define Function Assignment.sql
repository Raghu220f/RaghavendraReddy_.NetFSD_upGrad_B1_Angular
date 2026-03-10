--  ================= Assignment 5 – Department Students Function (Table Valued) ===================

use Assignment_Edu_Domain

-- Create Function
CREATE FUNCTION fn_GetDepartmentStudents(@DepartmentID INT)
RETURNS TABLE
AS
RETURN
(
    SELECT StudentID, FirstName + ' ' + LastName AS StudentName, AdmissionDate
    FROM Students
    WHERE DepartmentID = @DepartmentID
);

-- Execute Function
SELECT * FROM dbo.fn_GetDepartmentStudents(2);