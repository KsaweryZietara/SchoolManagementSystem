using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary.StudentAccountModels {

    /// <summary>
    /// Represents teacher in student account.
    /// </summary>
    public class TeacherModelSA {

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
    }
}
