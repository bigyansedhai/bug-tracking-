using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccesslayer
{
   public class ProjectMemberClass
    { // connection sqlconnection
        //create fuction and passing parameter
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int manageProjects(int projectId,
          String projectName,
          DateTime projectStartDate,
          DateTime projectEndDate,
          String projectDescription,
          int mode)
        {
            try
            {
                SqlCommand commandToManageProjectTable = new SqlCommand("SP_ManageProjects", conn);
                commandToManageProjectTable.CommandType = CommandType.StoredProcedure;
                commandToManageProjectTable.Parameters.AddWithValue("@projectId", projectId);
                commandToManageProjectTable.Parameters.AddWithValue("@projectName", projectName);
                commandToManageProjectTable.Parameters.AddWithValue("@projectStartDate", projectStartDate);
                commandToManageProjectTable.Parameters.AddWithValue("@projectEndDate", projectEndDate);
                commandToManageProjectTable.Parameters.AddWithValue("@ProjectDescription", projectDescription);
                commandToManageProjectTable.Parameters.AddWithValue("@mode", mode);
                conn.Open();
                int resultOfManageProject = commandToManageProjectTable.ExecuteNonQuery();
                conn.Close();
                return resultOfManageProject;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
    }
}
