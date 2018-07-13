using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleRPG.ConsoleAPP
{
    class Game
    {
        public static String PlayerPassword { get; set; }
        public static String PlayerName { get; set; }

        static void Main(string[] args)
        {

            Console.WriteLine("Your name:");
            PlayerName = Console.ReadLine(); 


        }
    }
}
