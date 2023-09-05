using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormProject2
{
    public partial class AdminPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminLoggedIn"] == null || !(bool)Session["AdminLoggedIn"])
            {
                Session.Abandon();
                Session.Clear();
                Response.Redirect("AdminLogin.aspx");
            }

        }

        SqlConnection con = new SqlConnection(@"Data Source=crmtest;Initial Catalog=Trainee_Evaluation_System_DB;User ID=t_graduate;Password=Oracle_123");
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string EmployeeID = txtEmployeeID.Text;
            string username = txtUsername.Text;
            string FullName = txtFullName.Text;
            string Email = txtemail.Text;
            string role = txtRole.Text;
            string Department = TxtDepartment.Text;

            con.Open();
            SqlCommand co = new SqlCommand("exec S_Evaluation  " + username.ToString() + ",'" + FullName.ToString() + "','" + Email.ToString() + "','" + Department.ToString() + "','" + role.ToString() + "','" + EmployeeID.ToString() + "'", con);
            co.ExecuteNonQuery();
            con.Close();

        }
    }
}