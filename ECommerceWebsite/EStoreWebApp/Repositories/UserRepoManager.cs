using EStoreWebApp.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace EStoreWebApp.Repositories
{
    public class UserRepoManager
    
        public static User GetUser(int id)
    {
        User user = null;
        //code segment
        return user;
    }
        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();
        string connectionString = "Server=localhost;Port=3306;database=Mydata;User=root;Password=Champion007;";
        MySqlConnection connection = new MySqlConnection(connectionString);
         try
        {
            connection.Open();
            string query = "Select * FROM Users;";
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                int id = reader.GetInt32("id");
                string name = reader.GetString("Name");
                string email = reader.GetString("Email");
                string password = reader.GetString("Password");
                string contactNumber = reader.GetString("ContactNumber");
                User user = new User();
                user.Id = id;
                user.Email = email;
                user.ContactNumber = ContactNumber;
                user.password = Password;
            }
        }
    }
    }
}
