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
        protected void fnConnection()
        {
            string strcon = ConfigurationManager.ConnectionStrings["Mydatabase"].ConnectionString;
            conn = new SqlConnection(strcon);
            if (conn.State != ConnectionState.Open)
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
            string id = txtId.Text;
            string pass = txtPass.Text;

            lblDetails.Text = "<br> id : " + id + "<br> password :" + pass;
        }
    }
}