using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bislerium.Data
{
    public class Utility
    {
        
        public static string HasdPassword(string password)
        {
            var sha = SHA256.Create();
            var asByteArray = Encoding.Default.GetBytes(password);
            var hashedPassword = sha.ComputeHash(asByteArray);
            return Convert.ToBase64String(hashedPassword);
        }
        public static string GetAppDirectoryPath()
        {
            return Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Bislerium"
            );
        }
        public static string GetAppUsersFilePath()
        {
            return Path.Combine(GetAppDirectoryPath(), "Users.json");
        }
        public static void DeleteUsersFile()
        {
            string filePath = GetAppUsersFilePath();

            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                    Console.WriteLine("File deleted successfully.");
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Error deleting the file: {e.Message}");
                }
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
       

    }
}
