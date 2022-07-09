using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLibrary.StudentAccountModels;

namespace SystemLibrary.DataAccess {
    public interface IDataConnector {
        void AddStudent(StudentModel studentModel);
    }
}
