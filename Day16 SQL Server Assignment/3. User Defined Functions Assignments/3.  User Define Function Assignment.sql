--  ================= Assignment 3 – Total Marks Function ===================

use Assignment_Edu_Domain

-- Create Function
CREATE FUNCTION fn_GetTotalMarks (@StudentID INT)
RETURNS INT
AS
BEGIN
    DECLARE @TotalMarks INT

    SELECT @TotalMarks = SUM(MarksObtained)
    FROM Marks
    WHERE StudentID = @StudentID

    RETURN @TotalMarks
END;

-- Use Function
SELECT StudentID, FirstName + ' ' + LastName AS StudentName,
    dbo.fn_GetTotalMarks(StudentID) AS TotalMarks
FROM Students;