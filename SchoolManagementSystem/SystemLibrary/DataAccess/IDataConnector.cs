using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLibrary.AdminAccountModels;
using SystemLibrary.CommonModels;
using SystemLibrary.StudentAccountModels;
using SystemLibrary.TeacherAccountModels;

namespace SystemLibrary.DataAccess {
    public interface IDataConnector {
        void AddStudent(StudentModelSA studentModel);

        void AddTeacher(TeacherModelTA teacherModel);

        void AddAdmin(AdminModel adminModel);

        List<TeacherModelSA> GetTeachers();

        List<StudentModelTA> GetStudents();

        void AddCourse(CourseModelTA course, string teacherEmailAddress);

        StudentModelSA ValidStudentPassword(string emailAddress, string password);

        TeacherModelTA ValidTeacherPassword(string emailAddress, string password);

        AdminModel ValidAdminPassword(string emailAddress, string password);

        List<string> GetUsersEmails();

        void CreateMessage(MessageModel message);

        List<MessageModel> GetReceivedMessages(string emailAddress);

        List<MessageModel> GetSentMessages(string emailAddress);

        List<CourseModelTA> GetTeacherCourses(string emailAddress);

        List<StudentModelTA> GetStudentsSignedToCourse(string courseName);

        List<GradeModel> GetStudentGradesFromCourse(string emailAddress, string courseName);

        void CreateGrade(GradeModel grade, string courseName, string emailAddress);
    }
}
