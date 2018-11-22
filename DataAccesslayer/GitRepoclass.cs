using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace DataAccesslayer
{

    public class GitRepoclass
    {

    //    SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
    //    private readonly string _repoSource;
    //    private readonly UsernamePasswordCredentials_Credentials;
    //    private readonly ManageUserClass muc = new ManageUserClass();
    //    private readonly DirectoryInfo localFolder;

    //    public void GitRepositoryManager(string userName, string userPassword, string gitRepoUrl, string localFolder)
    //    {
    //        var folder = new DirectoryInfo(localFolder);

    //        if (!folder.Exists)
    //        {
    //            throw new Exception(string.Format("Source folder '{0}' does not exist.", localFolder));
    //        }

    //        localFolder = folder;

    //        _credentials = new UsernamePasswordCredentials
    //        {
    //            Username = userName,
    //            Password = userPassword
    //        };

    //        _repoSource = gitRepoUrl;
    //    }
    //    public void CommitAllChanges(string message)
    //    {
    //        using (var repo = new Repository(localFolder.FullName))
    //        {
    //            var files = localFolder.GetFiles("*", SearchOption.AllDirectories).Select(f => f.FullName);
    //            repo.Stage(files);

    //            repo.Commit(message);
    //        }
    //    }

    }

}
