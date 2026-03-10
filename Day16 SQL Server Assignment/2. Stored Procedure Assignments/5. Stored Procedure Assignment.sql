--  ================= Assignment 5 – Update Student Marks ===================

use Assignment_Edu_Domain

-- Create Procedure
CREATE PROCEDURE sp_UpdateMarks
    @MarkID INT,
    @NewMarks INT
AS
BEGIN
    UPDATE Marks SET MarksObtained = @NewMarks
    WHERE MarkID = @MarkID;

    SELECT * FROM Marks
    WHERE MarkID = @MarkID;
END;

-- Execute Procedure
EXEC sp_UpdateMarks 5, 95;