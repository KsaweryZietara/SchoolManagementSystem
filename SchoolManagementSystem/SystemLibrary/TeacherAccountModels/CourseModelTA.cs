using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary.TeacherAccountModels {

    /// <summary>
    /// Represents course in teacher account.
    /// </summary>
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

        /// <summary>
        /// Initializes a new instance of the CourseModelTA class.
        /// </summary>
        /// <param name="name">Name of the course.</param>
        /// <param name="startDate">Date of the course beginning.</param>
        /// <param name="endDate">Date of the course ending.</param>
        public CourseModelTA(string name, DateTime startDate, DateTime endDate) {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
        }

        /// <summary>
        /// Initializes a new instance of the CourseModelTA class.
        /// </summary>
        /// <param name="name">Name of the course.</param>
        /// <param name="startDate">Date of the course beginning.</param>
        /// <param name="endDate">Date of the course ending.</param>
        /// <param name="students">Students which attend to course.</param>
        public CourseModelTA(string name, DateTime startDate, DateTime endDate, List<StudentModelTA> students) {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            Students = students;
        }
    }
}
