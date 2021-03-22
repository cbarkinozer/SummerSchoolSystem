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

        public static List<EntityStudent> StudentDetail(int id)
        {
            List<EntityStudent> values = new List<EntityStudent>();
            SqlCommand command4 = new SqlCommand("Select * From TblStudent Where StdId=@P1", Connection.con);
            command4.Parameters.AddWithValue("@P1", id);
            if (command4.Connection.State != ConnectionState.Open)
            {
                command4.Connection.Open();
            }
            SqlDataReader dataReader = command4.ExecuteReader();
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

        public static bool UpdateStudent(EntityStudent entityStudent) 
        {
            SqlCommand command5 = new SqlCommand("Update TblStudent Set StdName=@P1,StdSurname=@P2,StdNumber=@P3,StdPassword=@P4,StdMail=@P5",Connection.con);
            if (command5.Connection.State != ConnectionState.Open)
            {
                command5.Connection.Open();
            }
            command5.Parameters.AddWithValue("@P1", entityStudent.Name);
            command5.Parameters.AddWithValue("@P2", entityStudent.Surname);
            command5.Parameters.AddWithValue("@P3", entityStudent.Number);
            command5.Parameters.AddWithValue("@P4", entityStudent.Mail);
            command5.Parameters.AddWithValue("@P5", entityStudent.Password);
            return command5.ExecuteNonQuery() > 0;
        }
    }
}

