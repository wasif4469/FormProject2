using System;
using System.Collections.Generic;
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
            if (!IsPostBack)
            {
                Details_SP_func();
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=crmtest;Initial Catalog=Trainee_Evaluation_System_DB;User ID=t_graduate;Password=Oracle_123");
        protected void submit_Click(object sender, EventArgs e)
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

            int Employee_ID = int.Parse(Employ_ID1.Text);
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
            int ID = 11;
            Boolean ISACTIVE = true;
            int SUB_TOTAL = int.Parse(Txtsum.Text);
            con.Open();
            SqlCommand co = new SqlCommand("exec Details_SP_update " + ID + ", '" + Employee_ID + "', '" + Trainee_Name.ToString() + "', '" + Section_Name.ToString() + "', '" + Team_Name.ToString() + "', '" + Program.ToString() + "', '" + Section_Head_Name.ToString() + "', '" + Activity_01.ToString() + "', '" + Activity_01_Rating + "', '" + Activity_02.ToString() + "', '" + Activity_02_Rating + "', '" + Activity_03.ToString() + "', '" + Activity_03_Rating + "', '" + Activity_04.ToString() + "', '" + Activity_04_Rating + "', '" + Activity_05.ToString() + "', '" + Activity_05_Rating + "', '" + Activity_06.ToString() + "', '" + Activity_06_Rating + "', '" + Activity_07.ToString() + "', '" + Activity_07_Rating + "', '" + Activity_08.ToString() + "', '" + Activity_08_Rating + "', '" + Activity_09.ToString() + "', '" + Activity_09_Rating + "', '" + Activity_10.ToString() + "', '" + Activity_10_Rating + "', '" + Recommendation_By_Section_Head.ToString() + "', '" + ISACTIVE + "', '" + SUB_TOTAL + "', '" + Status.ToString() + "', '" + Status_Application.ToString() + "'", con);
            co.ExecuteNonQuery();
            con.Close();
            // ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully Inserted .');", true);
            Details_SP_func();
        }
        protected void review(object sender, EventArgs e)
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

            int Employee_ID = int.Parse(Employ_ID1.Text);
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
            string Status_Application = "sh_pending";
            string Status = "pending";
            int ID = 11;
            Boolean ISACTIVE = true;
            int SUB_TOTAL = int.Parse(Txtsum.Text);
            con.Open();
            SqlCommand co = new SqlCommand("exec Details_SP_update " + ID + ", '" + Employee_ID + "', '" + Trainee_Name.ToString() + "', '" + Section_Name.ToString() + "', '" + Team_Name.ToString() + "', '" + Program.ToString() + "', '" + Section_Head_Name.ToString() + "', '" + Activity_01.ToString() + "', '" + Activity_01_Rating + "', '" + Activity_02.ToString() + "', '" + Activity_02_Rating + "', '" + Activity_03.ToString() + "', '" + Activity_03_Rating + "', '" + Activity_04.ToString() + "', '" + Activity_04_Rating + "', '" + Activity_05.ToString() + "', '" + Activity_05_Rating + "', '" + Activity_06.ToString() + "', '" + Activity_06_Rating + "', '" + Activity_07.ToString() + "', '" + Activity_07_Rating + "', '" + Activity_08.ToString() + "', '" + Activity_08_Rating + "', '" + Activity_09.ToString() + "', '" + Activity_09_Rating + "', '" + Activity_10.ToString() + "', '" + Activity_10_Rating + "', '" + Recommendation_By_Section_Head.ToString() + "', '" + ISACTIVE + "', '" + SUB_TOTAL + "', '" + Status.ToString() + "', '" + Status_Application.ToString() + "'", con);
            co.ExecuteNonQuery();
            con.Close();
            // ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully Inserted .');", true);
            Details_SP_func();
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

    }
}