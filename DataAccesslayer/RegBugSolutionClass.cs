using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccesslayer
{
    public class RegBugSolutionClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int manageBugSolutions(int bugSolutionId,
           DateTime dateOfSolutionIdentified,
           int projectId,
           int bugId,
           int memberId,
           String solutionDetails,
           String codeAfterFixingBug,
           int Mode)
        {
            try
            {
                SqlCommand commandToManageBugSolution = new SqlCommand("SP_ManageBugSolutions", conn);
                commandToManageBugSolution.CommandType = CommandType.StoredProcedure;
                commandToManageBugSolution.Parameters.AddWithValue("@bugSolutionId", bugSolutionId);
                commandToManageBugSolution.Parameters.AddWithValue("@dateOfSolutionIdentified", dateOfSolutionIdentified);
                commandToManageBugSolution.Parameters.AddWithValue("@projectId", projectId);
                commandToManageBugSolution.Parameters.AddWithValue("@bugId", bugId);
                commandToManageBugSolution.Parameters.AddWithValue("@memberId", memberId);
                commandToManageBugSolution.Parameters.AddWithValue("@solutionDetails", solutionDetails);
                commandToManageBugSolution.Parameters.AddWithValue("@codeAfterFixingBug", codeAfterFixingBug);
                commandToManageBugSolution.Parameters.AddWithValue("@Mode", Mode);
                conn.Open();
                int result = commandToManageBugSolution.ExecuteNonQuery();
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable getAllBugSolutions()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select b.bugSolutionId,b.dateOfSolutionIdentified,m.memberName, p.projectName,e.bugDetails,e.pbPictureImage,b.solutionDetails,b.codeAfterFixingBug from BugSolutionTable b,BugEntryTable e, ProjectTable p, MemberTable m where b.bugId=e.bugId and b.projectId=p.projectId and b.memberId=m.memberId", conn);
                cmd.CommandType = CommandType.Text;
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
        public DataTable searchBugSolutionByBugDetails(String bugDetails)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select b.bugSolutionId,b.dateOfSolutionIdentified,m.memberName, p.projectName,e.bugDetails,e.pbPictureImage,b.solutionDetails,b.codeAfterFixingBug from BugSolutionTable b,BugEntryTable e, ProjectTable p, MemberTable m where b.bugId=e.bugId and b.projectId=p.projectId and m.memberId=b.memberId and e.bugDetails=@bugDetails", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@bugDetails", bugDetails);
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
