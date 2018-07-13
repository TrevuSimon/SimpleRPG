using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleRPG.Entity.Model
{
    class BasicSheet
    {
        //General info
        public String Name { get; set; }
        public char Genre { get; set; }
        public int Age { get; set; }
        public Decimal Size { get; set; }
        public Decimal Weight { get; set; }

        //Special info
        public Race Race { get; set; }
        public Class Class { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Knowlegde> Knowlegde { get; set; }

        //Atributes
        public int Strengh { get; set; }
        public int Dexterity { get; set; }
        public int Inteligence { get; set; }
        public int Endurance { get; set; }
        public int Wisdom { get; set; }
        public int Will { get; set; }

        //Stuff
        public List<Equipment> Equipements{ get; set; }
        public List<Item> Items{ get; set; }
    }
}
