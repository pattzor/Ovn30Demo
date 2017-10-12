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
                LoadContacts();
            }
        }

        private void LoadContacts()
        {
            SQLStuff sqlStuff = new SQLStuff();

            List<Contact> myContacts = sqlStuff.ReadAllContacts();

            listBoxContacts.Items.Clear();

            foreach (var contact in myContacts)
            {
                ListItem myItem = new ListItem($"{contact.Firstname} {contact.Lastname}", contact.ID.ToString());
                listBoxContacts.Items.Add(myItem);
            }
        }

        protected void ButtonAddContact_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstname.Text;
            string lastName = textBoxLastname.Text;
            string ssn = textBoxSSN.Text;

            SQLStuff sqlStuff = new SQLStuff();

            try
            {
                sqlStuff.CreateContact(new Contact(firstName, lastName, ssn));

                LoadContacts();
            }
            catch (Exception ex)
            {
                // Sparas till fil
                // TODO
            }
            
        }
    }
}