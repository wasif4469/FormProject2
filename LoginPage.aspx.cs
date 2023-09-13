using ActiveDirectorySynchronization;
using System;
using System.ComponentModel.DataAnnotations;
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
            string redirectURL = Request.QueryString["redirectURL"];
            Session["RedirectURL"] = redirectURL;
            string requestedPage = Session["RedirectURL"]?.ToString();

            if (requestedPage == null)
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
                    if (IsAuthorizedUser(ADuser, out string role, out string employeeID, out string fullname, out string Department, out string userName, out string TeamName, out string Email))
                    {
                        // Store user data in session variables
                        Session["IsLoggedIn"] = true;
                        Session["UserRole"] = "Section Head";
                        Session["UserName"] = userName;
                        Session["EmployeeID"] = employeeID;
                        Session["Department"] = Department;
                        Session["FullName"] = fullname;
                        Session["TeamName"] = TeamName;
                        Session["Email"] = Email;

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
            else if (requestedPage != null)
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
                    if (IsAuthorizedUser(ADuser, out string role, out string employeeID, out string fullname, out string Department, out string userName, out string TeamName, out string Email))
                    {
                        // Store user data in session variables
                        Session["IsLoggedIn"] = true;
                        Session["UserRole"] = role;
                        Session["UserName"] = userName;
                        Session["EmployeeID"] = employeeID;
                        Session["Department"] = Department;
                        Session["FullName"] = fullname;
                        Session["TeamName"] = TeamName;
                        Session["Email"] = Email;

                        if (requestedPage.StartsWith("/form/"))
                        {
                            // Extract the ID from the URL
                            string[] parts = requestedPage.Split('/');
                            if (parts.Length == 3)
                            {
                                string id = parts[2]; // Assuming ID is the third part of the URL

                                // Perform any necessary processing with the ID

                                // Redirect to /form2/{id} page
                                Response.Redirect("~/form/" + id); // Redirect to the requested ID
                            }
                            else
                            {
                                // If the URL format is incorrect, redirect them to the default page
                                Response.Redirect("~/LoginPage.aspx");
                            }
                        }

                        else if (requestedPage.StartsWith("/form2/"))
                        {
                            // Extract the ID from the URL
                            string[] parts = requestedPage.Split('/');
                            if (parts.Length == 3)
                            {
                                string id = parts[2]; // Assuming ID is the third part of the URL

                                // Perform any necessary processing with the ID

                                // Redirect to /form2/{id} page
                                Response.Redirect("~/form2/" + id); // Redirect to the requested ID
                            }
                            else
                            {
                                // If the URL format is incorrect, redirect them to the default page
                                Response.Redirect("~/LoginPage.aspx");
                            }
                        }
                        else if (requestedPage.StartsWith("/form3/"))
                        {
                            // Extract the ID from the URL
                            string[] parts = requestedPage.Split('/');
                            if (parts.Length == 3)
                            {
                                string id = parts[2]; // Assuming ID is the third part of the URL

                                // Perform any necessary processing with the ID

                                // Redirect to /form3/{id} page
                                Response.Redirect("~/form3/" + id); // Redirect to the requested ID
                            }
                            else
                            {
                                // If the URL format is incorrect, redirect them to the default page
                                Response.Redirect("~/LoginPage.aspx");
                            }
                        }
                        else
                        {
                            // If the user requested any other page, redirect them to the default page
                            Response.Redirect("~/LoginPage.aspx");
                        }
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
        }

        private bool IsAuthorizedUser(string username, out string role, out string employeeID, out string fullname, out string Department, out string userName, out string TeamName, out string Email)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString;
            role = employeeID = fullname = Department = userName = TeamName = Email = string.Empty;
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
                        Email = reader["Email"].ToString();
                        role = reader["Designation"].ToString();
                        employeeID = reader["EmployeeID"].ToString();
                        fullname = reader["FullName"].ToString();
                        Department = reader["Department"].ToString();
                        userName = reader["UserName"].ToString();
                        TeamName = reader["TeamName"].ToString();
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
