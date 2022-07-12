using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary.AdminAccountModels {

    /// <summary>
    /// Represents admin account.
    /// </summary>
    public class AdminModel {

        /// <summary>
        /// Represents first name of the admin. 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents last name of the admin.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents email address of the admin.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents password of the admin.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Initializes a new instance of the AdminModel class.
        /// </summary>
        public AdminModel() {
        }

        /// <summary>
        /// Initializes a new instance of the AdminModel class.
        /// </summary>
        /// <param name="firstName">First name of the admin.</param>
        /// <param name="lastName">Last name of the admin.</param>
        /// <param name="emailAddress">Email address of the admin.</param>
        /// <param name="password">Password of the admin.</param>
        public AdminModel(string firstName, string lastName, string emailAddress, string password) {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Password = password;
        }
    }
}
