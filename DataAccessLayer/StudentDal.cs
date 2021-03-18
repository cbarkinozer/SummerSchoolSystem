using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAccessLayer
{
    public class StudentDal
    {
        public static int AddStudent(EntityLayer entityLayer)
        {
            SqlCommand command1 = new SqlCommand("insert into TblStudent (StudentName,StudentSurname,StudentNumber,StudentMail,StudentPassword,StudentBalance)"
                + "values (@p1,@p2,@p3,@p4,@p5)", Connection.con);
            if (command1.Connection.State != ConnectionState.Open)
            {
                command1.Connection.Open();
            }
            command1.Parameters.AddWithValue("@p1", entityLayer.StdName);
            command1.Parameters.AddWithValue("@p2", entityLayer.StdSurname);
            command1.Parameters.AddWithValue("@p3", entityLayer.StdNumber);
            command1.Parameters.AddWithValue("@p4", entityLayer.StdMail);
            command1.Parameters.AddWithValue("@p4", entityLayer.StdPassword);
            command1.Parameters.AddWithValue("@p5", entityLayer.StdBalance);
            return command1.ExecuteNonQuery();
        }
        
    }
}
