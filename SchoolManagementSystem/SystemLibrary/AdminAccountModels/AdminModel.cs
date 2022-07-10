using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary.AdminAccountModels {
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

        public AdminModel() {
        }

        public AdminModel(string firstName, string lastName, string emailAddress, string password) {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Password = password;
        }
    }
}
