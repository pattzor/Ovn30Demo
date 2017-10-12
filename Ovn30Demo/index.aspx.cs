using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SqlLibrary;

namespace Ovn30Demo
{
    public partial class index : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //listBoxContacts.Items.Add("This is a POstBack");
            }
            else
            {
                SQLStuff sqlStuff = new SQLStuff();

                List<Contact> myContacts = sqlStuff.ReadAllContacts();

                foreach (var contact in myContacts)
                {
                    listBoxContacts.Items.Add($"{contact.Firstname} {contact.Lastname}");
                }
            }
        }
    }
}