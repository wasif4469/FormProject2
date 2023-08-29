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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IsLoggedIn"] == null || !(bool)Session["IsLoggedIn"])
            {
                Response.Redirect("LoginPage.aspx");
            }

            int EmployeeID = int.Parse(Session["EmployeeID"].ToString());
            string Role = Session["UserRole"].ToString();

            if (Role == "Tech Grduate")
            {
                DisableFormElements();
            }
            if (Role == "Team Lead")
            {
                DisableFormElements();
                Table.Enabled = true;
                Button5.Visible = true;

            }
            if (Role == "Section Head")
            {
                DisableFormElements();
                Button2.Visible = true;
                Button3.Visible = true;
                TextBox2.Visible = true;


            }
            if (Role == "Group Head")
            {
                DisableFormElements();
                Button4.Visible = true;
                Rej.Visible = true;
                TextBox3.Visible = true;

            }

            //Table.Visible = false;
            if (!IsPostBack)
            {

                GetIndicator();
                Getprocess();
                GetReject();

                using (SqlConnection connection = new SqlConnection(@"Data Source=crmtest;Initial Catalog=Trainee_Evaluation_System_DB;User ID=t_graduate;Password=Oracle_123"))
                {
                    connection.Open();

                    string query = "SELECT SUB_TOTAL FROM Details WHERE Employee_ID = @Employee_ID and ISACTIVE = 1";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Employee_ID", EmployeeID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string column1Value = reader["SUB_TOTAL"].ToString();

                                TextBox1.Text = column1Value;

                            }
                        }
                    }
                }
            }
        }
        private bool IsAllDropDownListsValid()
        {
            if (DDL1.SelectedValue == "0" ||
                  DDL2.SelectedValue == "0" ||
                  DDL3.SelectedValue == "0" ||
                   DDL4.SelectedValue == "0" ||
                    DDL5.SelectedValue == "0" ||
                     DDL6.SelectedValue == "0")
            {
                return false;
            }
            return true;
        }

        SqlConnection con = new SqlConnection(@"Data Source=crmtest;Initial Catalog=Trainee_Evaluation_System_DB;User ID=t_graduate;Password=Oracle_123");

        protected void Btn1_Click(object sender, EventArgs e)
        {
            int EmployeeID = int.Parse(Session["EmployeeID"].ToString());
            Boolean ISACTIVE = true;

            if ((EmployeeID.ToString() == Session["EmployeeID"].ToString()) && ISACTIVE == true)
            {
                int sum = 0;
                if (!string.IsNullOrEmpty(DDL1.SelectedValue))
                    sum += Convert.ToInt32(DDL1.SelectedValue);

                if (!string.IsNullOrEmpty(DDL2.SelectedValue))
                    sum += Convert.ToInt32(DDL2.SelectedValue);

                if (!string.IsNullOrEmpty(DDL3.SelectedValue))
                    sum += Convert.ToInt32(DDL3.SelectedValue);

                if (!string.IsNullOrEmpty(DDL4.SelectedValue))
                    sum += Convert.ToInt32(DDL4.SelectedValue);

                if (!string.IsNullOrEmpty(DDL5.SelectedValue))
                    sum += Convert.ToInt32(DDL5.SelectedValue);

                if (!string.IsNullOrEmpty(DDL6.SelectedValue))
                    sum += Convert.ToInt32(DDL6.SelectedValue);
                if (!string.IsNullOrEmpty(TextBox1.Text))
                    sum += Convert.ToInt32(TextBox1.Text);

                TextBox4.Text = sum.ToString();

                if (IsAllDropDownListsValid())
                {


                    int Indicator_01_Rating = int.Parse(DDL1.SelectedValue); int Indicator_02_Rating = int.Parse(DDL2.SelectedValue);
                    int Indicator_03_Rating = int.Parse(DDL3.SelectedValue); int Indicator_04_Rating = int.Parse(DDL4.SelectedValue);
                    int Indicator_05_Rating = int.Parse(DDL5.SelectedValue); int Indicator_06_Rating = int.Parse(DDL6.SelectedValue);
                    int Indicator_07_Rating = int.Parse(TextBox4.Text);
                    Boolean Approved_By_Team_Lead = true;
                    String Status_Application = "sh_pending";
                    ISACTIVE = true;
                    con.Open();
                    SqlCommand co = new SqlCommand("exec Indicator_Update  " + EmployeeID + ",'" + Indicator_01_Rating + "', '" + Indicator_02_Rating + "','" + Indicator_03_Rating + "','" + Indicator_04_Rating + "','" + Indicator_05_Rating + "','" + Indicator_06_Rating + "','" + Indicator_07_Rating + "','" + Approved_By_Team_Lead + "','" + Status_Application + "','" + ISACTIVE + "'", con);
                    co.ExecuteNonQuery();
                    con.Close();
                    GetIndicator();
                    Label6.Visible = true;
                    Label6.Text = "Succesfully Submited data";
                }
                else
                {
                    Label6.Visible = true;
                    Label6.Text = "Kindly select other than 0";
                }
            }
        }

        void GetIndicator()
        {
            SqlCommand co = new SqlCommand("exec Indicator_SP ", con);
            SqlDataAdapter sd = new SqlDataAdapter(co);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int EmployeeID = int.Parse(Session["EmployeeID"].ToString());
            Boolean ISACTIVE = true;

            if ((EmployeeID.ToString() == Session["EmployeeID"].ToString()) && ISACTIVE == true)
            {
                Boolean Approved_By_Section_Head = true;
                String Status_Application = "gh_pending";
                ISACTIVE = true;
                con.Open();
                SqlCommand co = new SqlCommand("exec SH_Process  " + EmployeeID + ",'" + Approved_By_Section_Head + "','" + Status_Application + "','" + ISACTIVE + "'", con);
                co.ExecuteNonQuery();
                con.Close();
                Getprocess();
            }
        }

        void Getprocess()
        {
            SqlCommand co = new SqlCommand("exec  SH_Process ", con);
            //  SqlCommand co = new SqlCommand("exec  GH_Process ", con);
            SqlDataAdapter sd = new SqlDataAdapter(co);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int EmployeeID = int.Parse(Session["EmployeeID"].ToString());
            Boolean ISACTIVE = true;

            if ((EmployeeID.ToString() == Session["EmployeeID"].ToString()) && ISACTIVE == true)
            {
                Boolean Approved_By_Group_Head = true;
                String Status = "Completed";
                String Status_Application = "Completed";
                ISACTIVE = false;
                con.Open();
                SqlCommand co = new SqlCommand("exec GH_Process  " + EmployeeID + ",'" + Approved_By_Group_Head + "','" + Status + "','" + Status_Application + "','" + ISACTIVE + "'", con);
                co.ExecuteNonQuery();
                con.Close();
                Getprocess();

            }
        }

        protected void Rejbtn1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox2.Text))
            {
                RejLabel1.Visible = true;
                RejLabel1.Text = "please also give remarks";
            }
            else
            {
                RejLabel1.Visible = false;
            }

            int EmployeeID = int.Parse(Session["EmployeeID"].ToString());
            Boolean ISACTIVE = true;
            if ((EmployeeID.ToString() == Session["EmployeeID"].ToString()) && ISACTIVE == true)
            {
                Boolean Approved_By_Section_Head = false;
                String Status_Application = "sh_rejected";
                String SECTION_HEAD_REJECTION = TextBox2.Text;

                con.Open();
                SqlCommand co = new SqlCommand("exec SH_Reject  " + Approved_By_Section_Head + ",'" + Status_Application + "','" + SECTION_HEAD_REJECTION.ToString() + "'", con);
                co.ExecuteNonQuery();
                con.Close();
                GetReject();
            }
        }

        void GetReject()
        {
            SqlCommand co = new SqlCommand("exec  SH_Reject ", con);
            SqlDataAdapter sd = new SqlDataAdapter(co);
        }

        protected void Rejbtn2(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox3.Text))
            {
                RejLabel2.Visible = true;
                RejLabel2.Text = "Please Provide Remarks";
            }
            else
            {
                RejLabel2.Visible = false;
            }
            int EmployeeID = int.Parse(Session["EmployeeID"].ToString());
            Boolean ISACTIVE = true;
            if ((EmployeeID.ToString() == Session["EmployeeID"].ToString()) && ISACTIVE == true)
            {
                String Status_Application = "gh_rejected";
                Boolean Approved_By_Group_Lead = false;
                String GROUP_LEAD_REJECTION = TextBox3.Text;
                con.Open();
                SqlCommand co = new SqlCommand("exec GH_Reject  " + Approved_By_Group_Lead + ",'" + Status_Application + "','" + GROUP_LEAD_REJECTION.ToString() + "'", con);
                co.ExecuteNonQuery();
                con.Close();
                GetReject();
            }
        }

        private void DisableFormElements()
        {
            Table.Enabled = false;
            Button5.Visible = false;
            Button2.Visible = false;
            Button3.Visible = false;
            Button4.Visible = false;
            Rej.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
        }

    }
}