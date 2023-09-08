using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormProject2
{
    public partial class AdminPanelUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            SqlCommand cmd = new SqlCommand("UpdatePortalUser", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@FullName", FullName);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Department", Department);
            cmd.Parameters.AddWithValue("@Designation", role);

            cmd.ExecuteNonQuery();
            con.Close();
            RegisterLabel.Visible = true;
            RegisterLabel.Text = "Employee Details Updated Successfully";
            ClearAllFields();
        }

        private void ClearAllFields() {
            txtemail.Text = "";
            txtEmployeeID.Text = "";
            txtFullName.Text = "";
            txtRole.Text = "";
            txtUsername.Text = "";
            TxtDepartment.Text = "";
        }
    }
}