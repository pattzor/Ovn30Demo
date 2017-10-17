using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SqlLibrary;

namespace Ovn30Demo
{
    public partial class main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["logout"] != null)
            {
                Session["user"] = null;
            }

            if (Session["user"] == null)
            {
                Response.Redirect("/login.aspx");
            }
            else
            {
                User user = (User)Session["user"];

                HyperLinkAccount.Text = "<span class=\"glyphicon glyphicon-user\">&nbsp;" + user.Username + "</span>";
                HyperLinkAccount.ToolTip = "Logged in as " + user.Username;
                HyperLinkAccount.NavigateUrl = "#";
            }
        }
    }
}