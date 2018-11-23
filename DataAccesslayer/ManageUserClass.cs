using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccesslayer
{
    public class ManageUserClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int manageUsers(int userId,
            int userRoleId,
            int memberId,
            String userName,
            String userPassword,
            int mode)
        {
            try
            {
                int result = 0;
                SqlCommand commandToManageUsers = new SqlCommand("SP_ManageUsers",conn);
                commandToManageUsers.CommandType = CommandType.StoredProcedure;
                commandToManageUsers.Parameters.AddWithValue("@userId", userId);
                commandToManageUsers.Parameters.AddWithValue("@userRoleId", userRoleId);
                commandToManageUsers.Parameters.AddWithValue("@memberId", memberId);
                commandToManageUsers.Parameters.AddWithValue("@userName", userName);
                commandToManageUsers.Parameters.AddWithValue("@userPassword", userPassword);
                commandToManageUsers.Parameters.AddWithValue("@mode", mode);
                conn.Open();
                result = commandToManageUsers.ExecuteNonQuery();
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
        public DataTable getAllUsers()
        {
            try
            {
                DataTable dataTableTogetAllUsers = new DataTable();
                SqlCommand dataSelectionCommand = new SqlCommand("select u.userId as Id,m.memberName as Name,u.userName as Username,u.userPassword as Password, r.userRole as Role from UserTable u, MemberTable m, UserRoleTable r where u.userRoleId=r.userRoleId and u.memberId=m.memberId", conn);
                dataSelectionCommand.CommandType = CommandType.Text;
                conn.Open();
                SqlDataReader dataReaderForGettingAllUsers = dataSelectionCommand.ExecuteReader();
                dataTableTogetAllUsers.Load(dataReaderForGettingAllUsers);
                conn.Close();
                return dataTableTogetAllUsers;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable userType(int userRoleId,String userName, String userPassword)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select userRole from UserRoleTable where userRoleId=(select userRoleId from UserTable where userName=@userName and userPassword=@userPassword and userRoleId=@userRoleId)", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@userRoleId", userRoleId);
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@userPassword", userPassword);
               
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
