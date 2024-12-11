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
            string gender = rblGender.SelectedValue;
            string dob = txtDob.Text;
            string city = ddlCity.SelectedValue;
            string address = txtAddress.Text;
            string smedia = cblSocialMedia.SelectedValue;

            for (int i = 0; i < cblSocialMedia.Items.Count; i++)
            {
                if (cblSocialMedia.Items[i].Selected)
                {
                    smedia = cblSocialMedia.Items[i].Value; 
                }
            }

            lblDetails.Text += "<br> name: " + name +
                "</br> gender : " + gender + 
                "</br> Dob : " + dob +
                "</br> Social media : " + smedia +
                "</br> city : " + city +
                "</br> Address : " + address;
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            rblGender.Text = string.Empty;
            txtDob.Text = string.Empty;
            cblSocialMedia.SelectedValue = string.Empty;
            ddlCity.SelectedValue = string.Empty;
            txtAddress.Text = string.Empty;
        }

       
    }
}