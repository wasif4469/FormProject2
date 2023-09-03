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
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IsLoggedIn"] == null || !(bool)Session["IsLoggedIn"])
            {
                Response.Redirect("LoginPage.aspx");
            }

            if (Page.RouteData.Values["id"] != null)
            {
                if (!IsPostBack)
                {
                    Func();

                }

            }

            string Role = Session["UserRole"].ToString();

            if (Role == "Tech Graduate")
            {
                Textempid.Text = Session["EmployeeID"].ToString();
                Textname.Text = Session["FullName"].ToString();
                Textempid.Enabled = false;
                // Allow Tech-Graduate to edit
                EnableFormElements(true);
                Textname.Enabled = false;
            }
            else if (Role == "Team Lead")
            {
                // Redirect or restrict access for Team Lead
                Response.Redirect("WebForm2.aspx");
            }
            else if (Role == "Section Head")
            {
                // Allow Section-Head and Group Head to view, but not edit
                Response.Redirect("WebForm2.aspx");
                EnableFormElements(false);
            }

            else if(Role == "Group Head")
            {
                
                EnableFormElements(false);
            }

        }

        SqlConnection con = new SqlConnection(@"Data Source=crmtest;Initial Catalog=Trainee_Evaluation_System_DB;User ID=t_graduate;Password=Oracle_123");
        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            if (Textempid.Text == Session["EmployeeID"].ToString())
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
                Boolean ISACTIVE = true;


                con.Open();
                SqlCommand co = new SqlCommand("exec S_Evaluation  " + Employee_ID + ",'" + Trainee_Name.ToString() + "','" + Section_Name.ToString() + "','" + Answer_01.ToString() + "','" + Answer_02.ToString() + "','" + Answer_03.ToString() + "','" + Answer_04.ToString() + "','" + Answer_05.ToString() + "','" + Answer_06.ToString() + "','" + Answer_07.ToString() + "','" + Answer_08.ToString() + "','" + TEAM_LEAD_NAME.ToString() + "','" + DATEFROM.ToString() + "','" + DateTO.ToString() + ISACTIVE + "'", con);
                co.ExecuteNonQuery();
                con.Close();
            }
        }

        private void EnableFormElements(bool enable)
        {
            Textname.Enabled = enable;
            Textsection.Enabled = enable;
            Textsupervisor.Enabled = enable;
            //Textdate.Enabled = enable;
            TextBox1.Enabled = enable;
            TextBox2.Enabled = enable;
            TextBox3.Enabled = enable;
            TextBox4.Enabled = enable;
            TextBox5.Enabled = enable;
            TextBox6.Enabled = enable;
            TextBox7.Enabled = enable;
            TextBox8.Enabled = enable;
            btnSubmit.Visible = enable; // Show/hide submit button based on the role
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