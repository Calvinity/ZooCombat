using Microsoft.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;
using ZooCombat.Entities;
using ZooCombat.ZooCombatMenu;
using ZooCombat.Menu;
using System.ComponentModel.Design;

// skapar playerAccount med klass playerAccount men måste döpa om?
namespace ZooCombat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            int? currentPlayerId= 0;

            while (isRunning == true)
            {
                if (currentPlayerId == 0)
                {
                    isRunning = ZooMenucls.ZooMenu();
                }
                //else
                //{
                //    isRunning = LoggedInMenu.ZooMenu();
                //}
            }
        }
    }
}
