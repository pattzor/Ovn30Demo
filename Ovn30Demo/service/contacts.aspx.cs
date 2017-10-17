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
                jsonLiteral.Text = JsonConvert.SerializeObject(SQLStuff.ReadAllContacts(), Formatting.Indented);
            }
            else if(Request["deleteCID"] != null)
            {
                int cid = int.Parse(Request["deleteCID"].ToString());

                int result = SQLStuff.DeleteContact(cid);

                if(result == 0)
                {
                    jsonLiteral.Text = "error";
                }
                else
                {
                    jsonLiteral.Text = "ok";
                }
            }

        }
    }
}