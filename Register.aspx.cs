using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace college_work
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection conn;
        string strcon;
        protected void fnConnection()
        {
            strcon = ConfigurationManager.ConnectionStrings["Mydatabase"].ConnectionString;
            conn = new SqlConnection(strcon);
            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
                Response.Write("Connection Successed");
            }
            else
            {
                Response.Write("not connection");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            fnConnection();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strcon);
            string query = "select * from user_register where username = @user and password = @pass";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@user", txtName.Text);
            cmd.Parameters.AddWithValue("@pass", txtPass.Text);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if(dataReader.HasRows)
            {  
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<scripst>alert('login successful !')</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('login faild !')</script>");
            }
            conn.Close();
        }
    }
}