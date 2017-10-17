using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SqlLibrary;

namespace Ovn30Demo
{
    public partial class index_new : System.Web.UI.Page
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

            foreach (var contact in myContacts)
            {
                TableRow tableRow = new TableRow();

                TableCell cellID = new TableCell();
                cellID.Text = contact.ID.ToString();
                tableRow.Cells.Add(cellID);

                TableCell cellFirstname = new TableCell();
                cellFirstname.Text = contact.Firstname;
                tableRow.Cells.Add(cellFirstname);

                TableCell cellLastname = new TableCell();
                cellLastname.Text = contact.Lastname;
                tableRow.Cells.Add(cellLastname);

                TableCell cellSSN = new TableCell();
                cellSSN.Text = contact.SSN;
                tableRow.Cells.Add(cellSSN);

                // Some edit/create/delete stuff

                TableCell cellInfo = new TableCell();

                string cellInfoHTML = "";
                cellInfoHTML += "<a href=\"/contact.aspx?action=update&cid=" + contact.ID + "\" class=\"btn btn-success btn-sm\">";
                cellInfoHTML += "<span class=\"glyphicon glyphicon-pencil\">&nbsp;Update</span>";
                cellInfoHTML += "</a>";
                cellInfoHTML += "&nbsp;";

                cellInfoHTML += "<a href=\"/contact.aspx?action=delete&cid=" + contact.ID + "\" class=\"btn btn-danger btn-sm\">";
                cellInfoHTML += "<span class=\"glyphicon glyphicon-remove\">&nbsp;Delete</span>";
                cellInfoHTML += "</a>";
                cellInfoHTML += "&nbsp;";

                cellInfo.Text = cellInfoHTML;
                tableRow.Cells.Add(cellInfo);

                TableContacts.Rows.Add(tableRow);

                ListItem myItem = new ListItem($"{contact.Firstname} {contact.Lastname}", contact.ID.ToString());
            }
        }
    }
}