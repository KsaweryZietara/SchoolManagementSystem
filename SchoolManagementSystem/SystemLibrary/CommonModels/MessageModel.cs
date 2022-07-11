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
        public string SenderEmailAddress { get; set; }

        /// <summary>
        /// Represents email address of the receiver.
        /// </summary>
        public string ReceiverEmailAddress { get; set; }

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

        public MessageModel(string senderEmailAddress, string receiverEmailAddress, string title, string content) {
            SenderEmailAddress = senderEmailAddress;
            ReceiverEmailAddress = receiverEmailAddress;
            Title = title;
            Content = content;

            Date = DateTime.Now;
        }
    }
}
