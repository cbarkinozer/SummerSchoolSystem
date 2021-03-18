using System;
using EntityLayer;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class BussinessLogicLayer
    {
        public static int AddStudentBLL(EntityStudent entityStudent) 
        {
            if (entityStudent.StudentName!=null && entityStudent.StudentSurname!=null
                && entityStudent.StudentNumber!=null&& entityStudent.StudentPassword!=null
                &&entityStudent.StudentMail!=null)
            {
                return StudentDal.AddStudent(entityStudent);
            }
            return -1;
        }
    }
}
