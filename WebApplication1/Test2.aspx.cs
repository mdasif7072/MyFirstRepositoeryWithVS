using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Test2 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("server=LAPTOP-JAVN62S4\\SQLEXPRESS;database=mydb;uid=sa;password=asif123;");

        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = Session["name"].ToString();
            string str = "sp_Procedures 'Get'";
            SqlDataAdapter sda = new SqlDataAdapter(str,conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            grid.DataSource = dt;
            grid.DataBind();
        }
    }
}