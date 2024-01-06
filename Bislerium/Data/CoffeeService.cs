using System.Text.Json;

namespace Bislerium.Data
{
    public class CoffeeService
    {

        public static List<Coffees> GetAll()
        {
            string appUsersFilePath = Utility.GetAppCoffeeFilePath();
            if (!File.Exists(appUsersFilePath))
            {
                return new List<Coffees>();
            }

            var json = File.ReadAllText(appUsersFilePath);

            return JsonSerializer.Deserialize<List<Coffees>>(json);
        }


    }
}
