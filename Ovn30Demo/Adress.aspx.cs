using SqlLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ovn30Demo
{
    public partial class Adress : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadContacts();
            }
        }

        private void LoadContacts()
        {
            List<SqlLibrary.Contact> myContacts = SQLStuff.ReadAllContacts();

            dropDownListContacts.Items.Clear();

            foreach (var contact in myContacts)
            {
                ListItem myItem = new ListItem($"{contact.Firstname} {contact.Lastname}", contact.ID.ToString());
                dropDownListContacts.Items.Add(myItem);
            }
        }

        protected void ButtonAddAddress_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                string type = textBoxType.Text;
                string street = textBoxStreet.Text;
                string city = textBoxCity.Text;

                int cid = int.Parse(dropDownListContacts.SelectedValue);

                SQLStuff.AddAddressToContact(cid, new SqlLibrary.Adress(type, street, city));
            }
        }
    }
}