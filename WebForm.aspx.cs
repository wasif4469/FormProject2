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

            if (IsPostBack)
            {
                // Redirect to the target page and pass data using QueryString
                Response.Redirect("LoginPage.aspx?Label1Text=Please+Provide+Credentials");
            }
        }

        SqlConnection con = new SqlConnection(@"Data Source=crmtest;Initial Catalog=Trainee_Evaluation_System_DB;User ID=t_graduate;Password=Oracle_123");
        protected void btnSubmit_Click(object sender, EventArgs e)
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
            string TEAM_LEAD_NAME = Textsupervisor.Text.ToString();
            string DATE = Textdate.Text.ToString();
            Boolean ISACTIVE = false;

            con.Open();
            SqlCommand co = new SqlCommand("exec S_Evaluation  " + Employee_ID + ",'" + Trainee_Name.ToString() + "','" + Section_Name.ToString() + "','" + Answer_01.ToString() + "','" + Answer_02.ToString() + "','" + Answer_03.ToString() + "','" + Answer_04.ToString() + "','" + Answer_05.ToString() + "','" + Answer_06.ToString() + "','" + Answer_07.ToString() + "','" + TEAM_LEAD_NAME.ToString() + "','" + DATE.ToString() + "','" + ISACTIVE + "'", con);
            co.ExecuteNonQuery();
            con.Close();
        }
    }
}