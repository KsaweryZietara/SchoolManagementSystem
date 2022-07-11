﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLibrary.CommonModels;

namespace SystemLibrary.TeacherAccountModels {
    public class TeacherModelTA : UserModel {

        /// <summary>
        /// Represents first name of the teacher. 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents last name of the teacher.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents email address of the teacher.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents password of the teacher.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Represents messages of teacher.
        /// </summary>
        public List<MessageModel> Messages { get; set; } = new List<MessageModel>();

        /// <summary>
        /// Represents courses which teacher lead.
        /// </summary>
        public List<CourseModelTA> Courses { get; set; } = new List<CourseModelTA>();

        public TeacherModelTA() {
        }

        public TeacherModelTA(string firstName, string lastName, string emailAddress, string password) {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Password = password;
        }
    }
}
