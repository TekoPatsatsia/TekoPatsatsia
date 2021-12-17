select Teachers.Firstname, Teachers.Lastname from Pupils
			inner join TeacherPupil on Pupils.PupilID=TeacherPupil.PupilID
			inner join Teachers  on TeacherPupil.TeacherID=Teachers.TeacherID
where Pupils.Firstname = N'გიორგი'