using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleRPG.ConsoleAPP.Menus
{
    class MainMenu : Menu
    {
        public String Option { get; set; } = "";

        public void IniMenu()
        {
            do
            {
                switch (Option)
                {
                    case "1":
                        Console.WriteLine("Yet to implement!");
                        break;
                }
            } while (!Option.Equals("quit"));
        }

        public void ShowMenu()
        {
            Console.WriteLine("Hello, this is SimpleRPG(quit to exit)\n\n");
            Console.WriteLine("1 - Create character");
            Console.Write(">");
        }

        public void ChoseOption()
        {
            this.Option = Console.ReadLine();
        }
    }
}
