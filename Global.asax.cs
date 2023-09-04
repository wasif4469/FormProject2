using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace FormProject2
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

            RouteTable.Routes.MapPageRoute("Default", "LoginPage.aspx", "~/LoginPage.aspx");
            RouteTable.Routes.MapPageRoute("web", "form/{id}", "~/WebForm.aspx");
            RouteTable.Routes.MapPageRoute("web2", "form2/{id}", "~/form2.aspx");
            RouteTable.Routes.MapPageRoute("web3", "form3/{id}", "~/WebForm3.aspx");

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}