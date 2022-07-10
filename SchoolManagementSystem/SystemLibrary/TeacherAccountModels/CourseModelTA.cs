using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary.TeacherAccountModels {
    public class CourseModelTA {

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
        public List<StudentModelTA> Students { get; set; } = new List<StudentModelTA>();

        public CourseModelTA(string name, DateTime startDate, DateTime endDate, List<StudentModelTA> students) {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            Students = students;
        }
    }
}
