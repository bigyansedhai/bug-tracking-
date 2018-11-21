using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesslayer;

namespace BussinessLogiclayer
{
    public class BussinessLogicClass
    {

        ManageUserRoleClass ur = new ManageUserRoleClass();
        ManageUserClass muc = new ManageUserClass();
        MemberClass mcl = new MemberClass();
        ProjectMemberClass pm = new ProjectMemberClass();
        ProjectManagementClass pmc = new ProjectManagementClass();
        RegisterBugClass rbc = new RegisterBugClass();
        RegBugSolutionClass rbs = new RegBugSolutionClass();




        public bool ManageRole(int userRoleId,
            String userRole,
            String roleDescription,
            int mode)
        {
            try
            {
                bool result = false;
                int x = ur.ManageRole(userRoleId, userRole, roleDescription, mode);
                if (x > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool manageUsers(int userId,
           int userRoleId,
           int memberId,
           String userName,
           String userPassword,
           int mode)
        {
            try
            {
                bool result = false;
                int rs = muc.manageUsers(userId, userRoleId, memberId, userName, userPassword, mode);
                if (rs > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool ManageMembers(int memberId,
         String memberName,
         String memberAddress,
         String contactNumber,
         String emailAddress,
         String gender,
         DateTime dateOfBirth,
         DateTime dateOfJoin,
         String memberDesignation,
         byte[] profilePicture,
         int Mode)

        {
            try
            {
                int rs = mcl.ManageMembers(memberId, memberName, memberAddress, contactNumber, emailAddress, gender, dateOfBirth, dateOfJoin, memberDesignation, profilePicture, Mode);
                if (rs > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool manageProjectMembers(int id,
           int projectid,
           int memberid,
           String memberRole,
           String memberResponsibilities,
           int Mode)
        {
            try
            {
                int rs = pm.manageMembersInProject(id, projectid, memberid, memberRole, memberResponsibilities, Mode);
                if (rs > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool manageProjects(int projectId,
         String projectName,
         DateTime projectStartDate,
         DateTime projectEndDate,
         String projectDescription,
         int mode)
        {
            try
            {
                bool result = false;
                int rs = pmc.manageProjects(projectId, projectName, projectStartDate, projectEndDate, projectDescription, mode);
                if (rs > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool manageBugs(int bugId,
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
                int rs = rbc.manageBugs(bugId, bugIdentifiedDate, memberId, projectId, classLibraryName, className, methodName, blockName, lineNumber, bugDetails, pbPictureImage, codeContainingBug, mode);
                if (rs > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool manageBugSolutions(int bugSolutionId,
           DateTime dateOfSolutionIdentified,
           int projectId,
           int bugId,
           int memberId,
           string solutionDetails,
           string codeAfterFixingBug,
           int mode)
        {
            try
            {
                int rs = rbs.manageBugSolutions(bugSolutionId, dateOfSolutionIdentified, projectId, bugId, memberId, solutionDetails, codeAfterFixingBug, mode);
                if (rs > 0)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

}

    //public bool ManageRole(int userRoleId,
    //         String userRole,
    //         String roleDescription,
    //         int mode)
    //{
    //    try
    //    {
    //        bool result = false;
    //        int rs = userRole.ma
    //        return result;
    //    }
    //    catch (Exception ex)
    //    {

    //        throw ex;
    //    }
    //}

//try
//        {
//            bool result = false;
//int rs = Us.ManageRole(userRoleId, userRole, roleDescription, mode);
//            if (rs > 0)
//                result = true;
//            else
//                result = false;
//            return result;

//        }
//        catch (Exception ex)
//        {

//            throw ex;
//        }