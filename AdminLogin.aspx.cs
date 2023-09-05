using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveDirectorySynchronization;
using System.DirectoryServices.AccountManagement;

namespace FormProject2
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string domain = "jubileelife.com";
            string usernametxt = userName.Value;
            string passwordtxt = Password.Value;

            ActiveDirectoryHelper ADhelper = new ActiveDirectoryHelper();
            var details = ADhelper.GetUserByLoginName(usernametxt);
            var ADuser = details.LoginName;

            PrincipalContext context = new PrincipalContext(ContextType.Domain, domain);

            // Validate credentials against Active Directory
            bool is_valid = context.ValidateCredentials(usernametxt, passwordtxt);

            if (is_valid)
            {
                // Check if the AD username matches a username in the PortalUsers table
                if (IsAuthorizedUser(ADuser, out string userName, out string employeeID))
                {
                    // Store user data in session variables
                    Session["AdminLoggedIn"] = true;
                    Response.Redirect("AdminPanel.aspx");
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "Unauthorized user.";
                }
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Invalid login credential.";
            }
        }

        private bool IsAuthorizedUser(string username, out string userName, out string employeeID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString;
            userName = employeeID = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM AdminUser WHERE UserName = @UserName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", username);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        employeeID = reader["EmployeeID"].ToString();
                        userName = reader["UserName"].ToString();

                        return true;
                    }
                }
            }

            return false;
        }
    }

}