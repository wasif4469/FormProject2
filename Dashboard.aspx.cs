using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormProject2
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string role = Session["UserRole"].ToString();

            Label1.Visible = false;
            Label1.Enabled = false;
            Note.Enabled = false;
            Note.Visible = false;
            if (role == "Group Head") {
                Note.Visible = true;
                Note.Enabled = true;
                Label1.Visible = true;
                Label1.Enabled = true;
            }

            else { Label1.Visible = false; }

            if (!Page.IsPostBack)
            {
                Gridviewbind();
            }

        }

        SqlConnection con = new SqlConnection(@"Data Source=crmtest;Initial Catalog=Trainee_Evaluation_System_DB;User ID=t_graduate;Password=Oracle_123");
        private void Gridviewbind()
        {
            try
            {
                string role = Session["UserRole"].ToString();
                string currentUser = Session["FullName"].ToString();
                string[] StatusApplication = null;

                if (role == "Section Head") { StatusApplication = new string[] { "sh_pending", "gh_rejected" }; }
                else if (role == "Group Head") { StatusApplication = new string[] { "gh_pending" }; }
                else if (role == "Team Lead") { StatusApplication = new string[] { "tl_pending", "tl_2_pending", "sh_rejected", "tg_rejected" }; }
                else { StatusApplication = new string[] { "tg_pending" }; }

                string statusApplicationValues = string.Join(",", StatusApplication.Select(s => $"'{s}'")).Trim('"');

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $@"SELECT ID, Trainee_Name, Section_Name, Activity_Form, Indicator_Form
                    FROM Details
                    WHERE (Section_Head_Name = '{currentUser}' OR TEAM_LEAD_NAME = '{currentUser}' OR Group_Head_Name = '{currentUser}' OR Trainee_Name = '{currentUser}')
                    AND Status_Application IN ({statusApplicationValues})
                    AND ISACTIVE = 1
                    ORDER BY ID";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }

            catch (SqlException ex)
            {
                string errorMessage = "No pending Approvals.";
                string script = $"alert('{errorMessage}');";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
            }

            finally
            {
                con.Close();
            }


        }
    }
}