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
                  = new Buyer();

                buyer.ID_Buyer = int.Parse(reader.GetValue(0).ToString()!);
                buyer.FirstName = reader.GetValue(1).ToString()!;
                buyer.SecondName = reader.GetValue(2).ToString()!;
                buyer.LastName = reader.GetValue(3).ToString()!;
                buyer.DateBirth = reader.GetValue(4).ToString()!;
                buyer.Passport = reader.GetValue(5).ToString()!;
                buyer.Address = reader.GetValue(6).ToString()!;

                BuyersList.Add(buyer);
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
