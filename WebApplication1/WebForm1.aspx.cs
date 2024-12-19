using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.Script.Serialization;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("server=LAPTOP-JAVN62S4\\SQLEXPRESS;database=student;uid=sa;password=asif123;");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.RequestType.ToUpper() == "POST")
                {
                    Create();
                }
                else if(Request.RequestType.ToUpper()=="GET")
                {
                    GetData();
                }
            }
        }

        public void Create()
        {
            try
            {

                StreamReader reader = new StreamReader(Request.InputStream);
                
                string jsonData = reader.ReadToEnd();

                 
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                var data = serializer.Deserialize<Dictionary<string,string>>(jsonData);

                    
                 
                string Name = data["Name"] ;
                string Gender = data["Gender"] ;
                string Address = data["Address"];
                string state = data["State"];

                string query = "insert into student1(name,gender,address,state) values('" + Name + "','" + Gender + "','" + Address + "','" + state + "')";
                SqlCommand cmd = new SqlCommand(query,conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                Response.Write("Success");
                
            }
            catch (Exception ex)
            {
               
                Response.Write("Error: " + ex.Message);
            }

        }
        public void GetData()
        {
            string query="Select * from student1";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            string jsonResponse = JsonConvert.SerializeObject(dt);
               
            Response.Write(jsonResponse);
        }
    }

     
}