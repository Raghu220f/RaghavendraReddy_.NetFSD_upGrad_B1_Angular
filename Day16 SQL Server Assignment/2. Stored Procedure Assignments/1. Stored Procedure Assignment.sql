--  ================= Assignment 1 : Insert Student Procedure. ===================

use Assignment_Edu_Domain

-- Create Procedure
CREATE PROCEDURE sp_InsertStudent
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Gender CHAR(1),
    @DepartmentID INT,
    @AdmissionDate DATE
AS
BEGIN
    INSERT INTO Students (FirstName, LastName, Gender, DepartmentID, AdmissionDate)
    VALUES (@FirstName, @LastName, @Gender, @DepartmentID, @AdmissionDate);
END;

-- Execute Procedure
EXEC sp_InsertStudent 'Rohan','Sharma','M',1,'2024-06-01';

-- Verify Data
SELECT * FROM Students WHERE FirstName='Rohan';