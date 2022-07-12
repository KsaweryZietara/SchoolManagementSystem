using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLibrary.CommonModels;

namespace SystemLibrary.TeacherAccountModels {

    /// <summary>
    /// Represents teacher in teacher account.
    /// </summary>
    public class TeacherModelTA : IUserModel {

        /// <summary>
        /// Represents first name of the teacher. 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents last name of the teacher.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents email address of the teacher.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents password of the teacher.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Represents messages of teacher.
        /// </summary>
        public List<MessageModel> Messages { get; set; } = new List<MessageModel>();

        /// <summary>
        /// Represents courses which teacher lead.
        /// </summary>
        public List<CourseModelTA> Courses { get; set; } = new List<CourseModelTA>();

        /// <summary>
        /// Initializes a new instance of the TeacherModelTA class.
        /// </summary>
        public TeacherModelTA() {
        }

        /// <summary>
        /// Initializes a new instance of the TeacherModelTA class.
        /// </summary>
        /// <param name="firstName">First name of the teacher.</param>
        /// <param name="lastName">Last name of the teacher.</param>
        /// <param name="emailAddress">Email address of the teacher.</param>
        /// <param name="password">Password of the teacher.</param>
        public TeacherModelTA(string firstName, string lastName, string emailAddress, string password) {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Password = password;
        }
    }
}
