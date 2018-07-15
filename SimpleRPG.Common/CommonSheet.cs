using System;
using SimpleRPG.Entity.Model.Character;
using SimpleRPG.Entity.Model.Character.Fabric;

namespace SimpleRPG.Common
{
    public class CommonSheet
    {
        public BasicSheet BasicSheet { get; set; }

        public bool CreateSheet()
        {
            NewSheet newSheet = new NewSheet();
            this.BasicSheet = newSheet.Get();
            return true;
        }

        public bool GenerateStatus(BasicSheet sheet)
        {
            Random random = new Random();

            sheet.Strengh = random.Next(1, 10);
            sheet.Dexterity = random.Next(1, 10);
            sheet.Inteligence = random.Next(1, 10);
            sheet.Endurance = random.Next(1, 10);
            sheet.Wisdom = random.Next(1, 10);
            sheet.Will = random.Next(1, 10);

            return true;
        }
    }
}