using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Versaler.Model;

namespace Versaler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Clear.Visible = false;
        }

        protected void SendClick(object sender, EventArgs e)
        {
            Outmessage.Text = "Textarea innehåller "+ Input.Text.GetNumberOfCapitals().ToString()+ " versaler";
            Input.Enabled = false;
            Check.Visible = false;
            Clear.Visible = true;

  
        }

        protected void ClearClick(object sender, EventArgs e)
        {
            Input.Text = "";
            Input.Enabled = true;
            Check.Visible = true;
            Outmessage.Text = "";
        }
    }
}