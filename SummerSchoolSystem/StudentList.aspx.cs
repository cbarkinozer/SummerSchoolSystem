using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;//CS0246
using DataAccessLayer; //Suppose to be DataAccess
using BussinessLogic;

namespace SummerSchoolSystem
{
    public partial class StudentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityStudent> StdList = StudentBLL.ListBll();
            Repeater1.DataSource = StdList;
            Repeater1.DataBind();
        }
    }
}