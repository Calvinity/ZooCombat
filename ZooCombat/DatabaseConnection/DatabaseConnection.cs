using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooCombat.DatabaseConnection
{
    internal class DatabaseConnect
    {
        private const string DefaultConnectionString =
@"Server=localhost\SQLEXPRESS;Database=zoocombat;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
        string connectionString = DefaultConnectionString;
        public int? SqlLogIn(string query, Dictionary<string, object>? parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    foreach (var p in parameters)
                    {
                        command.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);
                    }
                    object? result = command.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                        return null;
                    return (int)result;
                }
            }
        }
        public int SqlCommand(string query, Dictionary<string, object> parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    foreach (var p in parameters)
                        command.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);
                    return command.ExecuteNonQuery();
                }
            }
        }
        public List<string> SqlQuery(string query)
        {
            var result = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(reader.GetString(0));
                    }
                }
            }

            return result;
        }

        public void AnimalCreation()
        {
            string sqlAnimalNamesQuery = "SELECT AnimalName FROM Animals";
            List<string> animalNameList=SqlQuery(sqlAnimalNamesQuery);
            Console.WriteLine("Please Pick an animal from the list to add to your team!");
            foreach (string animalName in animalNameList)
            {
                Console.WriteLine(animalName);
            }

        }
    }
}
