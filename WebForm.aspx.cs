using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FormProject2
{
    public partial class WebForm : System.Web.UI.Page
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

            string Role = Session["UserRole"].ToString();

            if (!IsPostBack && Role == "Group Head")
            {

                Trainee();
                section();

            }



            if (Role == "Tech Graduate")
            {
                Textempid.Text = Session["EmployeeID"].ToString();
                Textname.Text = Session["FullName"].ToString();
                TextEmail.Text = Session["Email"].ToString();
                EnableFormElements(true);
                Textname.Enabled = false;
                Textempid.Enabled = false;
                TextEmail.Enabled = false;
                trainee.Visible = false;
                Depart.Visible = false;
            }
            else if (Role == "Team Lead")
            {
                // Redirect or restrict access for Team Lead
                EnableFormElements(false);
                trainee.Visible = false;
                Depart.Visible = false;
                Response.Redirect("WebForm2.aspx");

            }
            else if (Role == "Section Head")
            {
                // Allow Section-Head and Group Head to view, but not edit
                Response.Redirect("WebForm2.aspx");
                EnableFormElements(false);
                trainee.Visible = false;
                Depart.Visible = false;
            }

            else if (Role == "Group Head")
            {
                EnableFormElements(false);
                if (count > 0)
                {
                    trainee.Visible = false;
                    Depart.Visible = false;
                }
                else
                {
                    trainee.Visible = true;
                    Depart.Visible = true;
                }
            }

        }

        SqlConnection con = new SqlConnection(@"Data Source=crmtest;Initial Catalog=Trainee_Evaluation_System_DB;User ID=t_graduate;Password=Oracle_123");
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox1.Text) || string.IsNullOrWhiteSpace(TextBox2.Text) || string.IsNullOrWhiteSpace(TextBox3.Text) || string.IsNullOrWhiteSpace(TextBox4.Text) || string.IsNullOrWhiteSpace(TextBox5.Text) || string.IsNullOrWhiteSpace(TextBox6.Text) || string.IsNullOrWhiteSpace(TextBox8.Text) || string.IsNullOrWhiteSpace(TextBox7.Text))

            {
                // Display a message or perform any action you want
                // For example, you can show an error message on the page
                // You can also prevent further processing of the form if needed
                // Here, I'm setting a label's text to display the error message
                Label1.Visible = true;
                Label1.Text = "Please fill in all textboxes before submitting the form.";
                return; // Prevent further processing
            }

            else if (Textempid.Text == Session["EmployeeID"].ToString())
            {
                int Employee_ID = int.Parse(Textempid.Text);
                string Trainee_Name = Textname.Text.ToString();
                string Section_Name = Textsection.Text.ToString();
                string Answer_01 = TextBox1.Text.ToString();
                string Answer_02 = TextBox2.Text.ToString();
                string Answer_03 = TextBox3.Text.ToString();
                string Answer_04 = TextBox4.Text.ToString();
                string Answer_05 = TextBox5.Text.ToString();
                string Answer_06 = TextBox6.Text.ToString();
                string Answer_07 = TextBox7.Text.ToString();
                string Answer_08 = TextBox8.Text.ToString();
                string TEAM_LEAD_NAME = Textsupervisor.Text.ToString();
                string DATEFROM = TextdateFrom.Text.ToString();
                string DateTO = TextdateTo.Text.ToString();
                string Email = TextEmail.Text.ToString();
                Boolean ISACTIVE = true;


                con.Open();
                SqlCommand co = new SqlCommand("exec S_Evaluation  " + Employee_ID + ",'" + Trainee_Name.ToString() + "','" + Section_Name.ToString() + "','" + Answer_01.ToString() + "','" + Answer_02.ToString() + "','" + Answer_03.ToString() + "','" + Answer_04.ToString() + "','" + Answer_05.ToString() + "','" + Answer_06.ToString() + "','" + Answer_07.ToString() + "','" + Answer_08.ToString() + "','" + TEAM_LEAD_NAME.ToString() + "','" + DATEFROM.ToString() + "','" + DateTO.ToString() + "','" + ISACTIVE + "','" + Email.ToString() + "'", con);
                co.ExecuteNonQuery();
                con.Close();
                Label1.Visible = true;
                Label1.Text = "Form Submitted Successfully";
                ClearAllFields();
            }
        }

        private void EnableFormElements(bool enable)
        {
            Textname.Enabled = enable;
            TextEmail.Enabled = enable;
            Textempid.Enabled = enable;
            Textsection.Enabled = enable;
            Textsupervisor.Enabled = enable;
            TextdateFrom.Enabled = enable;
            TextdateTo.Enabled = enable;
            TextBox1.Enabled = enable;
            TextBox2.Enabled = enable;
            TextBox3.Enabled = enable;
            TextBox4.Enabled = enable;
            TextBox5.Enabled = enable;
            TextBox6.Enabled = enable;
            TextBox7.Enabled = enable;
            TextBox8.Enabled = enable;
            btnSubmit.Visible = enable;
            trainee.Visible = enable;
            Depart.Visible = enable;
        }

        private void ClearAllFields() {
            Textsection.Text = "";
            Textsupervisor.Text = "";
            TextdateFrom.Text = "";
            TextdateTo.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";

        }

        void Func()
        {
            string value = Page.RouteData.Values["id"].ToString();
            con.Open();
            SqlCommand co = new SqlCommand("select  *  from Details where ID = " + value, con);
            SqlDataReader dr = co.ExecuteReader();
            if (dr.Read())
            {
                Textempid.Text = dr["Employee_ID"].ToString();
                Textname.Text = dr["Trainee_Name"].ToString();
                TextEmail.Text = dr["email"].ToString();
                Textsection.Text = dr["Section_Name"].ToString();
                TextdateFrom.Text = dr["FROM_DATE"].ToString();
                TextdateTo.Text = dr["TO_DATE"].ToString();
                Textsupervisor.Text = dr["TEAM_LEAD_NAME"].ToString();
                TextBox1.Text = dr["Answer_01"].ToString();
                TextBox2.Text = dr["Answer_02"].ToString();
                TextBox3.Text = dr["Answer_03"].ToString();
                TextBox4.Text = dr["Answer_04"].ToString();
                TextBox5.Text = dr["Answer_05"].ToString();
                TextBox6.Text = dr["Answer_06"].ToString();
                TextBox7.Text = dr["Answer_08"].ToString();
                TextBox8.Text = dr["Answer_07"].ToString();
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
                    Textempid.Text = dr["Employee_ID"].ToString();
                    TextEmail.Text = dr["email"].ToString();
                    Textname.Text = dr["Trainee_Name"].ToString();
                    Textsection.Text = dr["Section_Name"].ToString();
                    TextdateFrom.Text = dr["FROM_DATE"].ToString();
                    TextdateTo.Text = dr["TO_DATE"].ToString();
                    Textsupervisor.Text = dr["TEAM_LEAD_NAME"].ToString();
                    TextBox1.Text = dr["Answer_01"].ToString();
                    TextBox2.Text = dr["Answer_02"].ToString();
                    TextBox3.Text = dr["Answer_03"].ToString();
                    TextBox4.Text = dr["Answer_04"].ToString();
                    TextBox5.Text = dr["Answer_05"].ToString();
                    TextBox6.Text = dr["Answer_06"].ToString();
                    TextBox7.Text = dr["Answer_08"].ToString();
                    TextBox8.Text = dr["Answer_07"].ToString();
                }

                con.Close();

            }
        }

    }
}