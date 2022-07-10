using System;
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

                string sqlQuery1 = $"INSERT INTO courses(Name, StartDate, EndDate) VALUES(@Name, @StartDate, @EndDate)";
                var rowsAffected1 = connection.Execute(sqlQuery1, course);

                string sql = $"UPDATE courses SET TeacherEmailAddress = '{teacherEmailAddress}' WHERE Name = '{course.Name}'";
                var rowsAffected2 = connection.Execute(sql);

                foreach (StudentModelTA s in course.Students) {
                    var StudentEmailAddress = s.EmailAddress;
                    var CourseName = course.Name;
                    connection.Execute("insert into studentcourserelation(StudentEmailAddress, CourseName) values (@StudentEmailAddress, @CourseName)", new { StudentEmailAddress, CourseName });
                }

                MessageBox.Show("Course has been added.", "My App");
            }
            catch (Exception ex) {
                MessageBox.Show($"{ex.Message}", "Error");
            }
        }
    }
}
