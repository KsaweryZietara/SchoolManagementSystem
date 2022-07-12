using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary.CommonModels {

    /// <summary>
    /// Represents message.
    /// </summary>
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

        /// <summary>
        /// Initializes a new instance of the MessageModel class.
        /// </summary>
        /// <param name="senderEmailAddress">Email address of the sender.</param>
        /// <param name="receiverEmailAddress">Email address of the receiver.</param>
        /// <param name="date">Date of the message sending.</param>
        /// <param name="title">Title of the message</param>
        /// <param name="content">Content of the message.</param>
        public MessageModel(string senderEmailAddress, string receiverEmailAddress, DateTime date, string title, string content) {
            SenderEmailAddress = senderEmailAddress;
            ReceiverEmailAddress = receiverEmailAddress;
            Date = date;
            Title = title;
            Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the MessageModel class.
        /// </summary>
        /// <param name="senderEmailAddress">Email address of the sender.</param>
        /// <param name="receiverEmailAddress">Email address of the receiver.</param>
        /// <param name="title">Title of the message</param>
        /// <param name="content">Content of the message.</param>
        public MessageModel(string senderEmailAddress, string receiverEmailAddress, string title, string content) {
            SenderEmailAddress = senderEmailAddress;
            ReceiverEmailAddress = receiverEmailAddress;
            Title = title;
            Content = content;

            Date = DateTime.Now;
        }
    }
}
