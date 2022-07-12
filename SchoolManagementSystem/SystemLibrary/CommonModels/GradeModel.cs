using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary.CommonModels {

    /// <summary>
    /// Represents grade.
    /// </summary>
    public class GradeModel {

        /// <summary>
        /// Represents name of the grade.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents value of the grade.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Initializes a new instance of the GradeModel class.
        /// </summary>
        /// <param name="name">Name of the grade.</param>
        /// <param name="value">Valude of the grade.</param>
        public GradeModel(string name, int value) {
            Name = name;
            Value = value;
        }
    }
}
