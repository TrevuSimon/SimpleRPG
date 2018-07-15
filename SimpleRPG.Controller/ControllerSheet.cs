using SimpleRPG.Common;
using SimpleRPG.Entity.Model.Character;

namespace SimpleRPG.Controller
{
    public class ControllerSheet
    {
        public bool GenerateSheet(BasicSheet sheet)
        {
            CommonSheet commonSheet = new CommonSheet();
            if (commonSheet.GenerateStatus(sheet))
            {
                return true;
            }
            return false;
        }   
    }
}