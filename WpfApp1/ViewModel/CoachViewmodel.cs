using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    internal class CoachViewmodel
    {
        private List<Coach> coaches = new List<Coach>();    

        public void addCoache(Coach coach)
        {
            coaches.Add(coach);
        }
        public void AddCoachFromDB()
        {
            using (var connection = new SqliteConnection("Data Source=normalBAse.db"))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;

                command.CommandText = "SELECT * FROM coach";
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
        }

        public List<Coach> getCoaches() {  return coaches; }
    }
}
