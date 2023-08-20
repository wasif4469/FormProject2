using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormProject2
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string usernametext = username.Value;
                string passwordtext = password.Value;
                string userRole = category.Value.ToString();

                string query = "SELECT * FROM LOGIN WHERE User_Name = @User_name AND Role = @Role";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@User_Name", usernametext);

                    command.Parameters.AddWithValue("@Role", userRole);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashedPasswordFromDB = reader["Password"].ToString();
                            if (VerifyPassword(passwordtext, hashedPasswordFromDB))
                            {
                                // Successful login
                                Session["IsLoggedIn"] = true;
                                Session["UserRole"] = userRole;
                                Session["UserName"] = usernametext;
                                Session["EmployeeID"] = reader["Employee_ID"].ToString();
                                Response.Redirect("WebForm.aspx"); // Redirect to the dashboard page
                            }
                            else
                            {
                                // Failed login
                                Label1.Text = "Invalid login credentials.";
                            }
                        }
                        else
                        {
                            // User not found
                            Label1.Text = "User not found.";
                        }

                    }
                }

            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        private bool VerifyPassword(string password, string hashedPassword)
        {
            string hashedInputPassword = HashPassword(password);
            return hashedInputPassword == hashedPassword;
        }
    }
}