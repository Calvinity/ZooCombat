//using Microsoft.Data.SqlClient;

//namespace ZooCombat.DatabaseConnectionDEAD
//{
//    internal class DatabaseConnectionBaseDEAD
//    {
//        public void SqlQuery(string connectionString, string query)
//        {
//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                connection.Open();
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            //Console.Write(reader["AnimalName"]);
//                            //Console.Write(" has ");
//                            //Console.Write(reader["AnimalAP"]);
//                            //Console.Write(" AP");
//                            //Console.WriteLine();
//                        }
//                    }
//                }
//            }
//        }
//    }
//}