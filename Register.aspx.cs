using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace college_work
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string pass = txtPass.Text;

            lblDetails.Text = "<br> id : " + id + "<br> password :" + pass;
        }
    }
}