using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormProject2
{
    public partial class form2 : System.Web.UI.Page
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

            Session["EmployeeID"] = Employ_ID1.Text;

            Trainee_details.Enabled = false;
            Static_table.Enabled = false;
            Activity_table.Enabled = false;
            Activity_table.Enabled = false;
            Submit.Visible = false;
            Review.Visible = false;
            ApprovalPanel.Visible = false;
            Submit.Visible = false;
            Review.Visible = false;
            trainee.Visible = false;
            Depart.Visible = false;

            if (Role == "Tech Graduate")
            {
                Employ_ID1.Enabled = false;
                program1.Text = Role;
                program1.Enabled = false;
                Name1.Enabled = false;
                Trainee_details.Enabled = true;
                Activity_table.Enabled = true;
                TextArea1.Visible = false;  // Disable the textarea
                Team_name1.Enabled = false;
                Label8.Visible = false;
                ApprovalPanel.Visible = true;
                section_name1.Enabled = false;
                Section_head_name1.Enabled = false;
                Remarks.Enabled = false;
                button.Enabled = false;

            }
            else if (Role == "Team Lead")
            {
                Activity_table.Enabled = true;
                TextArea1.Visible = false;
                Label8.Visible = false;
                ApprovalPanel.Visible = true;
            }
            else if (Role == "Section Head")
            {
                Review.Visible = true;
                TextArea1.Visible = true;   // Enable the textarea
                Label8.Visible = true;
            }

            else if (Role == "Group Head")
            {
                Trainee_details.Enabled = false;
                Activity_table.Enabled = false;
                Remarks.Enabled = true;
                TextArea1.Disabled = true;
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

        protected void review(object sender, EventArgs e)
        {
            string EmployeeID = Session["EmployeeID"].ToString();
            Boolean ISACTIVE = true;

            if ((Employ_ID1.Text == Session["EmployeeID"].ToString()) && ISACTIVE == true)
            {
                int sum = 0;
                if (!string.IsNullOrEmpty(drop1.SelectedValue))
                    sum += Convert.ToInt32(drop1.SelectedValue);

                if (!string.IsNullOrEmpty(Drop2.SelectedValue))
                    sum += Convert.ToInt32(Drop2.SelectedValue);

                if (!string.IsNullOrEmpty(Drop3.SelectedValue))
                    sum += Convert.ToInt32(Drop3.SelectedValue);

                if (!string.IsNullOrEmpty(Drop4.SelectedValue))
                    sum += Convert.ToInt32(Drop4.SelectedValue);

                if (!string.IsNullOrEmpty(Drop5.SelectedValue))
                    sum += Convert.ToInt32(Drop5.SelectedValue);

                if (!string.IsNullOrEmpty(Drop6.SelectedValue))
                    sum += Convert.ToInt32(Drop6.SelectedValue);

                if (!string.IsNullOrEmpty(Drop7.SelectedValue))
                    sum += Convert.ToInt32(Drop7.SelectedValue);
                if (!string.IsNullOrEmpty(Drop8.SelectedValue))
                    sum += Convert.ToInt32(Drop8.SelectedValue);
                if (!string.IsNullOrEmpty(Drop9.SelectedValue))
                    sum += Convert.ToInt32(Drop9.SelectedValue);
                if (!string.IsNullOrEmpty(Drop10.SelectedValue))
                    sum += Convert.ToInt32(Drop10.SelectedValue);
                Txtsum.Text = sum.ToString();
                //   int SUB_TOTAL;


                string Trainee_Name = Name1.Text, Section_Name = section_name1.Text, Team_Name = Team_name1.Text, Program = program1.Text, Section_Head_Name = Section_head_name1.Text, Activity_01 = act1.Text, Activity_02 = act2.Text, Activity_03 = act3.Text, Activity_04 = act4.Text, Activity_05 = act5.Text, Activity_06 = act6.Text, Activity_07 = act7.Text, Activity_08 = act8.Text, Activity_09 = act9.Text, Activity_10 = act10.Text;
                int Activity_01_Rating = int.Parse(drop1.SelectedValue);
                int Activity_02_Rating = int.Parse(Drop2.SelectedValue);
                int Activity_03_Rating = int.Parse(Drop3.SelectedValue);
                int Activity_04_Rating = int.Parse(Drop4.SelectedValue);
                int Activity_05_Rating = int.Parse(Drop5.SelectedValue);
                int Activity_06_Rating = int.Parse(Drop6.SelectedValue);
                int Activity_07_Rating = int.Parse(Drop7.SelectedValue);
                int Activity_08_Rating = int.Parse(Drop8.SelectedValue);
                int Activity_09_Rating = int.Parse(Drop9.SelectedValue);
                int Activity_10_Rating = int.Parse(Drop10.SelectedValue);

                Boolean Approved_By_Team_Lead = true;
                string Recommendation_By_Section_Head = TextArea1.InnerText;
                string Status_Application = "tg_pending";
                string Status = "pending";

                ISACTIVE = true;
                int SUB_TOTAL = int.Parse(Txtsum.Text);
                con.Open();
                SqlCommand co = new SqlCommand("exec Details_SP_update_1 " + EmployeeID + ", '" + Trainee_Name.ToString() + "', '" + Section_Name.ToString() + "', '" + Team_Name.ToString() + "', '" + Program.ToString() + "', '" + Section_Head_Name.ToString() + "', '" + Activity_01.ToString() + "', '" + Activity_01_Rating + "', '" + Activity_02.ToString() + "', '" + Activity_02_Rating + "', '" + Activity_03.ToString() + "', '" + Activity_03_Rating + "', '" + Activity_04.ToString() + "', '" + Activity_04_Rating + "', '" + Activity_05.ToString() + "', '" + Activity_05_Rating + "', '" + Activity_06.ToString() + "', '" + Activity_06_Rating + "', '" + Activity_07.ToString() + "', '" + Activity_07_Rating + "', '" + Activity_08.ToString() + "', '" + Activity_08_Rating + "', '" + Activity_09.ToString() + "', '" + Activity_09_Rating + "', '" + Activity_10.ToString() + "', '" + Activity_10_Rating + "', '" + Recommendation_By_Section_Head.ToString() + "', '" + ISACTIVE + "', '" + SUB_TOTAL + "', '" + Status.ToString() + "', '" + Status_Application.ToString() + "', '" + Approved_By_Team_Lead + "'", con);
                co.ExecuteNonQuery();
                con.Close();
                // ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully Inserted .');", true);
                Details_SP_func_1();
                Label2.Visible = true;
                Label2.Text = "Form Reviewed Succesfully";
            }
        }
        void Details_SP_func()
        {
            SqlCommand co = new SqlCommand("exec Details_SP_update", con);
            SqlDataAdapter sd = new SqlDataAdapter(co);

            // DataTable dt = new DataTable();
            // sd.Fill(dt);
            // GridView1.DataSource = dt;
            //GridView1.DataBind();
        }
        void Details_SP_func_1()
        {
            SqlCommand co = new SqlCommand("exec Details_SP_update_1", con);
            SqlDataAdapter sd = new SqlDataAdapter(co);

            // DataTable dt = new DataTable();
            // sd.Fill(dt);
            // GridView1.DataSource = dt;
            //GridView1.DataBind();
        }

        protected void Submit_Click1(object sender, EventArgs e)
        {
            string EmployeeID = Session["EmployeeID"].ToString();
            Boolean ISACTIVE = true;

            if ((Employ_ID1.Text == Session["EmployeeID"].ToString()) && ISACTIVE == true)
            {
                int sum = 0;
                if (!string.IsNullOrEmpty(drop1.SelectedValue))
                    sum += Convert.ToInt32(drop1.SelectedValue);

                if (!string.IsNullOrEmpty(Drop2.SelectedValue))
                    sum += Convert.ToInt32(Drop2.SelectedValue);

                if (!string.IsNullOrEmpty(Drop3.SelectedValue))
                    sum += Convert.ToInt32(Drop3.SelectedValue);

                if (!string.IsNullOrEmpty(Drop4.SelectedValue))
                    sum += Convert.ToInt32(Drop4.SelectedValue);

                if (!string.IsNullOrEmpty(Drop5.SelectedValue))
                    sum += Convert.ToInt32(Drop5.SelectedValue);

                if (!string.IsNullOrEmpty(Drop6.SelectedValue))
                    sum += Convert.ToInt32(Drop6.SelectedValue);

                if (!string.IsNullOrEmpty(Drop7.SelectedValue))
                    sum += Convert.ToInt32(Drop7.SelectedValue);

                if (!string.IsNullOrEmpty(Drop8.SelectedValue))
                    sum += Convert.ToInt32(Drop8.SelectedValue);

                if (!string.IsNullOrEmpty(Drop9.SelectedValue))
                    sum += Convert.ToInt32(Drop9.SelectedValue);

                if (!string.IsNullOrEmpty(Drop10.SelectedValue))
                    sum += Convert.ToInt32(Drop10.SelectedValue);
                Txtsum.Text = sum.ToString();
                //  int SUB_TOTAL = sum.;

                int Employee_ID = int.Parse(Employ_ID1.Text.ToString());
                string Trainee_Name = Name1.Text, Section_Name = section_name1.Text, Team_Name = Team_name1.Text, Program = program1.Text, Section_Head_Name = Section_head_name1.Text, Activity_01 = act1.Text, Activity_02 = act2.Text, Activity_03 = act3.Text, Activity_04 = act4.Text, Activity_05 = act5.Text, Activity_06 = act6.Text, Activity_07 = act7.Text, Activity_08 = act8.Text, Activity_09 = act9.Text, Activity_10 = act10.Text;
                int Activity_01_Rating = int.Parse(drop1.SelectedValue);
                int Activity_02_Rating = int.Parse(Drop2.SelectedValue);
                int Activity_03_Rating = int.Parse(Drop3.SelectedValue);
                int Activity_04_Rating = int.Parse(Drop4.SelectedValue);
                int Activity_05_Rating = int.Parse(Drop5.SelectedValue);
                int Activity_06_Rating = int.Parse(Drop6.SelectedValue);
                int Activity_07_Rating = int.Parse(Drop7.SelectedValue);
                int Activity_08_Rating = int.Parse(Drop8.SelectedValue);
                int Activity_09_Rating = int.Parse(Drop9.SelectedValue);
                int Activity_10_Rating = int.Parse(Drop10.SelectedValue);

                string Recommendation_By_Section_Head = TextArea1.InnerText;
                string Status_Application = "tl_pending";
                string Status = "pending";
                ISACTIVE = true;

                int SUB_TOTAL = int.Parse(Txtsum.Text);
                con.Open();
                SqlCommand co = new SqlCommand("exec Details_SP_update " + Employee_ID + ", '" + Trainee_Name.ToString() + "', '" + Section_Name.ToString() + "', '" + Team_Name.ToString() + "', '" + Program.ToString() + "', '" + Section_Head_Name.ToString() + "', '" + Activity_01.ToString() + "', '" + Activity_01_Rating + "', '" + Activity_02.ToString() + "', '" + Activity_02_Rating + "', '" + Activity_03.ToString() + "', '" + Activity_03_Rating + "', '" + Activity_04.ToString() + "', '" + Activity_04_Rating + "', '" + Activity_05.ToString() + "', '" + Activity_05_Rating + "', '" + Activity_06.ToString() + "', '" + Activity_06_Rating + "', '" + Activity_07.ToString() + "', '" + Activity_07_Rating + "', '" + Activity_08.ToString() + "', '" + Activity_08_Rating + "', '" + Activity_09.ToString() + "', '" + Activity_09_Rating + "', '" + Activity_10.ToString() + "', '" + Activity_10_Rating + "', '" + Recommendation_By_Section_Head.ToString() + "', '" + ISACTIVE + "', '" + SUB_TOTAL + "', '" + Status.ToString() + "', '" + Status_Application.ToString() + "'", con);
                co.ExecuteNonQuery();
                con.Close();
                // ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully Inserted .');", true);
                Details_SP_func();
                Label2.Visible = true;
                Label2.Text = "Form Submitted Successfully";
            }

        }
        protected void process(object sender, EventArgs e)
        {
            string EmployeeID = Employ_ID1.Text;

            Boolean ISACTIVE = true;

            if (ISACTIVE == true)
            {
                int sum = 0;
                if (!string.IsNullOrEmpty(drop1.SelectedValue))
                    sum += Convert.ToInt32(drop1.SelectedValue);

                if (!string.IsNullOrEmpty(Drop2.SelectedValue))
                    sum += Convert.ToInt32(Drop2.SelectedValue);

                if (!string.IsNullOrEmpty(Drop3.SelectedValue))
                    sum += Convert.ToInt32(Drop3.SelectedValue);

                if (!string.IsNullOrEmpty(Drop4.SelectedValue))
                    sum += Convert.ToInt32(Drop4.SelectedValue);

                if (!string.IsNullOrEmpty(Drop5.SelectedValue))
                    sum += Convert.ToInt32(Drop5.SelectedValue);

                if (!string.IsNullOrEmpty(Drop6.SelectedValue))
                    sum += Convert.ToInt32(Drop6.SelectedValue);

                if (!string.IsNullOrEmpty(Drop7.SelectedValue))
                    sum += Convert.ToInt32(Drop7.SelectedValue);
                if (!string.IsNullOrEmpty(Drop8.SelectedValue))
                    sum += Convert.ToInt32(Drop8.SelectedValue);
                if (!string.IsNullOrEmpty(Drop9.SelectedValue))
                    sum += Convert.ToInt32(Drop9.SelectedValue);
                if (!string.IsNullOrEmpty(Drop10.SelectedValue))
                    sum += Convert.ToInt32(Drop10.SelectedValue);
                Txtsum.Text = sum.ToString();
                //   int SUB_TOTAL;


                string Trainee_Name = Name1.Text, Section_Name = section_name1.Text, Team_Name = Team_name1.Text, Program = program1.Text, Section_Head_Name = Section_head_name1.Text, Activity_01 = act1.Text, Activity_02 = act2.Text, Activity_03 = act3.Text, Activity_04 = act4.Text, Activity_05 = act5.Text, Activity_06 = act6.Text, Activity_07 = act7.Text, Activity_08 = act8.Text, Activity_09 = act9.Text, Activity_10 = act10.Text;
                int Activity_01_Rating = int.Parse(drop1.SelectedValue);
                int Activity_02_Rating = int.Parse(Drop2.SelectedValue);
                int Activity_03_Rating = int.Parse(Drop3.SelectedValue);
                int Activity_04_Rating = int.Parse(Drop4.SelectedValue);
                int Activity_05_Rating = int.Parse(Drop5.SelectedValue);
                int Activity_06_Rating = int.Parse(Drop6.SelectedValue);
                int Activity_07_Rating = int.Parse(Drop7.SelectedValue);
                int Activity_08_Rating = int.Parse(Drop8.SelectedValue);
                int Activity_09_Rating = int.Parse(Drop9.SelectedValue);
                int Activity_10_Rating = int.Parse(Drop10.SelectedValue);

                Boolean Approved_By_Team_Lead = true;
                string Recommendation_By_Section_Head = TextArea1.InnerText;
                string Status_Application = "tl_2_pending";
                string Status = "pending";

                ISACTIVE = true;
                int SUB_TOTAL = int.Parse(Txtsum.Text);
                con.Open();
                SqlCommand co = new SqlCommand("exec Details_SP_update_1 " + EmployeeID + ", '" + Trainee_Name.ToString() + "', '" + Section_Name.ToString() + "', '" + Team_Name.ToString() + "', '" + Program.ToString() + "', '" + Section_Head_Name.ToString() + "', '" + Activity_01.ToString() + "', '" + Activity_01_Rating + "', '" + Activity_02.ToString() + "', '" + Activity_02_Rating + "', '" + Activity_03.ToString() + "', '" + Activity_03_Rating + "', '" + Activity_04.ToString() + "', '" + Activity_04_Rating + "', '" + Activity_05.ToString() + "', '" + Activity_05_Rating + "', '" + Activity_06.ToString() + "', '" + Activity_06_Rating + "', '" + Activity_07.ToString() + "', '" + Activity_07_Rating + "', '" + Activity_08.ToString() + "', '" + Activity_08_Rating + "', '" + Activity_09.ToString() + "', '" + Activity_09_Rating + "', '" + Activity_10.ToString() + "', '" + Activity_10_Rating + "', '" + Recommendation_By_Section_Head.ToString() + "', '" + ISACTIVE + "', '" + SUB_TOTAL + "', '" + Status.ToString() + "', '" + Status_Application.ToString() + "', '" + Approved_By_Team_Lead + "'", con);
                co.ExecuteNonQuery();
                con.Close();
                // ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully Inserted .');", true);
                Details_SP_func_1();
                Label2.Visible = true;
                Label2.Text = "Form Approved!";
            }
        }
        protected void reject(object sender, EventArgs e)
        {
            string EmployeeID = Session["EmployeeID"].ToString();
            Boolean ISACTIVE = true;

            if ((Employ_ID1.Text == Session["EmployeeID"].ToString()) && ISACTIVE == true)
            {


                string Status_Application = "tg_rejected";
                string TRAINEE_REJECTION = TextArea2.InnerHtml;
                string Employee_ID = Employ_ID1.Text;
                ISACTIVE = true;
                con.Open();
                SqlCommand co = new SqlCommand("exec from2_reject " + Employee_ID + ", '" + Status_Application.ToString() + "', '" + TRAINEE_REJECTION.ToString() + "', '" + ISACTIVE.ToString() + "'", con);
                co.ExecuteNonQuery();
                con.Close();
                from2_reject();

                Label2.Visible = true;
                Label2.Text = "From Rejected!";

            }
        }
        void from2_reject()
        {
            SqlCommand co = new SqlCommand("exec from2_reject", con);
            SqlDataAdapter sd = new SqlDataAdapter(co);


            // DataTable dt = new DataTable();
            // sd.Fill(dt);
            // GridView1.DataSource = dt;
            //GridView1.DataBind();



        }
        void Func()
        {
            string value = Page.RouteData.Values["id"].ToString();
            con.Open();
            SqlCommand co = new SqlCommand("select  *  from Details where ID = " + value, con);
            SqlDataReader dr = co.ExecuteReader();
            if (dr.Read())
            {
                Employ_ID1.Text = dr["Employee_ID"].ToString();
                Name1.Text = dr["Trainee_Name"].ToString();
                section_name1.Text = dr["Section_Name"].ToString();
                Team_name1.Text = dr["Team_Name"].ToString();
                program1.Text = dr["Program"].ToString();
                Section_head_name1.Text = dr["Section_Head_Name"].ToString();
                act1.Text = dr["Activity_01"].ToString();
                drop1.SelectedValue = dr["Activity_01_Rating"].ToString();
                act2.Text = dr["Activity_02"].ToString();
                Drop2.SelectedValue = dr["Activity_02_Rating"].ToString();
                act3.Text = dr["Activity_03"].ToString();
                Drop3.SelectedValue = dr["Activity_03_Rating"].ToString();
                act4.Text = dr["Activity_04"].ToString();
                Drop4.SelectedValue = dr["Activity_04_Rating"].ToString();
                act5.Text = dr["Activity_05"].ToString();
                Drop5.SelectedValue = dr["Activity_05_Rating"].ToString();
                act6.Text = dr["Activity_06"].ToString();
                Drop6.SelectedValue = dr["Activity_06_Rating"].ToString();
                act7.Text = dr["Activity_07"].ToString();
                Drop7.SelectedValue = dr["Activity_07_Rating"].ToString();
                act8.Text = dr["Activity_08"].ToString();
                Drop8.SelectedValue = dr["Activity_08_Rating"].ToString();
                act9.Text = dr["Activity_09"].ToString();
                Drop9.SelectedValue = dr["Activity_09_Rating"].ToString();
                act10.Text = dr["Activity_10"].ToString();
                Drop10.SelectedValue = dr["Activity_10_Rating"].ToString();
                Txtsum.Text = dr["SUB_TOTAL"].ToString();
                TextArea1.InnerText = dr["Recommendation_By_Section_Head"].ToString();
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
                    Employ_ID1.Text = dr["Employee_ID"].ToString();
                    Session["EmployeeID"] = Employ_ID1.Text;
                    Name1.Text = dr["Trainee_Name"].ToString();
                    section_name1.Text = dr["Section_Name"].ToString();
                    Team_name1.Text = dr["Team_Name"].ToString();
                    program1.Text = dr["Program"].ToString();
                    Section_head_name1.Text = dr["Section_Head_Name"].ToString();
                    act1.Text = dr["Activity_01"].ToString();
                    drop1.SelectedValue = dr["Activity_01_Rating"].ToString();

                    act2.Text = dr["Activity_02"].ToString();
                    Drop2.SelectedValue = dr["Activity_02_Rating"].ToString();

                    act3.Text = dr["Activity_03"].ToString();
                    Drop3.SelectedValue = dr["Activity_03_Rating"].ToString();
                    act4.Text = dr["Activity_04"].ToString();
                    Drop4.SelectedValue = dr["Activity_04_Rating"].ToString();
                    act5.Text = dr["Activity_05"].ToString();
                    Drop5.SelectedValue = dr["Activity_05_Rating"].ToString();
                    act6.Text = dr["Activity_06"].ToString();
                    Drop6.SelectedValue = dr["Activity_06_Rating"].ToString();
                    act7.Text = dr["Activity_07"].ToString();
                    Drop7.SelectedValue = dr["Activity_07_Rating"].ToString();
                    act8.Text = dr["Activity_08"].ToString();
                    Drop8.SelectedValue = dr["Activity_08_Rating"].ToString();
                    act9.Text = dr["Activity_09"].ToString();
                    Drop9.SelectedValue = dr["Activity_09_Rating"].ToString();
                    act10.Text = dr["Activity_10"].ToString();
                    Drop10.SelectedValue = dr["Activity_10_Rating"].ToString();
                    Txtsum.Text = dr["SUB_TOTAL"].ToString();
                    TextArea1.InnerText = dr["Recommendation_By_Section_Head"].ToString();
                }

                con.Close();

            }
        }
    }
}

