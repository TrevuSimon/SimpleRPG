namespace SimpleRPG.Entity.Model.Character.Fabric
{
    public class NewCharacter
    {
        public Character Get(BasicSheet basicSheet)
        {
            return new Character(basicSheet);
        }
    }
}