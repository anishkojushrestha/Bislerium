
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bislerium.Data
{
    public class UserService
    {
        public const string SeedUsername = "admin";
        public const string SeedPassword = "admin";
        public static List<User> GetAll()
        {
            string appUsersFilePath = Utility.GetAppUsersFilePath();
            if (!File.Exists(appUsersFilePath))
            {
                return new List<User>();
            }

            var json = File.ReadAllText(appUsersFilePath);

            return JsonSerializer.Deserialize<List<User>>(json);
        }

        public static void SeedUsers()
        {
            var users = GetAll().FirstOrDefault(x => x.role == Role.Admin);

            if (users == null)
            {
                List<User> user = GetAll();
                user.Add(
                    new User
                    {
                        role = Role.Admin,
                        Username = SeedUsername,
                        Password = Utility.HasdPassword(SeedPassword)
                    }
                    );
                if (!Directory.Exists(Utility.GetAppDirectoryPath()))
                {
                    Directory.CreateDirectory(Utility.GetAppDirectoryPath());
                }
                List<User> listUser = user;
                var json = JsonSerializer.Serialize(listUser);
                File.WriteAllText(Utility.GetAppUsersFilePath(), json);
            }
        }
    }
}
