using MySql.Data.MySqlClient;
using System.Data;

string connectionString = "Server=localhost;Port=3306;Database=Mydata;User=root;Password=Champion007;";
//open new connection
MySqlConnection connection = new MySqlConnection(connectionString);
try
{
    connection.Open();
    string query = "Select * FROM Users;";
    MySqlCommand command= connection.CreateCommand();
    command.CommandText = query;
    MySqlDataReader reader = command.ExecuteReader();
    while (reader.Read())
    {
        int id=reader.GetInt32("id");
        string Name=reader.GetString("name");
        string Email=reader.GetString("email");
        string Password=reader.GetString("password");
        string ContactNumber = reader.GetString("ContactNumber");
        Console.WriteLine(id + " " +Name+ " "+Email + " " + Password + " " +ContactNumber);
    }
    reader.Close();
}
catch(MySqlException e)
{
    Console.WriteLine(e.Message);   
}
finally
{
    if (connection.State != ConnectionState.Closed)
        connection.Close();

}
Console.ReadLine();

