using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary.TeacherAccountModels {
    public class CourseModel {

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
        /// Represents students which attend to course.
        /// </summary>
        public List<StudentModel> Students { get; set; } = new List<StudentModel>();
    }
}
