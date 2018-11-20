using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccesslayer
{
    
    public class ProjectManagementClass
    { 
        // connect sqlconnection
        //the fuction created for Project Management form
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
        public DataTable getAllProjects()
        {
            try
            {
                DataTable dataTableToGetAllProjects = new DataTable();
                SqlCommand dataSelectionCommand = new SqlCommand("Select * from ProjectTable", conn);
                dataSelectionCommand.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader dataReaderForGettingAllProjects = dataSelectionCommand.ExecuteReader();
                dataTableToGetAllProjects.Load(dataReaderForGettingAllProjects);
                conn.Close();
                return dataTableToGetAllProjects;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public int countNumberOfProjects()
        {
            try
            {
                DataTable dataTableToCountNumberOfProjects = new DataTable();
                SqlCommand cmd = new SqlCommand("Select count(*) from ProjectTable",conn);
                conn.Open();
                SqlDataReader dataReaderToGetNumberOfProjectsInDatabase = cmd.ExecuteReader();
                dataTableToCountNumberOfProjects.Load(dataReaderToGetNumberOfProjectsInDatabase);
                conn.Close();
                int numberOfProjects = Convert.ToInt32(dataTableToCountNumberOfProjects.Rows[0][0].ToString());
                return numberOfProjects;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
    }
}
