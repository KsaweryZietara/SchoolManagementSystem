using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary.CommonModels {
    public class MessageModel {

        /// <summary>
        /// Represents email address of the sender.
        /// </summary>
        public int SenderEmailAddress { get; set; }

        /// <summary>
        /// Represents email address of the receiver.
        /// </summary>
        public int ReceiverEmailAddress { get; set; }

        /// <summary>
        /// Represents date of the message sending.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Represents title of the message.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Represents content of the message.
        /// </summary>
        public string Content { get; set; }
    }
}
