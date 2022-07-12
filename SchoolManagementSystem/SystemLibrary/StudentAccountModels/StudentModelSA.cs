using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLibrary.CommonModels;

namespace SystemLibrary.StudentAccountModels {

    /// <summary>
    /// Represents student in student account.
    /// </summary>
    public class StudentModelSA : IUserModel {

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
        public List<CourseModelSA> Courses { get; set; } = new List<CourseModelSA>();

        /// <summary>
        /// Initializes a new instance of the StudentModelSA class.
        /// </summary>
        public StudentModelSA() {
        }

        /// <summary>
        /// Initializes a new instance of the StudentModelSA class.
        /// </summary>
        /// <param name="firstName">First name of the student.</param>
        /// <param name="lastName">Last name of the student.</param>
        /// <param name="emailAddress">Email address of the student.</param>
        /// <param name="password">Password of the student.</param>
        public StudentModelSA(string firstName, string lastName, string emailAddress, string password) {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Password = password;
        }
    }
}
