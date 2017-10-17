﻿using System;
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
            if (!IsPostBack)
            {
                LoadContacts();
            }
        }

        private void LoadContacts()
        {
            List<SqlLibrary.Contact> myContacts = SQLStuff.ReadAllContacts();

            listBoxContacts.Items.Clear();

            foreach (var contact in myContacts)
            {
                ListItem myItem = new ListItem($"{contact.Firstname} {contact.Lastname}", contact.ID.ToString());
                listBoxContacts.Items.Add(myItem);
            }
        }

        protected void ButtonAddContact_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                string firstName = textBoxFirstname.Text;
                string lastName = textBoxLastname.Text;
                string ssn = textBoxSSN.Text;

                try
                {
                    SQLStuff.CreateContact(new SqlLibrary.Contact(firstName, lastName, ssn));

                    textBoxFirstname.Text = "";
                    textBoxLastname.Text = "";
                    textBoxSSN.Text = "";

                    LoadContacts();
                }
                catch (Exception ex)
                {
                    //TODO : Write to logfile
                    throw ex;
                }
            }
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxContacts.SelectedIndex >= 0)
            {
                int id = int.Parse(listBoxContacts.SelectedValue);

                if (id > 0)
                {
                    Response.Redirect("/contact.aspx?action=update&cid=" + id);
                }
            }
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxContacts.SelectedIndex >= 0)
            {
                int id = int.Parse(listBoxContacts.SelectedValue);

                if (id > 0)
                {
                    Response.Redirect("/contact.aspx?action=delete&cid=" + id);
                }
            }
        }

        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            if (listBoxContacts.SelectedIndex >= 0)
            {
                int id = int.Parse(listBoxContacts.SelectedValue);

                if (id > 0)
                {
                    Response.Redirect("/contact.aspx?action=create&cid=" + id);
                }
            }
        }
    }
}