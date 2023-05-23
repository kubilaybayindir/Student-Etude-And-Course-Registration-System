Create Procedure EtudeProcedure
AS
SELECT Etudes.Id,CourseName,
(Teachers.Name +' '+Teachers.Surname) AS 'Teacher',
(Students.Name +' '+Students.Surname) AS 'Student',
Date,Hour,State
FROM Etudes 
INNER JOIN Courses 
ON
Etudes.CourseId=Course.Id 
INNER JOIN Teachers 
ON
Etudes.TeacherId=Teachers.Id 
INNER JOIN Students 
ON
Etudes.StudentId=Students.Id