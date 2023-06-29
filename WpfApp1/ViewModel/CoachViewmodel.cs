using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    internal class CoachViewmodel
    {
        private List<Coach> coaches = new List<Coach>();
        private List<Services> services = new List<Services>();

        public CoachViewmodel()
        {
            ServicesFromDB();
            AddCoachFromDB();
        }

        void ServicesFromDB()
        {
            using (var connection = new SqliteConnection("Data Source=normalBAse.db"))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;

                command.CommandText = "SELECT * FROM service";
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())
                        {
                            services.Add(new Services(
                                reader.GetValue(2).ToString(),
                                (float)Convert.ToDouble(reader.GetValue(1)),
                                (PaymentType)Convert.ToByte(reader.GetValue(3))
                                ));
                        }
                    }
                }

            }
        }

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
                            coaches.Add(new Coach(
                                reader.GetValue(1).ToString(),
                                reader.GetValue(2).ToString(),
                                Convert.ToByte(reader.GetValue(3)),
                                (Sex)Convert.ToByte(reader.GetValue(4)),
                                GetServices(reader.GetValue(5).ToString())
                                ));
                        }
                    }
                }

            }
        }

        private Services GetServices(string Service)
        {
            Service = Service.ToLower();
            Services ser = new Services();
            foreach (var service in services)
            {
                if (service.Name.ToLower() == Service)
                {
                    ser = service;
                    break;
                }
            }
            return ser;
        }

        public List<Coach> getCoaches() { return coaches; }
        public List<Services> getServices() { return services; }

    }
}
