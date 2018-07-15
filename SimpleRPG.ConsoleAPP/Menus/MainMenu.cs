using System;
using System.Collections.Generic;
using System.Text;
using SimpleRPG.ConsoleAPP.Form;

namespace SimpleRPG.ConsoleAPP.Menus
{
    class MainMenu : Menu
    {
        public String Option { get; set; } = "just started";

        public void InitMenu()
        {
            do
            {
                //Stop the comand line to see the result of what the person choosed!
                if (!Option.Equals("just started")) Console.ReadKey();

                //Show menu and the let the user write what he wants
                ShowMenu();
                ChoseOption();

                //Based on the user option program will fallow the right flow.
                switch (Option)
                {
                    case "1":
                        FormCharacter formCharacter = new FormCharacter();
                        formCharacter.ShowForm();
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            } while (!Option.Equals("quit"));
        }

        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Hello, this is SimpleRPG(quit to exit)\n");
            Console.WriteLine("1 - Create character");
            Console.Write(">");
        }

        private void ChoseOption()
        {
            this.Option = Console.ReadLine();
        }
    }
}
