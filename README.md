
## ASSIST APP documentation

 **1.	What the app will do**
  []	Insert new tutor records
  [] Update tutor information
  [] Allow tutors to log in remotely and create an account
  [] Delete tutor records
  [] Insert new student records
  [] Update student information
  [] Delete student records
  [] Assign tutors to students
  [] Create a pdf printout of the assignment
  [] Look up assigned students and tutors
  [] Login 
  [] Insert new director
  [] Add new subjects
  [] Delete/ remove subjects
  [] Check up on existing curriculum

**2.	Database layouts**

- **tblTutor** (_tutorID_, tutorFirstName, tutorLastName, tutorPhoneNo, tutorEmail, tutorDegree, tutorUniversity, tutorJoinDate, tutorLeaveDate, tutorNote)
- **tblTutorSubject** (_tutorID_, tutorSubject, tutorNumberTutoring)
- **tblSubject**(_subjectID_, subjectName, subjectGrade, subjectTutorCount, subjectStudentCount)
- **tblStudent**(_studentID_, studentFirstName, studentLastName, studentPhoneNo, studentSchool, studentGrade)
- **tblStudentSubject** (_studentID_, studentSubject)
- **tblAssignment** (_tutorID_, _studentID_)
- **tblDirector** (_directorID_, directorTitle, directorFirstName, directorLastName, directorPhoneNo, directorEmail, directorDegree, directorUniversity, directorJoinDate, directorLeaveDate, directorNote)
- **tblSubjectContent** (_subjectID_, subjectGrade, subjectTopic, subjectWeek, subjectComplete)


On another note:
>Don't have too many expectations of me! Coding can be difficult!
