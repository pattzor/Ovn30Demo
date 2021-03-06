﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SqlLibrary;

namespace Ovn30Demo
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if(IsValid)
            {
                string username = TextBoxUsername.Text;
                string password = TextBoxPassword.Text;

                User user = SQLStuff.ValidateLogin(username, password);

                if (user != null)
                {
                    Session["user"] = user;
                    Response.Redirect("/index.aspx");
                }
                else
                    LabelInfo.Text = "Wrong username/password! (Try Academy/Password1 :)";
            }
        }
    }
}