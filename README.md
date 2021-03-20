# ASSIST
ASSIST APP documentation

1.	What the app will do
•	Insert new tutor records
•	Update tutor information
•	Delete tutor records
•	Insert new student records
•	Update student information
•	Delete student records
•	Assign tutors to students
•	Create a pdf printout of the assignment
•	Look up assigned students and tutors
•	Login 
•	Insert new director
•	Add new subjects
•	Delete/ remove subjects
•	Check up on existing curriculum

2.	Database layouts

•	tblTutor (tutorID, tutorFirstName, tutorLastName, tutorPhoneNo, tutorEmail, tutorDegree, tutorUniversity, tutorJoinDate, tutorLeaveDate, tutorNote)
•	tblTutorSubject (tutorID, tutorSubject, tutorNumberTutoring)
•	tblSubject(subjectID, subjectName, subjectGrade, subjectTutorCount, subjectStudentCount)
•	tblStudent(studentID, studentFirstName, studentLastName, studentPhoneNo, studentSchool, studentGrade)
•	tblStudentSubject (studentID, studentSubject)
•	tblAssignment (tutorID, studentID)
•	tblDirector (directorID, directorTitle, directorFirstName, directorLastName, directorPhoneNo, directorEmail, directorDegree, directorUniversity, directorJoinDate, directorLeaveDate, directorNote)
•	tblSubjectContent (subjectID, subjectGrade, subjectTopic, subjectWeek, subjectComplete)

