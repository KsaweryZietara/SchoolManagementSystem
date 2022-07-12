using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary.CommonModels {

    /// <summary>
    /// Representes interface of the user.
    /// </summary>
    public interface IUserModel {

        /// <summary>
        /// Represents messages of the user.
        /// </summary>
        List<MessageModel> Messages { get; set; }

        /// <summary>
        /// Represents email address of the user.
        /// </summary>
        string EmailAddress { get; set; }
    }
}
