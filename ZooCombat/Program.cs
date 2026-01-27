using Microsoft.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;
using ZooCombat.PlayerAccount;
using ZooCombat.ZooCombatMenu;
using System.ComponentModel.Design;

// skapar playerAccount med klass playerAccount men måste döpa om?
namespace ZooCombat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            ZooMenucls zm = new ZooMenucls();
            //PlayerAcc pa = new PlayerAcc();
            //pa.CreatePlayer();
            while (isRunning == true)
            {
                isRunning = ZooMenucls.ZooMenu();
            }
        }
    }
}
