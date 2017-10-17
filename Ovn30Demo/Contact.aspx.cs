using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SqlLibrary;

namespace Ovn30Demo
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["cid"] != null)
            {
                int cid = int.Parse(Request["cid"]);

                SqlLibrary.Contact contact = SQLStuff.ReadAllContacts().FirstOrDefault(x => x.ID == cid);

                if (contact != null)
                {
                    TextBoxFirstname.Text = contact.Firstname;
                    TextBoxLastname.Text = contact.Lastname;
                    TextBoxSSN.Text = contact.SSN;
                }
            }

            if (Request["action"] != null)
            {
                string action = Request["action"];

                if (action == "update")
                {
                    ButtonContact.Text = "Update contact";
                }
                else if (action == "delete")
                {
                    TextBoxFirstname.Enabled = false;
                    TextBoxLastname.Enabled = false;
                    TextBoxSSN.Enabled = false;

                    ButtonContact.Text = "Delete contact";
                }
            }
        }

        protected void ButtonContact_Click(object sender, EventArgs e)
        {
           
        }
    }
}