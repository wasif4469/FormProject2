using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormProject2
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["Label1Text"]))
            {
                Label1.Text = Request.QueryString["Label1Text"];
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string usernametext = username.Value;
                string passwordtext = password.Value;
                string userRole = category.Value.ToString();

                string query = "SELECT COUNT(*) FROM LOGIN WHERE User_Name = @User_name AND Password = @Password AND Role = @Role";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@User_Name", usernametext);
                    command.Parameters.AddWithValue("@Password", passwordtext);
                    command.Parameters.AddWithValue("@Role", userRole);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        // Successful login
                        Session["IsLoggedIn"] = true;
                        Response.Redirect("WebForm.aspx"); // Redirect to the dashboard page
                    }
                    else
                    {
                        // Failed login
                        Label1.Text = "Invalid login credentials.";
                    }
                }
            }
        }
    }
}