using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooCombat.PlayerAccount;

namespace ZooCombat.ZooCombatMenu
{
    internal class ZooMenucls
    {
        public static bool ZooMenu()
            //ville/föreslog static men spelar det någon roll? är det någon skillnad mer än att det är enklare att alltid skriva zoomenucls.zoomenu istället för instance.zoomenu?
        {
            Console.WriteLine("Welcome to ZooCombat!");
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine();
            Console.WriteLine("1 Create Account");
            Console.WriteLine("2 Log in");
            Console.WriteLine("9 Exit");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine();
            Console.Write("Enter Option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        PlayerAcc pa = new PlayerAcc();
                        pa.CreatePlayer();
                        return true;
                    }
                case "2":
                    {
                        PlayerAcc pa = new PlayerAcc();
                        pa.LogInPLayer();
                        return true;
                    }
                case "9":
                    {
                        Console.Clear();
                        Console.WriteLine("Goodbye");
                        return false;
                    }
                default:
                    {
                        Console.WriteLine("Invalid option. Please try again.");
                        return true;
                    }
            }
        }
    }

}
