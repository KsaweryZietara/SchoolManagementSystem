using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLibrary.CommonModels;

namespace SystemLibrary.StudentAccountModels {
    public class CourseModelSA {

        /// <summary>
        /// Represents name of the course.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents date of the course beginning.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Represents date of the course ending.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Represents student grades in course.
        /// </summary>
        public List<GradeModel> Grades { get; set; }

        /// <summary>
        /// Represents teacher which is leading the course.
        /// </summary>
        public TeacherModelSA Teacher { get; set; }
    }
}
