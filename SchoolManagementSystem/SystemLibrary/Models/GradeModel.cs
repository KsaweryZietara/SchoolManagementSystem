using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary.Models {
    class GradeModel {

        /// <summary>
        /// Represents id of the grade.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents name of the course.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents id of the student to which grade belongs. 
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// Represents valude of the grade.
        /// </summary>
        public int Value { get; set; }
    }
}
