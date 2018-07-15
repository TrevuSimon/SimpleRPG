using System.IO;
using Newtonsoft.Json;
using SimpleRPG.Entity.Model.Character;

namespace SimpleRPG.Data
{
    public class DataCharacter
    {
        public Character Character { get; set; }

        public bool Save(Character character)
        {
            this.Character = character;
            string jsonCharacter = JsonConvert.SerializeObject(this.Character);
            string saveLocation = @"c:\SimpleRPG\";
            saveLocation += character.Sheet.Name + ".json";
            File.WriteAllText(saveLocation, JsonConvert.SerializeObject(jsonCharacter));
            return true;
        }
    }
}