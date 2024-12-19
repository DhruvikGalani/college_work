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
            if (!Page.IsPostBack)
            {
                fnbindstate();
            }
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            lblDetails.Text = "";
            try
            {
                string name = txtName.Text;
                string gender = rblGender.SelectedValue;
                string dob = txtDob.Text;
                string social = string.Empty;
                string state = ddlState.SelectedValue;
                string city = ddlCity.SelectedValue;
                string address = txtAddress.Text;

                for (int i = 0; i < cblSocialMedia.Items.Count; i++)
                {
                    if (cblSocialMedia.Items[i].Selected)
                    {
                        social += cblSocialMedia.Items[i].Value + ", ";
                    }
                }

                lblDetails.Text = "<br> name: " + name +
                    "</br> gender : " + gender +
                    "</br> DOB : " + dob +
                    "</br> socail media : " + social +
                    "</br> state : " + state +
                    "</br> city : " + city +
                    "</br> Address : " + address;
            }
            catch (Exception SaveError)
            {
                Response.Write(SaveError.ToString());
                throw;
            }

            txtName.Text = "";
            rblGender.ClearSelection();
            txtDob.Text = "";
            ddlState.ClearSelection();
            ddlCity.ClearSelection();
            cblSocialMedia.ClearSelection();
            txtAddress.Text = "";

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

           txtName.Text = "";
           rblGender.ClearSelection();
           txtDob.Text = "";
            ddlState.ClearSelection();
            ddlCity.ClearSelection();
           cblSocialMedia.ClearSelection();
           txtAddress.Text = "";
            lblDetails.Text = "";

        }

        protected void fnbindstate()
        {
            ddlState.Items.Add("gujrat");
            ddlState.Items.Add("maharastra");
            ddlState.Items.Insert(0, new ListItem("---Select State---"));
        }      

        protected void fnbindcity()
        {
            ddlCity.Items.Clear();
            if (ddlState.SelectedValue=="gujrat")
            {
                ddlCity.Items.Add("surat");
                ddlCity.Items.Add("vapi");
                ddlCity.Items.Add("rajkot");
            }
            else if (ddlState.SelectedValue == "maharastra")
            {
                ddlCity.Items.Add("thane");
                ddlCity.Items.Add("mumbai");
                ddlCity.Items.Add("pune");
            }
            ddlCity.Items.Insert(0, new ListItem("---select city---"));
        }

        protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            fnbindcity();
        }
    }
}