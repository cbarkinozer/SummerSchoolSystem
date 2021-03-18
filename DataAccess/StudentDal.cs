using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entity;

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

    }
}

