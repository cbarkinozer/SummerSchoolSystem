using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entity; //CS0246

namespace DataAccessLayer
{
    public class StudentDal
    {
        public static int AddStudent(Entity entity)
        {
            SqlCommand command1 = new SqlCommand("insert into TblStudent (StudentName,StudentSurname,StudentNumber,StudentMail,StudentPassword,StudentBalance)"
                + "values (@p1,@p2,@p3,@p4,@p5)", Connection.con);
            if (command1.Connection.State != ConnectionState.Open)
            {
                command1.Connection.Open();
            }
            command1.Parameters.AddWithValue("@p1", entity.StdName);
            command1.Parameters.AddWithValue("@p2", entity.StdSurname);
            command1.Parameters.AddWithValue("@p3", entity.StdNumber);
            command1.Parameters.AddWithValue("@p4", entity.StdMail);
            command1.Parameters.AddWithValue("@p4", entity.StdPassword);
            command1.Parameters.AddWithValue("@p5", entity.StdBalance);
            return command1.ExecuteNonQuery();
        }
        public static List<EntityStudent> StudentList()
        {
            List<EntityStudent> values = new List<EntityStudent>();
            SqlCommand command2 = new SqlCommand("Select * From TblStudent", Connection.con);
            if (command2.Connection.State != ConnectionState.Open)
            {
                command2.Connection.Open();
            }
            SqlDataReader dataReader = command2.ExecuteReader();
            while (dataReader.Read())
            {
                EntityStudent entityStudent = new EntityStudent();
                entityStudent.StudentId = Convert.ToInt32(dataReader["StudentId"].ToString());
                entityStudent.StudentName = dataReader["StdName"].ToString();
                entityStudent.StudentSurName = dataReader["StdSurname"].ToString();
                entityStudent.StudentNumber = dataReader["StdNumber"].ToString();
                entityStudent.StudentMail = dataReader["StdMail"].ToString();
                entityStudent.StudentPassword = dataReader["StdPassword"].ToString();
                entityStudent.StudentBalance = Convert.ToDouble(dataReader["StdBalance"].ToString());
                values.Add(entityStudent);
            }
            dataReader.Close();
            return values;
        }
        public static bool DeleteStudent(int parameter) 
        {
            SqlCommand command3 = new SqlCommand("Delete From TblStudent where StudentId=@P1", Connection.con);
            if (command3.Connection.State != ConnectionState.Open)
            {
                command3.Connection.Open();
            }
            command3.Parameters.AddWithValue("@P1",parameter);
            return command3.ExecuteNonQuery() > 0 ;
        }
    }
}

