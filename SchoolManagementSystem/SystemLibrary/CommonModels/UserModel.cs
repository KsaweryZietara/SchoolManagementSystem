using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary.CommonModels {
    public interface UserModel {

        /// <summary>
        /// Represents messages of teacher.
        /// </summary>
        List<MessageModel> Messages { get; set; }

        /// <summary>
        /// Represents email address of the teacher.
        /// </summary>
        string EmailAddress { get; set; }
    }
}
