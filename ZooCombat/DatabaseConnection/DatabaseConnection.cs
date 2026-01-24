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
        string query = "SELECT * FROM ANIMAL";
        public void SqlQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Console.Write(reader["AnimalName"]);
                            //Console.Write(" has ");
                            //Console.Write(reader["AnimalAP"]);
                            //Console.Write(" AP");
                            //Console.WriteLine();
                        }
                    }
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
    }
}
