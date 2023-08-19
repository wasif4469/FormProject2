using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormProject2
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        SqlConnection con = new SqlConnection(@"Data Source=crmtest;Initial Catalog=Trainee_Evaluation_System_DB;User ID=t_graduate;Password=Oracle_123");
        protected void Button1_Click(object sender, EventArgs e)
        {
            string Employee_ID = txtEmployeeID.Text.ToString();
            string User_Name = txtUsername.Text.ToString();
            string Password = txtPassword.Text;
            string Email = txtemail.Text.ToString();
            string Roles = category.Text.ToString();
            string hashedPassword = HashPassword(Password);

            con.Open();
            SqlCommand co = new SqlCommand("exec U_Login  " + Employee_ID + ",'" + User_Name.ToString() + "','" + hashedPassword + "','" + Email.ToString() + "','" + Roles.ToString() + "'", con);
            co.ExecuteNonQuery();
            con.Close();

            RegisterLabel.Text = "User Created Successfully";

           

            txtEmployeeID.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtemail.Text = "";

            
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
    }
}