using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ovn30Demo
{
    public partial class main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request["logout"] != null)
            {
                Session["username"] = null;
            }

            if (Session["username"] == null)
                Response.Redirect("/login.aspx");
            else
            {
                HyperLinkAccount.Text = "<span class=\"glyphicon glyphicon-user\">&nbsp;" + Session["username"] + "</span>";
                HyperLinkAccount.ToolTip = "Logged in as " + Session["username"];
                HyperLinkAccount.NavigateUrl = "#";
            }
        }
    }
}