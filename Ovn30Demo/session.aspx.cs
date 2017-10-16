using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ovn30Demo
{
    public partial class session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] != null)
            {
                Label1Info.Text = "Logged in as " + Session["user"];
            }
            else
            {
                Label1Info.Text = "Logga in";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;

            if(username == "Kalle" && password == "Kula")
            {
                Session["user"] = "Kalle";

                Label1Info.Text = "Logged in as Kalle";
            }
            else
            {
                Label1Info.Text = "Fel username/password";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Label1Info.Text = "Logga in";
        }
    }
}