using System.Security.Cryptography;
using System.Text;

namespace Bislerium.Data
{
    public class Utility

    /* Unmerged change from project 'Bislerium (net8.0-maccatalyst)'
    Before:
        {

            public static string HasdPassword(string password)
    After:
        {

            public static string HasdPassword(string password)
    */

    /* Unmerged change from project 'Bislerium (net8.0-ios)'
    Before:
        {

            public static string HasdPassword(string password)
    After:
        {

            public static string HasdPassword(string password)
    */

    /* Unmerged change from project 'Bislerium (net8.0-android)'
    Before:
        {

            public static string HasdPassword(string password)
    After:
        {

            public static string HasdPassword(string password)
    */
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
        public static string GetAppCoffeeFilePath()
        {
            return Path.Combine(GetAppDirectoryPath(), "Coffee.json");
        }
        public static string GetAppAddInsFilePath()
        {
            return Path.Combine(GetAppDirectoryPath(), "AddIns.json");
        }
        public static string GetAppCustomerFilePath()
        {
            return Path.Combine(GetAppDirectoryPath(), "Customers.json");
        }
        public static string GetAppOrderFilePath()
        {
            return Path.Combine(GetAppDirectoryPath(), "Orders.json");
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
