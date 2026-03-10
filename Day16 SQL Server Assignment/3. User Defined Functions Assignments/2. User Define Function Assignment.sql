--  ================= Assignment 2 – Student Age Function ===================

use Assignment_Edu_Domain

-- Create Function
CREATE FUNCTION fn_GetStudentAge(@DateOfBirth DATE)
RETURNS INT
AS
BEGIN
    DECLARE @Age INT
    SET @Age = DATEDIFF(YEAR, @DateOfBirth, GETDATE())
    RETURN @Age
END;

-- Use Function
SELECT 
    StudentID,
    FirstName + ' ' + LastName AS StudentName,
    DateOfBirth,
    dbo.fn_GetStudentAge(DateOfBirth) AS Age
FROM Students;