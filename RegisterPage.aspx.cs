using ActiveDirectorySynchronization;
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
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        ActiveDirectoryHelper ADhelper = new ActiveDirectoryHelper();

        protected void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            string enteredEmployeeCode = txtEmployeeID.Text.Trim();

            var userDetails = ADhelper.GetUsersByEmployeeCode(enteredEmployeeCode);

            if (userDetails!=null)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM PortalUsers WHERE EmployeeID = @EmployeeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID",  enteredEmployeeCode);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                              
                                // Employee code found in the database
                                txtUsername.Text = reader["UserName"].ToString();
                                txtFullName.Text = reader["FullName"].ToString();
                                txtemail.Text = reader["Email"].ToString();
                                txtRole.Text = reader["Designation"].ToString();

                                txtemail.Enabled = false;
                                txtFullName.Enabled = false;
                                txtRole.Enabled = false;
                                txtUsername.Enabled = false;

                            }
                            else
                            {
                                RegisterLabel.Text = "Employee Code not found in the Database!";
                                
                            }
                        }
                    }
                }
            }
            else
            {
                RegisterLabel.Text = "Employee Code not found in the active Directory!";
            
            }
        }
    }
}