using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using ZooCombat.DatabaseConnection;

namespace ZooCombat.Entities
{
    internal class PlayerAcc
    {
        //public class CurrentPlayer
        //{
        //    int currentID;
        //    string playerName;

        //    public CurrentPlayer()
        //    {
        //        currentID = currentID;
        //    }
        // }
        public void CreatePlayer()
        {
            Console.Write("Choose Name: ");
            string playerName = Console.ReadLine();

            Console.Write("Create Password: ");
            string playerPassword = Console.ReadLine();

            byte[] passwordHash = HashPassword(playerPassword);

            var dc = new DatabaseConnect();

            string sql =
                "INSERT INTO Player (UserName, PasswordHash) VALUES (@UserName, @PasswordHash)";

            var parameters = new Dictionary<string, object>
            {
                ["@UserName"] = playerName,
                ["@PasswordHash"] = passwordHash
            };

            int rows = dc.SqlCommand(sql, parameters);

            Console.WriteLine(rows == 1
                ? "Account created."
                : "Account creation failed.");
        }

        private static byte[] HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        }

        public int? LogInPLayer()
        {
            Console.Write("Enter Username: ");
            string playerName = Console.ReadLine();

            Console.Write("Enter Password: ");
            string playerPassword = Console.ReadLine();

            byte[] passwordHash = HashPassword(playerPassword);

            var dc = new DatabaseConnect();

            string sql =
                "SELECT PlayerID FROM Player WHERE UserName = @UserName AND PasswordHash = @PasswordHash;";

            var parameters = new Dictionary<string, object>
            {
                ["@UserName"] = playerName,
                ["@PasswordHash"] = passwordHash
            };
            int? playerId = dc.SqlLogIn(sql, parameters);
            if (playerId is null)
            {
                Console.WriteLine("Log-In Failed.");
                return null;
            }
            else
            {
                Console.WriteLine($"Logged in. PlayerID = {playerId}");
                /*CurrentPlayer currentPlayer = new CurrentPlayer(playerId)*/;
                return playerId;
                
            }
        }
    }
}
