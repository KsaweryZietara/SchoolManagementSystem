using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLibrary.StudentAccountModels;
using MySql.Data.MySqlClient;
using System.Data.Entity;

namespace SystemLibrary.DataAccess {
    public class MySqlConnector : IDataConnector {
        public void AddStudent(StudentModel studentModel) {
            throw new NotImplementedException();
        }
    }
}
