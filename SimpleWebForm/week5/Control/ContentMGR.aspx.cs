using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ContentMGR : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
        {
            login_success.Text = "";
        }
        else
        {
            Response.Redirect("/Control/Default.aspx");
        }

        updatePerson.Visible = false;
        deletePerson.Visible = false;

        string strPer_ID = "";
        int intPer_ID = 0;

        if ((!IsPostBack) && Request.QueryString["Per_ID"] != null)
        {
            strPer_ID = Request.QueryString["Per_ID"].ToString();
            lblPerson_ID.Text = strPer_ID;

            intPer_ID = Convert.ToInt32(strPer_ID);

            PersonV2 temp = new PersonV2();
            SqlDataReader dr = temp.FindOnePerson(intPer_ID);

            while (dr.Read())
            {
                txtfirst.Text = dr["FName"].ToString();
                txtmiddle.Text = dr["MName"].ToString();
                txtlast.Text = dr["LName"].ToString();
                txtaddress.Text = dr["StreetOne"].ToString();
                txtcity.Text = dr["City"].ToString();
                txtstate.Text = dr["State"].ToString();
                txtzip.Text = dr["ZipCode"].ToString();
                txtcellphone.Text = dr["Cellphone"].ToString();
                txtemail.Text = dr["Email"].ToString();
                
            }

            updatePerson.Visible = true;
            deletePerson.Visible = true;
			searchPerson.Visible = true;
			btnSubmit.Visible = false;

        }
        else
        {

        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        PersonV2 temp = new PersonV2();

        temp.FName = txtfirst.Text;
        temp.MName = txtmiddle.Text;
        temp.LName = txtlast.Text;
        temp.StreetOne = txtaddress.Text;
        temp.City = txtcity.Text;
        temp.State = txtstate.Text;
		temp.ZipCode = txtzip.Text;
        temp.Email = txtemail.Text;
        temp.Cellphone = txtcellphone.Text;

        if(!temp.Feedback.Contains("ERROR"))
        {
            temp.AddARecord();
            lblResults.Text = "First Name: " + txtfirst.Text + "\nMiddle Name: " + txtmiddle.Text + "\nLast Name: " + txtlast.Text + "\nStreet/Address: " + txtaddress.Text + "\nCity: " + txtcity.Text + "\nZip Code: " + txtzip.Text + "\nZip State: " + txtstate.Text + "\nEmail: " + txtemail.Text;
        }
        else
        {
            lblResults.Text = temp.Feedback;
        }
    }

    protected void logoutBTN_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("/Control/default.aspx");
    }

    protected void updatePerson_Click(object sender, EventArgs e)
    {
		PersonV2 temp = new PersonV2();
		lblFeedback.Text = "";

		temp.FName = txtfirst.Text;
		temp.MName = txtmiddle.Text;
		temp.LName = txtlast.Text;
		temp.StreetOne = txtaddress.Text;
		temp.City = txtcity.Text;
		temp.State = txtstate.Text;
		temp.ZipCode = txtzip.Text;
		temp.Email = txtemail.Text;
		temp.Cellphone = txtcellphone.Text;

		temp.PeopleID = Convert.ToInt32(lblPerson_ID.Text);

		int intPersonID;
		bool blnResult = Int32.TryParse(lblPerson_ID.Text, out intPersonID);
		if (blnResult == false)
		{
			lblFeedback.Text += "Error: Invalid Person ID";
		}
		else
		{
			temp.PeopleID = intPersonID;
		}

		if (!temp.Feedback.Contains("ERROR:"))
		{
			lblFeedback.Visible = true;
			lblFeedback.Text = temp.UpdateAPerson();
		}
		else
		{
			lblFeedback.Visible = true;
			lblFeedback.Text += temp.Feedback;
		}
	}

    protected void deletePerson_Click(object sender, EventArgs e)
    {
		Int32 intPersonID = Convert.ToInt32(lblPerson_ID.Text);
		PersonV2 temp = new PersonV2();
		lblFeedback.Visible = true;
		lblFeedback.Text = temp.DeleteOnePerson(intPersonID);
	}

	protected void searchPerson_Click(object sender, EventArgs e)
	{
		Response.Redirect("/Control/SearchMGR.aspx");
	}
}