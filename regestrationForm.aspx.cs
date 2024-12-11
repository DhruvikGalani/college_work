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
            try
            {
                string name = txtName.Text;
                string gender = rblGender.SelectedValue;
                string dob = txtDob.Text;
                string social = string.Empty;
                string city = ddlCity.SelectedValue;
                string address = txtAddress.Text;

                for (int i = 0; i < cblSocialMedia.Items.Count; i++)
                {
                    if (cblSocialMedia.Items[i].Selected)
                    {
                        social += cblSocialMedia.Items[i].Value + ", ";
                    }
                }

                lblDetails.Text += "<br> name: " + name +
                    "</br> gender : " + gender +
                    "</br> DOB : " + dob +
                    "</br> socail media : " + social +
                    "</br> city : " + city +
                    "</br> Address : " + address;
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
           txtName.Text = "";
      
           txtDob.Text = "";        
           ddlCity.SelectedValue = "";
           txtAddress.Text = "";
        }

       
    }
}