using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary.Models {
    class CourseModel {

        /// <summary>
        /// Represents id of the course.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents name of the course.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents date of the message sending.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Represents date of the message sending.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Represents id of the teacher which lead the course.
        /// </summary>
        public int TeacherId { get; set; }

        /// <summary>
        /// Represents students which attend to course.
        /// </summary>
        public List<StudentModel> Students { get; set; } = new List<StudentModel>();

        /// <summary>
        /// Represents grades which students got course.
        /// </summary>
        public List<GradeModel> Grades { get; set; } = new List<GradeModel>();
    }
}
