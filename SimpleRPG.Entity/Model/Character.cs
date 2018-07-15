using System;
using System.Collections.Generic;
using SimpleRPG.Entity.Model.Item.Equipments;

namespace SimpleRPG.Entity.Model.Character
{
    public class Character
    {

        //Sheet
        public int Level { get; set; }
        private BasicSheet Sheet { get; set; }

        //Stuff
        public List<Equipment> Equipements { get; set; }
        public List<Item.Item> Items { get; set; }

        public Character(BasicSheet sheet)
        {
            this.Sheet = sheet;
        }
    }
}