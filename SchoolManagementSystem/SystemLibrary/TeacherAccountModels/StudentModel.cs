using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLibrary.CommonModels;

namespace SystemLibrary.TeacherAccountModels {
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
        /// Represents grades which students got in course.
        /// </summary>
        public List<GradeModel> Grades { get; set; } = new List<GradeModel>();
    }
}
