using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using (SqliteConnection connection = new SqliteConnection("Data Source=normalBAse.db"))
{
    connection.Open();
    SqliteCommand command = connection.CreateCommand();
    command.Connection = connection;
    command.CommandText = "SELECT * FROM Buyer";
    using (SqliteDataReader reader = command.ExecuteReader())
    {
        if (reader.HasRows) // если есть данные
        {
            while (reader.Read())
            {
                
            }
        }
    }
}
namespace WpfApp1.Model
{
    internal class DatabaseConnection
    {
      
    }
}
