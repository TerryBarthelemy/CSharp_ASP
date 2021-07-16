using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Control_SearchMGR : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
        {

        }
        else
        {
            Response.Redirect("default.aspx");
        }
    }

    protected void searchPeople_Click(object sender, EventArgs e)
    {
        PersonV2 temp = new PersonV2();
        DataSet ds = temp.SearchPersons(firstnameTXT.Text, lastnameTXT.Text);

        dgvPersons.DataSource = ds;
        dgvPersons.DataMember = ds.Tables[0].TableName;
        dgvPersons.DataBind();
    }

    protected void dgvPersons_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}