using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Control_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Username"] = "Scott";
    }


    protected void loginBTN_Click(object sender, EventArgs e)
    {
        if (user_name_txt.Text == "Scott" && pwd_txt.Text == "NEIT")
        {
            Session["LoggedIn"] = "TRUE";
            Response.Redirect("Controls.aspx");
        }
        else
        {
            lblfeedback.Text = "\nOuch! Sorry Buck-O Try Again.";
            Session.Abandon();
        }
    }
}