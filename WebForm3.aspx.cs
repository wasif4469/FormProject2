using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormProject2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int count = 0;
            if (Session["IsLoggedIn"] == null || !(bool)Session["IsLoggedIn"])
            {
                string requestedURL = Request.Url.AbsolutePath.ToString();
                Response.Redirect("/LoginPage.aspx?redirectURL=" + requestedURL);
            }
      
            else
            {

                if (Page.RouteData.Values["id"] != null)
                {
                    if (!IsPostBack)
                    {
                        count++;
                        Func();
                    }
                }
            }

            string EmployeeID = Session["EmployeeID"].ToString();

            string Role = Session["UserRole"].ToString();


            if (!IsPostBack && Role == "Group Head")
            {
               
                Trainee();
                section();
                DisableFormElements();


            }

            if (Role == "Tech Graduate")
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
                Label2.Visible = true;
                Label3.Visible = true;
                TextBox2.Visible = true;
                SHPanel.Visible = true;
            }
            if (Role == "Group Head")
            {
                DisableFormElements();
                Button4.Visible = true;
                Rej.Visible = true;
                Label4.Visible = true;
                Label5.Visible = true;
                TextBox3.Visible = true;
                if (count > 0)
                {
                    GHPanel.Visible = true;
                    trainee.Visible = false;
                    Depart.Visible = false;
                }
                else {
                    GHPanel.Visible = false;
                    Label4.Visible = false;
                    trainee.Visible = true;
                    Depart.Visible = true;
                }
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
            string EmployeeID = Session["EmployeeID"].ToString();
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
            string EmployeeID = Session["EmployeeID"].ToString();

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
                RejLabel1.Visible = true;
                RejLabel1.Text = "Form Approved!";
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
            string EmployeeID = Session["EmployeeID"].ToString();

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
                RejLabel1.Visible = true;
                RejLabel1.Text = "Form Approved!";

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

            string EmployeeID = Session["EmployeeID"].ToString();
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
                RejLabel1.Visible = true;
                RejLabel1.Text = "Form Rejected";
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
            string EmployeeID = Session["EmployeeID"].ToString();

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
                RejLabel2.Visible = true;
                RejLabel2.Text = "Form Rejected!";
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
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            SHPanel.Visible = false;
            GHPanel.Visible = false;
            trainee.Visible = false;
            Depart.Visible = false;

        }
        void Func()
        {
            string value = Page.RouteData.Values["id"].ToString();
            con.Open();
            SqlCommand co = new SqlCommand("select  *  from Details where ID = " + value, con);
            SqlDataReader dr = co.ExecuteReader();
            if (dr.Read())
            {
                Session["EmployeeID"] = dr["Employee_ID"].ToString();
                DDL1.SelectedValue = dr["Indicator_01_Rating"].ToString();
                DDL2.SelectedValue = dr["Indicator_02_Rating"].ToString();
                DDL3.SelectedValue = dr["Indicator_03_Rating"].ToString();
                DDL4.SelectedValue = dr["Indicator_04_Rating"].ToString();
                DDL5.SelectedValue = dr["Indicator_05_Rating"].ToString();
                DDL6.SelectedValue = dr["Indicator_06_Rating"].ToString();
                TextBox1.Text = dr["Indicator_07_Rating"].ToString();
                TextBox4.Text = dr["Total_Rating"].ToString();
                TextBox2.Text = dr["SECTION_HEAD_REJECTION"].ToString();
                TextBox3.Text = dr["GROUP_LEAD_REJECTION"].ToString();
            }
            con.Close();
        }
        void Trainee()
        {


            con.Open();
            SqlDataAdapter comm = new SqlDataAdapter("select Distinct Trainee_Name from Details ", con);
            DataTable dt = new DataTable();
            comm.Fill(dt);
            trainee.DataSource = dt;
            trainee.DataTextField = "Trainee_Name";
            trainee.DataBind();
            trainee.Items.Insert(0, new ListItem("Please select", ""));
            con.Close();

        }
        void section()
        {


            con.Open();
            SqlDataAdapter comm = new SqlDataAdapter("select Distinct Section_Name from Details ", con);
            DataTable dt = new DataTable();
            comm.Fill(dt);
            Depart.DataSource = dt;
            Depart.DataTextField = "Section_Name";
            Depart.DataBind();
            Depart.Items.Insert(0, new ListItem("Please select", ""));
            con.Close();
        }
        protected void fetch(object sender, EventArgs e)
        {
            if (trainee.SelectedItem.Text != "Please select" && Depart.SelectedItem.Text != "Please select")

            {
                string traini = trainee.SelectedItem.Text.ToString();
                string sect = Depart.SelectedItem.Text.ToString();

                con.Open();

                string query = $"SELECT * FROM Details WHERE Trainee_Name = '{traini}' AND Section_Name = '{sect}'";
                SqlCommand co = new SqlCommand(query, con);
                SqlDataReader dr = co.ExecuteReader();
                if (dr.Read())
                {

                    DDL1.SelectedValue = dr["Indicator_01_Rating"].ToString();
                    DDL2.SelectedValue = dr["Indicator_02_Rating"].ToString();
                    DDL3.SelectedValue = dr["Indicator_03_Rating"].ToString();
                    DDL4.SelectedValue = dr["Indicator_04_Rating"].ToString();
                    DDL5.SelectedValue = dr["Indicator_05_Rating"].ToString();
                    DDL6.SelectedValue = dr["Indicator_06_Rating"].ToString();
                    TextBox1.Text = dr["SUB_TOTAL"].ToString();
                    TextBox4.Text = dr["Total_Rating"].ToString();
                    TextBox2.Text = dr["SECTION_HEAD_REJECTION"].ToString();
                    TextBox3.Text = dr["GROUP_LEAD_REJECTION"].ToString();
                }

                con.Close();

            }
        }

    }
}