using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using BussinessLogic;
using DataAccess;


namespace SummerSchoolSystem
{
    public partial class Lessons : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false) 
            {
                List<EntityLesson> entityLessons = LessonBLL.ListBll();
                DropDownList1.DataSource = LessonBLL.ListBll();
                DropDownList1.DataValueField = "LessonId";
                DropDownList1.DataBind();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //TextBox1.Text = DropDownList1.SelectedValue.ToString();
            EntityApplyForm entityApplyForm = new EntityApplyForm();
            entityApplyForm.StudentId = int.Parse(TextBox1.Text);
            entityApplyForm.LessonId = int.Parse(DropDownList1.SelectedValue.ToString());
            LessonBLL.AddApplyBll(entityApplyForm);
        }
    }
}