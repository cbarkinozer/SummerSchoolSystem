using System;
using System.Collections.Generic;
using EntityLayer; //CS0246
using DataAccessLayer;//Suppose to be DataAccess

namespace BussinessLogic
{
    public class StudentBLL
    {
        public static int AddStudentBLL(EntityStudent entityStudent)
        {
            if (entityStudent.StudentName != null && entityStudent.StudentSurname != null
                && entityStudent.StudentNumber != null && entityStudent.StudentPassword != null
                && entityStudent.StudentMail != null)
            {
                //return StudentDal.AddStudent(entityStudent);
            }
            return -1;

        }
        public List<EntityStudent> ListBll() 
        {
            return StudentDal.StudentList();
        }
        public static bool DeleteStudentBLL(int parameter) 
        {
            if (parameter !=null )
            {
                return StudentDal.DeleteStudent(parameter);
            }
            return false;
        }
    }
}
