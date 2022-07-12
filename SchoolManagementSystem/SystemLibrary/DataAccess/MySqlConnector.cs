﻿using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLibrary.StudentAccountModels;
using MySql.Data.MySqlClient;
using Dapper;
using System.Configuration;
using SystemLibrary.TeacherAccountModels;
using SystemLibrary.AdminAccountModels;
using SystemLibrary.CommonModels;

namespace SystemLibrary.DataAccess {
    public class MySqlConnector : IDataConnector {

        private string Constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

        public void AddStudent(StudentModelSA studentModel) {

            try {

                MySqlConnection connection = new MySqlConnection(Constr);

                string sqlQuery = "INSERT INTO students(FirstName, LastName, EmailAddress, Password) VALUES(@FirstName, @LastName, @EmailAddress, @Password)";

                var rowsAffected = connection.Execute(sqlQuery, studentModel);

                MessageBox.Show("Student has been added.", "My App");

            }
            catch (Exception ex){
                MessageBox.Show($"{ex.Message}", "Error");
            }
        }

        public void AddTeacher(TeacherModelTA teacherModel) {
            
            try {

                MySqlConnection connection = new MySqlConnection(Constr);

                string sqlQuery = "INSERT INTO teachers(FirstName, LastName, EmailAddress, Password) VALUES(@FirstName, @LastName, @EmailAddress, @Password)";

                var rowsAffected = connection.Execute(sqlQuery, teacherModel);

                MessageBox.Show("Teacher has been added.", "My App");

            }
            catch (Exception ex) {
                MessageBox.Show($"{ex.Message}", "Error");
            }
        }

        public void AddAdmin(AdminModel adminModel) {
            
            try {

                MySqlConnection connection = new MySqlConnection(Constr);

                string sqlQuery = "INSERT INTO admins(FirstName, LastName, EmailAddress, Password) VALUES(@FirstName, @LastName, @EmailAddress, @Password)";

                var rowsAffected = connection.Execute(sqlQuery, adminModel);

                MessageBox.Show("Admin has been added.", "My App");

            }
            catch (Exception ex) {
                MessageBox.Show($"{ex.Message}", "Error");
            }
        }

        public List<TeacherModelSA> GetTeachers() {

            List<TeacherModelSA> teachers = new List<TeacherModelSA>();

            try {

                MySqlConnection connection = new MySqlConnection(Constr);

                connection.Open();

                teachers = connection.Query<TeacherModelSA>("select * from teachers").ToList();

            }
            catch {
            }
            return teachers;
        }

        public List<StudentModelTA> GetStudents() {

            List<StudentModelTA> students = new List<StudentModelTA>();

            try {

                MySqlConnection connection = new MySqlConnection(Constr);

                connection.Open();

                students = connection.Query<StudentModelTA>("select * from students").ToList();

            }
            catch {
            }
            return students;
        }

        public void AddCourse(CourseModelTA course, string teacherEmailAddress) {
            try {
                
                MySqlConnection connection = new MySqlConnection(Constr);

                var Name = course.Name;
                var StartDate = course.StartDate;
                var EndDate = course.EndDate;
                var TeacherEmailAddress = teacherEmailAddress;

                connection.Execute("insert into courses(Name, StartDate, EndDate, TeacherEmailAddress) " +
                    "values (@Name, @StartDate, @EndDate, @TeacherEmailAddress)", 
                    new { Name, StartDate, EndDate, TeacherEmailAddress });

                foreach (StudentModelTA s in course.Students) {
                    
                    var StudentEmailAddress = s.EmailAddress;
                    var CourseName = course.Name;
                    
                    connection.Execute("insert into studentcourserelation(StudentEmailAddress, CourseName) " +
                        "values (@StudentEmailAddress, @CourseName)", 
                        new { StudentEmailAddress, CourseName });
                }

                MessageBox.Show("Course has been added.", "My App");
            }
            catch (Exception ex) {
                MessageBox.Show($"{ex.Message}", "Error");
            }
        }

        public StudentModelSA ValidStudentPassword(string emailAddress, string password) {
            
            StudentModelSA student = null;

            try {
                MySqlConnection connection = new MySqlConnection(Constr);

                connection.Open();

                student = connection.Query<StudentModelSA>($"select * from students where EmailAddress = '{emailAddress}'").First();
            }
            catch {
                return null;
            }

            if (password.CheckPassword(student.Password)) {
                return student;
            }
            else {
                return null;
            }
        }

        public TeacherModelTA ValidTeacherPassword(string emailAddress, string password) {
            
            TeacherModelTA teacher = null;

            try {
                MySqlConnection connection = new MySqlConnection(Constr);

                connection.Open();

                teacher = connection.Query<TeacherModelTA>($"select * from teachers where EmailAddress = '{emailAddress}'").First();
            }
            catch {
                return null;
            }

            if (password.CheckPassword(teacher.Password)) {
                return teacher;
            }
            else {
                return null;
            }
        }

