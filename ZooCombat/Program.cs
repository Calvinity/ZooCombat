using Microsoft.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;
using ZooCombat.PlayerAccount;

// skapar playerAccount med klass playerAccount men måste döpa om?
namespace ZooCombat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayerAcc pa = new PlayerAcc();
            pa.CreatePlayer();
        }
    }
} 

