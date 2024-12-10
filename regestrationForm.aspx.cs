using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace college_work
{
    public partial class regestrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text; 
            lblDetails.Text += "<br> name: " + name;
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }

       
    }
}