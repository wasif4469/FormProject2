using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
            string Password = txtPassword.Text.ToString();
            string Email = txtemail.Text.ToString();
            string Roles = category.Text.ToString();

            con.Open();
            SqlCommand co = new SqlCommand("exec U_Login  " + Employee_ID + ",'" + User_Name.ToString() + "','" + Password.ToString() + "','" + Email.ToString() + "','" + Roles.ToString() + "'", con);
            co.ExecuteNonQuery();
            con.Close();

           

            txtEmployeeID.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtemail.Text = "";

            
        }
    }
}