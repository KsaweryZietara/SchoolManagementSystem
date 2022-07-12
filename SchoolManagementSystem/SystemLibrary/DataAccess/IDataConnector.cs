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

    /// <summary>
    /// Represents interface of data connector.
    /// </summary>
    public interface IDataConnector {

        /// <summary>
        /// Saves student model to database.
        /// </summary>
        /// <param name="studentModel">Student model to be saved.</param>
        void AddStudent(StudentModelSA studentModel);

        /// <summary>
        /// Saves teacher model to database.
        /// </summary>
        /// <param name="teacherModel">Teacher model to be saved.</param>
        void AddTeacher(TeacherModelTA teacherModel);

        /// <summary>
        /// Saves admin model to database.
        /// </summary>
        /// <param name="adminModel">Admin model to be saved.</param>
        void AddAdmin(AdminModel adminModel);

        /// <summary>
        /// Gets all teachers models from database.
        /// </summary>
        /// <returns>List of teachers models.</returns>
        List<TeacherModelSA> GetTeachers();

        /// <summary>
        /// Gets all students models from database.
        /// </summary>
        /// <returns>List of students models.</returns>
        List<StudentModelTA> GetStudents();

        /// <summary>
        /// Saves course model to database.
        /// </summary>
        /// <param name="course">Course model to be saved.</param>
        /// <param name="teacherEmailAddress">Email address of the leading teacher.</param>
        void AddCourse(CourseModelTA course, string teacherEmailAddress);

        /// <summary>
        /// Checks the password of the student.
        /// </summary>
        /// <param name="emailAddress">Email address of the student.</param>
        /// <param name="password">Password to be checked.</param>
        /// <returns>Student model if the password is valid, or null if not.</returns>
        StudentModelSA ValidStudentPassword(string emailAddress, string password);

        /// <summary>
        /// Checks the password of the teacher.
        /// </summary>
        /// <param name="emailAddress">Email address of the teacher.</param>
        /// <param name="password">Password to be checked.</param>
        /// <returns>Teacher model if the password is valid, or null if not.</returns>
        TeacherModelTA ValidTeacherPassword(string emailAddress, string password);

        /// <summary>
        /// Checks the password of the admin.
        /// </summary>
        /// <param name="emailAddress">Email address of the admin.</param>
        /// <param name="password">Password to be checked.</param>
        /// <returns>Admin model if the password is valid, or null if not.</returns>
        AdminModel ValidAdminPassword(string emailAddress, string password);

        /// <summary>
        /// Gets emails of the teachers and students.
        /// </summary>
        /// <returns>List of users emails.</returns>
        List<string> GetUsersEmails();

        /// <summary>
        /// Saves message model to database.
        /// </summary>
        /// <param name="message">Message model to be saved.</param>
        void CreateMessage(MessageModel message);

        /// <summary>
        /// Gets all received users messages from database.
        /// </summary>
        /// <param name="emailAddress">Email address of the user.</param>
        /// <returns>List of messages models received by user.</returns>
        List<MessageModel> GetReceivedMessages(string emailAddress);

        /// <summary>
        /// Gets all sent users messages from database.
        /// </summary>
        /// <param name="emailAddress">Email address of the user.</param>
        /// <returns>List of messages models sent by user.</returns>
        List<MessageModel> GetSentMessages(string emailAddress);

        /// <summary>
        /// Gets all courses which teacher is leading.
        /// </summary>
        /// <param name="emailAddress">Email address of the teacher.</param>
        /// <returns>List of course model which teacher is leading.</returns>
        List<CourseModelTA> GetTeacherCourses(string emailAddress);

        /// <summary>
        /// Gets all students signed to course.
        /// </summary>
        /// <param name="courseName">Name of the course.</param>
        /// <returns>List of the students models signed to course.</returns>
        List<StudentModelTA> GetSignedStudents(string courseName);

        /// <summary>
        /// Get all grades which student got in course.
        /// </summary>
        /// <param name="emailAddress">Email address of the student.</param>
        /// <param name="courseName">Name of the course.</param>
        /// <returns>List of the grades which student got in course.</returns>
        List<GradeModel> StudentGrades(string emailAddress, string courseName);

        /// <summary>
        /// Saves grade model to database.
        /// </summary>
        /// <param name="grade">Grade model to be saved.</param>
        /// <param name="courseName">Name of the course.</param>
        /// <param name="emailAddress">Email address of the student.</param>
        void CreateGrade(GradeModel grade, string courseName, string emailAddress);

        /// <summary>
        /// Gets all courses which student is signed to.
        /// </summary>
        /// <param name="emailAddress">Email address of the student.</param>
        /// <returns>List of courses which student is signed to.</returns>
        List<CourseModelSA> GetStudentCourses(string emailAddress);
    }
}
