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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            box.Visible = false;
            box0.Visible = false;
            box1.Visible = false;
            box2.Visible = false;
            box3.Visible = false;
            box4.Visible = false;
            box5.Visible = false;
            box6.Visible = false;
            box7.Visible = false;
            box8.Visible = false;
            plus2.Visible = false;
            plus3.Visible = false;
            plus4.Visible = false;
            plus5.Visible = false;
            plus6.Visible = false;
            plus7.Visible = false;
            plus8.Visible = false;
            plus9.Visible = false;
            plus10.Visible = false;
            plus11.Visible = false;

            if (Session["IsLoggedIn"] == null || !(bool)Session["IsLoggedIn"])
            {
                Response.Redirect("/LoginPage.aspx");
            }

            else
            {

                if (Page.RouteData.Values["id"] != null)
                {
                    if (!IsPostBack)
                    {
                        Func();
                    }
                }
            }

            if (!IsPostBack)
            {
                Details_SP_func();
                activity();
                sh();
                from2_reject();
            }

            string Role = Session["UserRole"].ToString();

            Trainee_details.Enabled = false;
            Static_table.Enabled = false;
            Activity_table.Enabled = false;
            Activity_table.Enabled = false;
            Submit.Visible = false;
            Review.Visible = false;
            ApprovalPanel.Visible = false;

            if (Role == "Tech Graduate")
            {
                Employ_ID1.Text = Session["EmployeeID"].ToString();
                Employ_ID1.Enabled = false;
                string EmployeeID = Session["EmployeeID"].ToString();
                program1.Text = Role;
                program1.Enabled = false;
                Name1.Text = Session["FullName"].ToString();
                Name1.Enabled = false;
                Trainee_details.Enabled = true;
                Activity_table.Enabled = true;
                TextArea1.Visible = false;  // Disable the textarea
                Submit.Visible = true;
                Review.Visible = false;
                Team_name1.Text = Session["TeamName"].ToString();
                Team_name1.Enabled = false;
                Label8.Visible = false;
                ApprovalPanel.Visible = false;

            }
            else if (Role == "Team Lead")
            {
                Review.Visible = true;
                Activity_table.Enabled = true;
                TextArea1.Visible = false;
                Label8.Visible= false;
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
                Panel1.Visible = true;
                TextArea1.Disabled = true;
            }

        }
        SqlConnection con = new SqlConnection(@"Data Source=crmtest;Initial Catalog=Trainee_Evaluation_System_DB;User ID=t_graduate;Password=Oracle_123");
        protected void vis1(object sender, EventArgs e)
        {
            box.Visible = true;
            plus2.Visible = true;
        }
        protected void add(object sender, EventArgs e)
        {
            string sect = section_name2.SelectedItem.Text.ToString();
            string act = box.Text;
            con.Open();
            SqlCommand co = new SqlCommand("exec activity " + sect.ToString() + ", '" + act.ToString() + "'", con);
            co.ExecuteNonQuery();
            con.Close();
            activity();
            pro();

        }


        void sh()
        {


            con.Open();
            SqlDataAdapter comm = new SqlDataAdapter("select * from BASIC_INFO ", con);
            DataTable dt = new DataTable();
            comm.Fill(dt);
            section_name2.DataSource = dt;
            section_name2.DataValueField = "ID";
            section_name2.DataTextField = "DEPT_NAME";
            section_name2.DataBind();
            section_name2.Items.Insert(0, new ListItem("Please select", ""));
            con.Close();

        }
        void activity()
        {
            SqlCommand co = new SqlCommand("exec activity", con);
            SqlDataAdapter sd = new SqlDataAdapter(co);
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
                section_name2.SelectedValue = dr["Section_Name"].ToString();
                Team_name1.Text = dr["Team_Name"].ToString();
                program1.Text = dr["Program"].ToString();
                Section_head_name1.Text = dr["Section_Head_Name"].ToString();
                acti1.SelectedValue = dr["Activity_01"].ToString();
                drop1.SelectedValue = dr["Activity_01_Rating"].ToString();

                acti2.SelectedValue = dr["Activity_02"].ToString();
                Drop2.SelectedValue = dr["Activity_02_Rating"].ToString();

                acti3.SelectedValue = dr["Activity_03"].ToString();
                Drop3.SelectedValue = dr["Activity_03_Rating"].ToString();
                acti4.SelectedValue = dr["Activity_04"].ToString();
                Drop4.SelectedValue = dr["Activity_04_Rating"].ToString();
                acti5.SelectedValue = dr["Activity_05"].ToString();
                Drop5.SelectedValue = dr["Activity_05_Rating"].ToString();
                acti6.SelectedValue = dr["Activity_06"].ToString();
                Drop6.SelectedValue = dr["Activity_06_Rating"].ToString();
                acti7.SelectedValue = dr["Activity_07"].ToString();
                Drop7.SelectedValue = dr["Activity_07_Rating"].ToString();
                acti8.SelectedValue = dr["Activity_08"].ToString();
                Drop8.SelectedValue = dr["Activity_08_Rating"].ToString();
                acti9.SelectedValue = dr["Activity_09"].ToString();
                Drop9.SelectedValue = dr["Activity_09_Rating"].ToString();
                acti10.SelectedValue = dr["Activity_10"].ToString();
                Drop10.SelectedValue = dr["Activity_10_Rating"].ToString();
                Txtsum.Text = dr["SUB_TOTAL"].ToString();
                TextArea1.InnerHtml = dr["Recommendation_By_Section_Head"].ToString();

            }
            con.Close();
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
                // int SUB_TOTAL = sum.;

                int Employee_ID = int.Parse(Employ_ID1.Text.ToString());
                string Trainee_Name = Name1.Text, Section_Name = section_name2.SelectedItem.Text.ToString(), Team_Name = Team_name1.Text, Program = program1.Text, Section_Head_Name = Section_head_name1.Text, Activity_01 = acti1.SelectedItem.Text.ToString(), Activity_02 = acti2.SelectedItem.Text.ToString(), Activity_03 = acti3.SelectedItem.Text.ToString(), Activity_04 = acti4.SelectedItem.Text.ToString(), Activity_05 = acti5.SelectedItem.Text.ToString(), Activity_06 = acti6.SelectedItem.Text.ToString(), Activity_07 = acti7.SelectedItem.Text.ToString(), Activity_08 = acti8.SelectedItem.Text.ToString(), Activity_09 = acti9.SelectedItem.Text.ToString(), Activity_10 = acti10.SelectedItem.Text.ToString();
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
            }

        }


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
                // int SUB_TOTAL;


                string Trainee_Name = Name1.Text, Section_Name = section_name2.SelectedItem.Text.ToString(), Team_Name = Team_name1.Text, Program = program1.Text, Section_Head_Name = Section_head_name1.Text, Activity_01 = acti1.SelectedItem.Text.ToString(), Activity_02 = acti2.SelectedItem.Text.ToString(), Activity_03 = acti3.SelectedItem.Text.ToString(), Activity_04 = acti4.SelectedItem.Text.ToString(), Activity_05 = acti5.SelectedItem.Text.ToString(), Activity_06 = acti6.SelectedItem.Text.ToString(), Activity_07 = acti7.SelectedItem.Text.ToString(), Activity_08 = acti8.SelectedItem.Text.ToString(), Activity_09 = acti9.SelectedItem.Text.ToString(), Activity_10 = acti10.SelectedItem.Text.ToString();
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
            }
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

        protected void process(object sender, EventArgs e)
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
                // int SUB_TOTAL;


                string Trainee_Name = Name1.Text, Section_Name = section_name2.SelectedItem.Text.ToString(), Team_Name = Team_name1.Text, Program = program1.Text, Section_Head_Name = Section_head_name1.Text, Activity_01 = acti1.SelectedItem.Text.ToString(), Activity_02 = acti2.SelectedItem.Text.ToString(), Activity_03 = acti3.SelectedItem.Text.ToString(), Activity_04 = acti4.SelectedItem.Text.ToString(), Activity_05 = acti5.SelectedItem.Text.ToString(), Activity_06 = acti6.SelectedItem.Text.ToString(), Activity_07 = acti7.SelectedItem.Text.ToString(), Activity_08 = acti8.SelectedItem.Text.ToString(), Activity_09 = acti9.SelectedItem.Text.ToString(), Activity_10 = acti10.SelectedItem.Text.ToString();
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

            }
        }


        void Details_SP_func()
        {
            SqlCommand co = new SqlCommand("exec Details_SP_update", con);
            SqlDataAdapter sd = new SqlDataAdapter(co);
        }
        void act()
        {
            SqlCommand co = new SqlCommand("exec act", con);
            SqlDataAdapter sd = new SqlDataAdapter(co);

        }
        void from2_reject()
        {
            SqlCommand co = new SqlCommand("exec from2_reject", con);
            SqlDataAdapter sd = new SqlDataAdapter(co);
        }

        void pro()
        {
            con.Open();
            string sect = section_name2.SelectedItem.Text.ToString();
            using (SqlDataAdapter comm = new SqlDataAdapter("select * from ACTIVITIES where Department = @sect", con))
            {
                //string sect = section_name2.SelectedValue;
                comm.SelectCommand.Parameters.AddWithValue("@sect", sect);
                DataTable dt = new DataTable();
                comm.Fill(dt);
                acti1.DataSource = dt;
                acti1.DataValueField = "Department";
                acti1.DataTextField = "Activities";
                acti1.DataBind();
                acti2.DataSource = dt;
                acti2.DataValueField = "Department";
                acti2.DataTextField = "Activities";
                acti2.DataBind();
                acti3.DataSource = dt;
                acti3.DataValueField = "Department";
                acti3.DataTextField = "Activities";
                acti3.DataBind();
                acti4.DataSource = dt;
                acti4.DataValueField = "Department";
                acti4.DataTextField = "Activities";
                acti4.DataBind();
                acti5.DataSource = dt;
                acti5.DataValueField = "Department";
                acti5.DataTextField = "Activities";
                acti5.DataBind();
                acti6.DataSource = dt;
                acti6.DataValueField = "Department";
                acti6.DataTextField = "Activities";
                acti6.DataBind();
                acti7.DataSource = dt;
                acti7.DataValueField = "Department";
                acti7.DataTextField = "Activities";
                acti7.DataBind();
                acti8.DataSource = dt;
                acti8.DataValueField = "Department";
                acti8.DataTextField = "Activities";
                acti8.DataBind();
                acti9.DataSource = dt;
                acti9.DataValueField = "Department";
                acti9.DataTextField = "Activities";
                acti9.DataBind();
                acti10.DataSource = dt;
                acti10.DataValueField = "Department";
                acti10.DataTextField = "Activities";
                acti10.DataBind();
                con.Close();
            }
        }

        protected void chnge(object sender, EventArgs e)
        {
            con.Open();
            string sect = section_name2.SelectedItem.Text.ToString();
            using (SqlDataAdapter comm = new SqlDataAdapter("select * from ACTIVITIES where Department = @sect", con))
            {
                //string sect = section_name2.SelectedValue;
                comm.SelectCommand.Parameters.AddWithValue("@sect", sect);
                DataTable dt = new DataTable();
                comm.Fill(dt);
                acti1.DataSource = dt;
                acti1.DataValueField = "Department";
                acti1.DataTextField = "Activities";
                acti1.DataBind();
                acti2.DataSource = dt;
                acti2.DataValueField = "Department";
                acti2.DataTextField = "Activities";
                acti2.DataBind();
                acti3.DataSource = dt;
                acti3.DataValueField = "Department";
                acti3.DataTextField = "Activities";
                acti3.DataBind();
                acti4.DataSource = dt;
                acti4.DataValueField = "Department";
                acti4.DataTextField = "Activities";
                acti4.DataBind();
                acti5.DataSource = dt;
                acti5.DataValueField = "Department";
                acti5.DataTextField = "Activities";
                acti5.DataBind();
                acti6.DataSource = dt;
                acti6.DataValueField = "Department";
                acti6.DataTextField = "Activities";
                acti6.DataBind();
                acti7.DataSource = dt;
                acti7.DataValueField = "Department";
                acti7.DataTextField = "Activities";
                acti7.DataBind();
                acti8.DataSource = dt;
                acti8.DataValueField = "Department";
                acti8.DataTextField = "Activities";
                acti8.DataBind();
                acti9.DataSource = dt;
                acti9.DataValueField = "Department";
                acti9.DataTextField = "Activities";
                acti9.DataBind();
                acti10.DataSource = dt;
                acti10.DataValueField = "Department";
                acti10.DataTextField = "Activities";
                acti10.DataBind();
                con.Close();
            }
        }

        protected void vis2(object sender, EventArgs e)
        {
            box0.Visible = true;
            plus3.Visible = true;
        }

        protected void vis3(object sender, EventArgs e)
        {
            box1.Visible = true;
            plus4.Visible = true;
        }

        protected void vis4(object sender, EventArgs e)
        {
            box2.Visible = true;
            plus5.Visible = true;
        }

        protected void vis5(object sender, EventArgs e)
        {
            box3.Visible = true;
            plus6.Visible = true;
        }

        protected void vis6(object sender, EventArgs e)
        {
            box4.Visible = true;
            plus7.Visible = true;
        }

        protected void vis7(object sender, EventArgs e)
        {
            box5.Visible = true;
            plus8.Visible = true;
        }



        protected void vis8(object sender, EventArgs e)
        {
            box6.Visible = true;
            plus9.Visible = true;
        }

        protected void vis9(object sender, EventArgs e)
        {
            box7.Visible = true;
            plus10.Visible = true;
        }

        protected void vis10(object sender, EventArgs e)
        {
            box8.Visible = true;
            plus11.Visible = true;
        }

        protected void add1(object sender, EventArgs e)
        {
            string sect = section_name2.SelectedItem.Text.ToString();
            string act = box0.Text;
            con.Open();
            SqlCommand co = new SqlCommand("exec activity " + sect.ToString() + ", '" + act.ToString() + "'", con);
            co.ExecuteNonQuery();
            con.Close();
            activity();
            pro();
        }

        protected void add2(object sender, EventArgs e)
        {
            string sect = section_name2.SelectedItem.Text.ToString();
            string act = box1.Text;
            con.Open();
            SqlCommand co = new SqlCommand("exec activity " + sect.ToString() + ", '" + act.ToString() + "'", con);
            co.ExecuteNonQuery();
            con.Close();
            activity();
            pro();
        }

        protected void add3(object sender, EventArgs e)
        {
            string sect = section_name2.SelectedItem.Text.ToString();
            string act = box2.Text;
            con.Open();
            SqlCommand co = new SqlCommand("exec activity " + sect.ToString() + ", '" + act.ToString() + "'", con);
            co.ExecuteNonQuery();
            con.Close();
            activity();
            pro();
        }

        protected void add4(object sender, EventArgs e)
        {
            string sect = section_name2.SelectedItem.Text.ToString();
            string act = box3.Text;
            con.Open();
            SqlCommand co = new SqlCommand("exec activity " + sect.ToString() + ", '" + act.ToString() + "'", con);
            co.ExecuteNonQuery();
            con.Close();
            activity();
            pro();
        }

        protected void add5(object sender, EventArgs e)
        {
            string sect = section_name2.SelectedItem.Text.ToString();
            string act = box4.Text;
            con.Open();
            SqlCommand co = new SqlCommand("exec activity " + sect.ToString() + ", '" + act.ToString() + "'", con);
            co.ExecuteNonQuery();
            con.Close();
            activity();
            pro();
        }

        protected void add6(object sender, EventArgs e)
        {
            string sect = section_name2.SelectedItem.Text.ToString();
            string act = box5.Text;
            con.Open();
            SqlCommand co = new SqlCommand("exec activity " + sect.ToString() + ", '" + act.ToString() + "'", con);
            co.ExecuteNonQuery();
            con.Close();
            activity();
            pro();
        }

        protected void add7(object sender, EventArgs e)
        {
            string sect = section_name2.SelectedItem.Text.ToString();
            string act = box6.Text;
            con.Open();
            SqlCommand co = new SqlCommand("exec activity " + sect.ToString() + ", '" + act.ToString() + "'", con);
            co.ExecuteNonQuery();
            con.Close();
            activity();
            pro();
        }

        protected void add8(object sender, EventArgs e)
        {
            string sect = section_name2.SelectedItem.Text.ToString();
            string act = box7.Text;
            con.Open();
            SqlCommand co = new SqlCommand("exec activity " + sect.ToString() + ", '" + act.ToString() + "'", con);
            co.ExecuteNonQuery();
            con.Close();
            activity();
            pro();
        }

        protected void add9(object sender, EventArgs e)
        {
            string sect = section_name2.SelectedItem.Text.ToString();
            string act = box8.Text;
            con.Open();
            SqlCommand co = new SqlCommand("exec activity " + sect.ToString() + ", '" + act.ToString() + "'", con);
            co.ExecuteNonQuery();
            con.Close();
            activity();
            pro();
        }
    }

}
