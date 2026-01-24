using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using ZooCombat.DatabaseConnection;

namespace ZooCombat.PlayerAccount
{
    internal class PlayerAcc
    {
        public void CreatePlayer()
        {
            Console.Write("Create Account: ");
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

        public void LogInPLayer()
        {
            Console.Write("Enter Username: ");
            string playerName = Console.ReadLine();

            Console.Write("Enter Password: ");
            string playerPassword = Console.ReadLine();

            byte[] passwordHash = HashPassword(playerPassword);

            var dc = new DatabaseConnect();

            string sql =
                "SELECT PlayerID_PK FROM Player WHERE UserName = @UserName AND PasswordHash = @PasswordHash;";

            var parameters = new Dictionary<string, object>
            {
                ["@UserName"] = playerName,
                ["@PasswordHash"] = passwordHash
            };

            int? rows = dc.SqlLogIn(sql, parameters);

            Console.WriteLine(rows == 1
                ? "Logged In"
                : "Log-In Failed.");
        }
    }
}
