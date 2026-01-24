using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooCombat.PlayerAccount;

namespace ZooCombat.ZooCombatMenu
{
    internal class ZooMenu
    {
        public ZooMenu()
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

            switch(Console.ReadLine())
            {
                case "1":
                    {
                        PlayerAcc pa = new PlayerAcc();
                        pa.CreatePlayer();
                        break;
                    }
                case "2":
                    {
                        PlayerAcc pa = new PlayerAcc();
                        pa.CreatePlayer();
                        break;
                    }
                case "9":
                    {
                        Console.Clear();
                        Console.WriteLine("Goodbye");
                        return;
                    }
            }
        }
    }

}
