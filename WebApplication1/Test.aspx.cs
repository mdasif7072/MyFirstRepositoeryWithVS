using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Test : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("server=LAPTOP-JAVN62S4\\SQLEXPRESS;database=mydb;uid=sa;password=asif123;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "sp_Procedures 'Insert','" + txtName.Text + "','" + txtCity.Text + "','"+txtSalary.Text+"'";

                SqlCommand cmd = new SqlCommand(str, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
               
                Session["name"] = "Welcome To "+ txtName.Text;
                Response.Redirect("Test2.aspx");
            }
            catch { }
        }

        protected void btnViewData_Click(object sender, EventArgs e)
        {
            Response.Redirect("Test2.aspx");
        }
    }
}