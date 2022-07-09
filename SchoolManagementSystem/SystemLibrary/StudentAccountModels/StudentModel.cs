using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLibrary.CommonModels;

namespace SystemLibrary.StudentAccountModels {
    public class StudentModel {

        /// <summary>
        /// Represents first name of the student. 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents last name of the student.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents email address of the student.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents password of the student.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Represents messages of the student.
        /// </summary>
        public List<MessageModel> Messages { get; set; } = new List<MessageModel>();

        /// <summary>
        /// Represents courses which student attend.
        /// </summary>
        public List<CourseModel> Courses { get; set; } = new List<CourseModel>();

        public StudentModel(string firstName, string lastName, string emailAddress, string password) {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Password = password;
        }
    }
}
