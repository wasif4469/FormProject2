using ActiveDirectorySynchronization;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.DirectoryServices.AccountManagement;
using System.Web.UI;

namespace FormProject2
{
    public partial class LoginPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Clear();
                Session.Abandon();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string domain = "jubileelife.com";
            string usernametxt = username.Value;
            string passwordtxt = password.Value;

            ActiveDirectoryHelper ADhelper = new ActiveDirectoryHelper();
            var details = ADhelper.GetUserByLoginName(usernametxt);
            var ADuser = details.LoginName;

            PrincipalContext context = new PrincipalContext(ContextType.Domain, domain);

            // Validate credentials against Active Directory
            bool is_valid = context.ValidateCredentials(usernametxt, passwordtxt);

            if (is_valid)
            {
                // Check if the AD username matches a username in the PortalUsers table
                if (IsAuthorizedUser(ADuser, out string role, out string employeeID, out string fullname, out string Department, out string userName))
                {
                    // Store user data in session variables
                    Session["IsLoggedIn"] = true;
                    Session["UserRole"] = role;
                    Session["UserName"] = userName;
                    Session["EmployeeID"] = employeeID;
                    Session["Department"] = Department;
                    Session["FullName"] = fullname;

                    Response.Redirect("WebForm.aspx");
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

        private bool IsAuthorizedUser(string username, out string role, out string employeeID, out string fullname, out string Department, out string userName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString;
            role = employeeID = fullname = Department = userName = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PortalUsers WHERE UserName = @UserName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", username);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        role = reader["Designation"].ToString();
                        employeeID = reader["EmployeeID"].ToString();
                        fullname = reader["FullName"].ToString();
                        Department = reader["Department"].ToString();
                        userName = reader["UserName"].ToString();
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
