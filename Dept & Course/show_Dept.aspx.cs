using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace college_work.Dept___Course
{
    public partial class show_Dept : System.Web.UI.Page
    {
        SqlConnection conn;
        string strconn;

        protected void fnConnection() {
            strconn = ConfigurationManager.ConnectionStrings["Mydatabase"].ConnectionString;
            conn = new SqlConnection(strconn);
            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
                Response.Write("succesful");
            }
            else {
                Response.Write("fail");

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            fnConnection();
            if(!Page.IsPostBack)
            {
                this.BindGridViewDept();
                this.BindGridViewCourse();
                this.BindDDL();
            }
        }

        protected void BindGridViewDept() 
        {
            SqlConnection con = new SqlConnection(strconn);
            string query = "select * from Tbl_dept";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            gvDataDept.DataSource = ds;
            gvDataDept.DataBind();
            con.Close();
        }
        protected void BindGridViewCourse() 
        {
            SqlConnection con = new SqlConnection(strconn);
            string query = "select * from Tbl_course";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            gvDataCourse.DataSource = ds;
            gvDataCourse.DataBind();
            con.Close();
        }

        protected void BindDDL() 
        {
            SqlConnection con = new SqlConnection(strconn);
            con.Open();
            string query = "select * from Tbl_dept";
            SqlDataAdapter adpt = new SqlDataAdapter(query,con);
            DataTable dataTable = new DataTable();
            adpt.Fill(dataTable);
            ddlDept.DataSource = dataTable;
            ddlDept.DataBind();
            ddlDept.DataTextField = "dept_name";
            ddlDept.DataTextField = "dept_id";
            ddlDept.DataBind();
            con.Close();

        }
        protected void ddlDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strconn);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Tbl_course where dept_id = @deptID",con);
            cmd.Parameters.AddWithValue("deptID", ddlDept.SelectedValue);
            ddlCourse.DataSource = cmd.ExecuteReader();
            ddlCourse.DataTextField = "course_name";
            ddlCourse.DataTextField = "course_id";
            ddlCourse.DataBind();
        }

    }
}