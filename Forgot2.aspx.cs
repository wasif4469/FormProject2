using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormProject2
{
    public partial class Forgot2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string errorMessage = "Please contact System Administrator for Changing possword!.";
            string script = $"alert('{errorMessage}');";
            ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
           
        }
    }
}