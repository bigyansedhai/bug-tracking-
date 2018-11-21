using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccesslayer
{
   public class RegisterBugClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);

        public int manageBugs(int bugId,
           DateTime bugIdentifiedDate,
           int memberId,
           int projectId,
           String classLibraryName,
           String className,
           String methodName,
           String blockName,
           String lineNumber,
           String bugDetails,
           byte[] pbPictureImage,
           String codeContainingBug,
           int mode)
        {
            try
            {
                int res = 0;
                SqlCommand cmd = new SqlCommand("SP_ManageBugs", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bugId", bugId);
                cmd.Parameters.AddWithValue("@bugIdentifiedDate", bugIdentifiedDate);
                cmd.Parameters.AddWithValue("@memberId", memberId);
                cmd.Parameters.AddWithValue("@projectId", projectId);
                cmd.Parameters.AddWithValue("@classLibraryName", classLibraryName);
                cmd.Parameters.AddWithValue("@className", className);
                cmd.Parameters.AddWithValue("@methodName", methodName);
                cmd.Parameters.AddWithValue("@blockName", blockName);
                cmd.Parameters.AddWithValue("@lineNumber", lineNumber);
                cmd.Parameters.AddWithValue("@bugDetails", bugDetails);
                cmd.Parameters.AddWithValue("@pbPictureImage", pbPictureImage);
                cmd.Parameters.AddWithValue("@codeContainingBug", codeContainingBug);
                cmd.Parameters.AddWithValue("@mode", mode);
                conn.Open();
                res = cmd.ExecuteNonQuery();
                conn.Close();
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable getAllBugs()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select b.bugId, b.bugIdentifiedDate, m.memberName, p.projectName, b.classLibraryName,b.className,b.methodName, b.blockName, b.lineNumber, b.bugDetails, b.pbPictureImage, b.codeContainingBug from BugEntryTable b, MemberTable m, ProjectTable p where b.memberId=m.memberId and b.projectId=p.projectId", conn);
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

        public DataTable getAllBugsforcombobox()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from BugEntryTable", conn);
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
        public int bugsCount()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select count(*) from BugTable", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                int totalBugs = Convert.ToInt32(dt.Rows[0][0].ToString());
                return totalBugs;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable getBugsBymemberId(int memberId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from BugTable where memberId=@memberId", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@memberId", memberId);
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
        public DataTable getBugsInProjectByProjectId(int projectId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from BugEntryTable where projectId=@projectId",conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@projectId", projectId);
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

        public DataTable getBugsByMemberAndProject(int memberId, int projectId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select bugId,bugDetails from BugTable where memberId=@memberId and projectId=@projectId", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@memberId", memberId);
                cmd.Parameters.AddWithValue("@projectId", projectId);
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

