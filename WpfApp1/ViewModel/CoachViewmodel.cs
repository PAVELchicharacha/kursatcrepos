using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Net;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    internal class CoachViewmodel
    {
        private List<Model.Coach> coaches = new List<Model.Coach>();
        private List<ClubVisitor> visitors = new List<ClubVisitor>();
        private List<ClubServices> services = new List<ClubServices>();

        public CoachViewmodel()
        {
            ServicesFromDB();
            AddCoachFromDB();
            AddVisitorsFromDB();
        }

        private void ServicesFromDB()
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
                            services.Add(new ClubServices(
                                reader.GetValue(2).ToString(),
                                (float)Convert.ToDouble(reader.GetValue(1)),
                                (PaymentType)Convert.ToByte(reader.GetValue(3))
                                ));
                        }
                    }
                }

            }
        }

        public void addCoache(Model.Coach coach)
        {
            coaches.Add(coach);
            using (var connection = new SqliteConnection("Data Source=normalBAse.db"))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO coach (Name, SecondName, Age, Gender, Service) VALUES ('{coach.Name}', '{coach.SecondName}','{coach.Age}','{coach.Sex}','{coach.Service.Name}')";
                command.ExecuteNonQuery();
            }
        }
        public void addService(ClubServices service)
        {
            services.Add(service);
            using (var connection = new SqliteConnection("Data Source=normalBAse.db"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO service (Coast, ServiceName, ServicePaymantType) VALUES ('{service.Price}', '{service.Name}','{service.PaymentType}')";
                command.ExecuteNonQuery();
            }
        }
        public void addVisitor(ClubVisitor visitor)
        {
            visitors.Add(visitor);
            using (var connection = new SqliteConnection("Data Source=normalBAse.db"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO visitors (Name, SecondName, Age, Gender, Service) VALUES ('{visitor.Name}', '{visitor.SecondName}','{visitor.Age}','{visitor.Sex}','{visitor.Service.Name}')";
                command.ExecuteNonQuery();
            }
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
                            coaches.Add(new Model.Coach(
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
        public void AddVisitorsFromDB()
        {
            using (var connection = new SqliteConnection("Data Source=normalBAse.db"))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.Connection = connection;

                command.CommandText = "SELECT * FROM visitors";
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())
                        {
                            visitors.Add(new ClubVisitor(
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

        private ClubServices GetServices(string Service)
        {
            Service = Service.ToLower();
            ClubServices ser = new ClubServices();
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

        public List<Model.Coach> getCoaches() { return coaches; }
        public List<ClubServices> getServices() { return services; }
        public List<ClubVisitor> getVisitors() {  return visitors; }

    }
}
