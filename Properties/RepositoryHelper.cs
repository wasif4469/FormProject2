using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveDirectorySynchronization
{
    public static class RepositoryHelper
    {
        public static string query, constr;
        public static SqlConnection con;
        public static void connection()
        {
            constr = ConfigurationManager.ConnectionStrings["HerbionDBConnection"].ToString();
            con = new SqlConnection(constr);
            con.Open();
        }
        public static void InsertEmployeeDetail(ADUserDetail ADUserDetail)
        {
            try
            {
                Logger.Info("========== Insert  EmployeeCode : " + ADUserDetail.Employeecode + " EmployeeADuserName " + ADUserDetail.LoginName + "===", "");
                Logger.Info("", "");
            
                connection();
                query = "EEP_INSERTEMPLOYEEPROFILE";
                SqlCommand com = new SqlCommand(query, con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@EMPLOYEE_CODE", ADUserDetail.Employeecode);
                com.Parameters.AddWithValue("@EMPLOYEE_FULL ", ADUserDetail.DisplayName);
                com.Parameters.AddWithValue("@FIRST_NAME ", ADUserDetail.FirstName);
                com.Parameters.AddWithValue("@LAST_NAME", ADUserDetail.LastName);
                com.Parameters.AddWithValue("@ADUSERNAME ", ADUserDetail.LoginName);
                com.Parameters.AddWithValue("@POSITION", ADUserDetail.Title);
                com.Parameters.AddWithValue("@EMAIL", ADUserDetail.EmailAddress);
                com.Parameters.AddWithValue("@ADDRESS", ADUserDetail.StreetAddress);
                com.Parameters.AddWithValue("@PHONENUMBER", ADUserDetail.Mobile);
                com.Parameters.AddWithValue("@COMPANY", ADUserDetail.Company);
                com.Parameters.AddWithValue("@DEPARTMENT", ADUserDetail.Department);
                com.Parameters.AddWithValue("@COUNTRY ", ADUserDetail.Country);
                com.Parameters.AddWithValue("@MANAGER_FULL", ADUserDetail.ManagerName != null ? ADUserDetail.ManagerName : "");
                if (ADUserDetail.Manager != null)
                    Logger.Warning("Manger not found", "");
                com.Parameters.AddWithValue("@MANAGER_CODE", ADUserDetail.Manager != null ? ADUserDetail.Manager.Employeecode : "");
                com.Parameters.AddWithValue("@MANAGER_ADUSERNAME", ADUserDetail.Manager != null ? ADUserDetail.Manager.LoginName : "");
                com.Parameters.AddWithValue("@ISACTIVE", ADUserDetail.UserAccountControl);
                com.ExecuteNonQuery();
            
                Logger.Info("", "");
                Logger.Info("========== End Insert  EmployeeCode : " + ADUserDetail.Employeecode + " EmployeeADuserName " + ADUserDetail.LoginName + "===", "");
                Logger.Info("", "");
            
            }
            catch (Exception ex)
            {
                Logger.Info("", "");
                Logger.Info("============================= Error ======================", "");
                Logger.Error("Employee Insertion Code" + ADUserDetail.Employeecode +" EmployeeADuserName " + ADUserDetail.LoginName,"");
                Logger.Error(ex, "");
                Logger.Info("============================= End Error ======================", "");
                Logger.Info("", "");
            }
        }

    }
}
