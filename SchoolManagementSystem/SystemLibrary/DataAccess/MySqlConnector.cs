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
    }
}
