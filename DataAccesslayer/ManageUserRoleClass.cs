using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAccesslayer

//<summary>
//user role is creating using manageRole Form
{
    public class ManageUserRoleClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        
        public int ManageRole(int userRoleId,
            String userRole,
            String roleDescription,
            int mode)
        {
            try
            {
                int result = 0;
                SqlCommand commandToManageRole = new SqlCommand("SP_ManageUserRole",conn);
                commandToManageRole.CommandType = CommandType.StoredProcedure;
                commandToManageRole.Parameters.AddWithValue("@userRoleId", userRoleId);
                commandToManageRole.Parameters.AddWithValue("@userRole", userRole);
                commandToManageRole.Parameters.AddWithValue("@roleDescription", roleDescription);
                commandToManageRole.Parameters.AddWithValue("@mode", mode);
                conn.Open();
                result = commandToManageRole.ExecuteNonQuery();
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        

        public DataTable getAllUserRoles()
        {
            try
            {
                DataTable dataTableToGetAllTheRoleInformation = new DataTable();
                SqlCommand commandToGetAllTheRoleInformation = new SqlCommand("SELECT * FROM UserRoleTable", conn);
                commandToGetAllTheRoleInformation.CommandType = CommandType.Text;
               conn.Open();
                SqlDataReader dataReaderToGetAllTheRoleInformation = commandToGetAllTheRoleInformation.ExecuteReader();
                dataTableToGetAllTheRoleInformation.Load(dataReaderToGetAllTheRoleInformation);
                conn.Close();
                return dataTableToGetAllTheRoleInformation;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable getRoleUser()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from UserRoleTable", conn);
                
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }


    }
}
