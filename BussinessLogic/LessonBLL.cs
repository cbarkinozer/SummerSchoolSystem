using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;
namespace BussinessLogic
{
   public class LessonBLL
    {
        public static List<EntityLesson> ListBll() 
        {
            return LessonDal.LessonList();
        }
        public static int AddApplyBll(EntityApplyForm entityApplyForm) 
        {
            if (entityApplyForm.StudentId ! = null && entityApplyForm.LessonId ! = null) 
            {
                return LessonDal.AddApply(entityApplyForm);
            }
            return -1;
        }
    }
}