        public AdminModel ValidAdminPassword(string emailAddress, string password) {

            AdminModel admin = null;

            try {
                MySqlConnection connection = new MySqlConnection(Constr);

                connection.Open();

                admin = connection.Query<AdminModel>($"select * from admins where EmailAddress = '{emailAddress}'").First();
            }
            catch {
                return null;
            }

            if (password.CheckPassword(admin.Password)) {
                return admin;
            }
            else {
                return null;
            }
        }

        public List<string> GetUsersEmails() {

            List<string> teachersEmails;
            List<string> studentsEmails;

            MySqlConnection connection = new MySqlConnection(Constr);

            connection.Open();

            teachersEmails = connection.Query<string>("select EmailAddress from teachers").ToList();
            studentsEmails = connection.Query<string>("select EmailAddress from students").ToList();

            List<string> usersEmails = new List<string>(teachersEmails.Count + studentsEmails.Count);
            usersEmails.AddRange(teachersEmails);
            usersEmails.AddRange(studentsEmails);

            return usersEmails;
        }

        public void CreateMessage(MessageModel message) {
            try {
                MySqlConnection connection = new MySqlConnection(Constr);

                string sqlQuery = "INSERT INTO messages(SenderEmailAddress, ReceiverEmailAddress, Date, Title, Content) " +
                    "VALUES(@SenderEmailAddress, @ReceiverEmailAddress, @Date, @Title, @Content)";

                var rowsAffected = connection.Execute(sqlQuery, message);

                MessageBox.Show("Mesage has been sent.", "My App");
            }
            catch (Exception ex) {
                MessageBox.Show($"{ex.Message}", "Error");
            }
        }

        public List<MessageModel> GetReceivedMessages(string emailAddress) {

            List<MessageModel> messages = new List<MessageModel>();

            try {
                MySqlConnection connection = new MySqlConnection(Constr);

                connection.Open();

                messages = connection.Query<MessageModel>($"select SenderEmailAddress, ReceiverEmailAddress, Date, Title, Content from messages where ReceiverEmailAddress = '{emailAddress}' order by date").ToList();
            }
            catch {
            }

            return messages;
        }

        public List<MessageModel> GetSentMessages(string emailAddress) {
            
            List<MessageModel> messages = new List<MessageModel>();

            try {
                MySqlConnection connection = new MySqlConnection(Constr);

                connection.Open();

                messages = connection.Query<MessageModel>($"select SenderEmailAddress, ReceiverEmailAddress, Date, Title, Content from messages where SenderEmailAddress = '{emailAddress}' order by date").ToList();
            }
            catch {
            }

            return messages;
        }

        public List<CourseModelTA> GetTeacherCourses(string emailAddress) {

            List<CourseModelTA> courses = new List<CourseModelTA>();

            MySqlConnection connection = new MySqlConnection(Constr);

            connection.Open();

            courses = connection.Query<CourseModelTA>($"select Name, StartDate, EndDate " +
                $"from courses " +
                $"where TeacherEmailAddress = '{emailAddress}' " +
                $"order by StartDate").ToList();

            foreach (CourseModelTA course in courses) {

                course.Students = GetStudentsSignedToCourse(course.Name);

                foreach (StudentModelTA student in course.Students) {
                    student.Grades = GetStudentGradesFromCourse(student.EmailAddress, course.Name);
                }
            }

            return courses;
        }

        public List<StudentModelTA> GetStudentsSignedToCourse(string courseName) {

            List<StudentModelTA> students = new List<StudentModelTA>();

            MySqlConnection connection = new MySqlConnection(Constr);

            connection.Open();

            students = connection.Query<StudentModelTA>($"select StudentEmailAddress as EmailAddress " +
                    $"from studentcourserelation " +
                    $"where CourseName = '{courseName}'").ToList();

            foreach (StudentModelTA student in students) {

                student.FirstName = connection.Query<string>($"select FirstName " +
                    $"from students " +
                    $"where EmailAddress = '{student.EmailAddress}'").First();

                student.LastName = connection.Query<string>($"select LastName " +
                    $"from students " +
                    $"where EmailAddress = '{student.EmailAddress}'").First();
            }

            return students;
        }

        public List<GradeModel> GetStudentGradesFromCourse(string emailAddress, string courseName) {
            
            List<GradeModel> grades = new List<GradeModel>();

            MySqlConnection connection = new MySqlConnection(Constr);

            connection.Open();

            grades = connection.Query<GradeModel>($"select Name, Value " +
                    $"from grades " +
                    $"where CourseName = '{courseName}' and StudentEmailAddress = '{emailAddress}'").ToList();

            return grades;
        }

        public void CreateGrade(GradeModel grade, string courseName, string emailAddress) {

            MySqlConnection connection = new MySqlConnection(Constr);

            var Name = grade.Name;
            var Value = grade.Value;
            var CourseName = courseName;
            var StudentEmailAddress = emailAddress;

            connection.Execute("insert into grades(Name, Value, CourseName, StudentEmailAddress) " +
                "values (@Name, @Value, @CourseName, @StudentEmailAddress)",
                new { Name, Value, CourseName, StudentEmailAddress });
        }
    }
}
