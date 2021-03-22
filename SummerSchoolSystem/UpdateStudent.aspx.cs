using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity; //CS0246
using DataAccessLayer;
using BussinessLogic;

namespace SummerSchoolSystem
{
    public partial class UpdateStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(Request.QueryString["StdId"].ToString());
            TxtId.Text = value.ToString();
            TxtId.Enabled = false;
            //Protect the values that cached when the page is loaded
            if (Page.IsPostBack == false) 
            {
                List<EntityStudent> StdList = StudentBLL.DetailBLL(id);
                TxtName.Text = StdList[0].Name.ToString();
                TxtSurname.Text = StdList[0].Surname.ToString();
                TxtNumber.Text = StdList[0].Number.ToString();
                TxtMail.Text = StdList[0].Mail.ToString();
                TxtPassword.Text = StdList[0].Password.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityStudent entityStudent = new EntityStudent();
            entityStudent.StdName = TxtName.Text;
            entityStudent.StdSurame = TxtSurname.Text;
            entityStudent.StPassword = TxtPassword.Text;
            entityStudent.StdNumber = TxtNumber.Text;
            entityStudent.StdMail = TxtMail.Text;
            StudentBLL.UpdateStudentBll(entityStudent);
            Response.Redirect("StudentList.Aspx");
        }
    }
}