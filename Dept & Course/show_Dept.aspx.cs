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
            SqlConnection conn = new SqlConnection(strconn);
            string query = "select * from Tbl_dept";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query,conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            gvDataDept.DataSource = ds;
            gvDataDept.DataBind();
            conn.Close();
        }
        protected void BindGridViewCourse() 
        {
            SqlConnection conn = new SqlConnection(strconn);
            string query = "select * from Tbl_course";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query,conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            gvDataCourse.DataSource = ds;
            gvDataCourse.DataBind();
            conn.Close();
        }

        protected void BindDDL() 
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string query = "select * from Tbl_dept";
            SqlDataAdapter adpt = new SqlDataAdapter(query,conn);
            DataTable dataTable = new DataTable();
            adpt.Fill(dataTable);
            ddlDept.DataSource = dataTable;
            ddlDept.DataBind();
            ddlDept.DataTextField = "dept_name";
            ddlDept.DataTextField = "dept_id";
            ddlDept.DataBind();
            conn.Close();

        }
        protected void ddlDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Tbl_course where dept_id = @deptID",conn);
            cmd.Parameters.AddWithValue("deptID", ddlDept.SelectedValue);
            ddlCourse.DataSource = cmd.ExecuteReader();
            ddlCourse.DataTextField = "course_name";
            ddlCourse.DataTextField = "course_id";
            ddlCourse.DataBind();
        }

    }
}