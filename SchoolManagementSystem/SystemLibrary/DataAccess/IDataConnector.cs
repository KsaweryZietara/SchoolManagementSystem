using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLibrary.AdminAccountModels;
using SystemLibrary.StudentAccountModels;
using SystemLibrary.TeacherAccountModels;

namespace SystemLibrary.DataAccess {
    public interface IDataConnector {
        void AddStudent(StudentModelSA studentModel);

        void AddTeacher(TeacherModelTA teacherModel);

        void AddAdmin(AdminModel adminModel);
    }
}
