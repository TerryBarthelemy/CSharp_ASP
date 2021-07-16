using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Control_Controls : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
        {
            login_success.Text = "Hello, Welcome to myDASHBOARD " + Session["Username"] + "!";
        }
        else
        {
            Response.Redirect("/Control/Cotrols.aspx");
        }
    }

    protected void addPerson_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Control/ContentMGR.aspx");
    }

    protected void searchPerson_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Control/SearchMGR.aspx");
    }
}