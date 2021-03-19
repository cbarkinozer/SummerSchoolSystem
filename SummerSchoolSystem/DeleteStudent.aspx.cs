using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using BussinessLogic;
using DataAccessLayer;

//In relational databases you never delete but change it's state to passive.
namespace SummerSchoolSystem
{
    public partial class DeleteStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(Request.QueryString["StudentId"]);
            Response.Write(value);
            EntityStudent entityStudent = new EntityStudent();
            entityStudent.StdId = value;
            StudentBLL.DeleteStudentBLL(entityStudent.StdId);
            Response.Redirect("StudentList.Aspx");
        }
    }
}