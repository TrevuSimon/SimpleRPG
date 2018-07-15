using System;
using System.Collections.Generic;
using System.Text;
using SimpleRPG.ConsoleAPP.Menus;

namespace SimpleRPG.ConsoleAPP
{
    class Game
    {
        public static String PlayerPassword { get; set; }
        public static String PlayerName { get; set; }

        static void Main(string[] args)
        {
            NewMenu newMenu = new NewMenu();
            Menu menu = newMenu.Get();
            menu.InitMenu();
        }
    }
}
