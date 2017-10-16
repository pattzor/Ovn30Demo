using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SqlLibrary;
using Newtonsoft.Json;

namespace Ovn30Demo.service
{
    public partial class contacts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request["all"] != null)
            {
                SQLStuff sqlStuff = new SQLStuff();

                jsonLiteral.Text = JsonConvert.SerializeObject(sqlStuff.ReadAllContacts(), Formatting.Indented);
            }
        }
    }
}