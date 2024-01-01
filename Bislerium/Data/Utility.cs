using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bislerium.Data
{
    public class Utility
    {
        public static string GetAppDirectoryPath()
        {
            return Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Bislerium"
            );
        }
        public static string GetAppUsersFilePath()
        {
            return Path.Combine(GetAppDirectoryPath(), "user.json");
        }
    }
}
