using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace DataAccess
{
   public  class LessonDal
    {
        public static List<EntityLesson> LessonList()
        {
            List<EntityLesson> values = new List<EntityLesson>();
            SqlCommand command1 = new SqlCommand("Select * From TblLesson", Connection.con);
            if (command1.Connection.State != ConnectionState.Open)
            {
                command1.Connection.Open();
            }
            SqlDataReader dataReader = command1.ExecuteReader();
            while (dataReader.Read())
            {
                EntityLesson entityLesson = new EntityLesson();
                entityLesson.LessonId = Convert.ToInt32(dataReader["LessonId"].ToString());
                entityLesson.LessonName = dataReader["LessonName"].ToString();
                entityLesson.LessonQuota = int.Parse(dataReader["LessonQuota"].ToString();); 
                
                values.Add(entityLesson);
            }
            dataReader.Close();
            return values;
        }
        public static int AddApply(EntityApplyForm entityApplyForm) 
        {
            SqlCommand command = new SqlCommand("INSERT INTO TblApplyForm (StudentId,LessonId) VALUES(@P1,@P2)",Connection.con);
            command.Parameters.AddWithValue("@P1",entityApplyForm.StudentId);
            command.Parameters.AddWithValue("@P2", entityApplyForm.LessonId);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            return command.ExecuteNonQuery();
        }
    }
}
