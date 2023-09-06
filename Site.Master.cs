using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FormProject2
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Role = Session["UserRole"]?.ToString();

            // Get the references to the list items using their IDs
            var selfEvaluationItem = FindControl("SelfEvaluationItem") as HtmlGenericControl;
            var activitiesFormItem = FindControl("ActivitiesFormItem") as HtmlGenericControl;
            var knowledgeIndicatorItem = FindControl("KnowledgeIndicatorItem") as HtmlGenericControl;
            var activitiesFormItem2 = FindControl("ActivitiesFormItem2") as HtmlGenericControl;

            if (selfEvaluationItem != null && activitiesFormItem != null && knowledgeIndicatorItem != null && activitiesFormItem2 != null)
            {
                if (Role == "Tech Graduate")
                {
                    // Show all three list items
                    selfEvaluationItem.Visible = true;
                    activitiesFormItem.Visible = true;
                    activitiesFormItem2.Visible = false;
                    knowledgeIndicatorItem.Visible = false;

                }
                else if (Role == "Team Lead" || Role == "Section Head")
                {
                    // Show only Form2 and Form3 list items
                    selfEvaluationItem.Visible = false;
                    activitiesFormItem2.Visible = false;
                    activitiesFormItem.Visible = true;
                    knowledgeIndicatorItem.Visible = true;
                }
                else if (Role == "Group Head")
                {
                    // Hide all list items
                    selfEvaluationItem.Visible = true;
                    activitiesFormItem2.Visible = true;
                    activitiesFormItem.Visible = false;
                    knowledgeIndicatorItem.Visible = true;
                }
                else 
                {
                    selfEvaluationItem.Visible = false;
                    activitiesFormItem.Visible = false;
                    knowledgeIndicatorItem.Visible = false;
                    activitiesFormItem2.Visible = false;
                }
            }

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Clear session
            Session.Clear();
            Session.Abandon();

            // Clear authentication cookies
            HttpCookie cookie = Request.Cookies["FormsAuthenticationCookie"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }

            // Redirect to login page
            Response.Redirect("LoginPage.aspx");

        }
    }
}