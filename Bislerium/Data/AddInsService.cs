using System.Text.Json;

namespace Bislerium.Data
{
    public class AddInsService
    {

        public static List<AddIns> GetAll()
        {
            string appUsersFilePath = Utility.GetAppAddInsFilePath();
            if (!File.Exists(appUsersFilePath))
            {
                return new List<AddIns>();
            }

            var json = File.ReadAllText(appUsersFilePath);

            return JsonSerializer.Deserialize<List<AddIns>>(json);
        }


    }
}
