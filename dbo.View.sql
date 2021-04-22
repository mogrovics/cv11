CREATE VIEW [dbo].[StudentCountView]
	AS SELECT Subject, COUNT(StudentId) AS Students FROM Registration GROUP BY Subject
