using System;
using System.Data.SqlTypes;
using SimpleRPG.Controller;
using SimpleRPG.Entity.Model.Character;
using SimpleRPG.Entity.Model.Character.Fabric;

namespace SimpleRPG.ConsoleAPP.Form
{
    public class FormCharacter
    {
        public bool ShowForm()
        {
            NewSheet newSheet = new NewSheet();
            BasicSheet sheet = newSheet.Get();
            ControllerSheet controllerSheet = new ControllerSheet();

            string confirm = "";

            do
            {
                Console.Clear();
                Console.WriteLine("Charater info:");
                Console.WriteLine("Name:");
                sheet.Name = Console.ReadLine();
                Console.WriteLine("Sex:");
                sheet.Genre = (Console.ReadLine())[0];
                Console.WriteLine("Age:");
                sheet.Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Confirm?(yes/no)");
                confirm = Console.ReadLine();
            } while (!confirm.Equals("yes"));

            confirm = "";

            do
            {
                Console.Clear();
                if (controllerSheet.GenerateSheet(sheet))
                {
                    Console.WriteLine("SheetResult");
                    ShowSheetStatus(sheet);
                    Console.WriteLine("Confirm?(yes/no)");
                    confirm = Console.ReadLine();
                }
            } while (!confirm.Equals("yes"));


            return true;
        }

        private void ShowSheetStatus(BasicSheet sheet)
        {
            Console.WriteLine("Strengh: {0}",sheet.Strengh);
            Console.WriteLine("Dexterity: {0}",sheet.Dexterity);
            Console.WriteLine("Inteligence: {0}",sheet.Inteligence);
            Console.WriteLine("Endurance: {0}",sheet.Endurance);
            Console.WriteLine("Wisdom: {0}",sheet.Wisdom);
            Console.WriteLine("Will: {0}",sheet.Will);
        }
    }
}