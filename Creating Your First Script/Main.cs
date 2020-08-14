using System;
using System.Threading.Tasks;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using CitizenFX.Core.UI;

namespace PROJECTNAME
{
    public class Main : BaseScript
    {
        public Main()
        {
            Tick += OnTick;
            API.RegisterCommand("command", new Action(CommandAction), false);
        } // <<<< THIS IS YOUR CLOSING MAIN BRACKET
        
        private static void CommandAction()
        {
            //COMMAND CODE GOES HERE
            Screen.ShowNotification("Abel Gaming");
        }

        private static async Task OnTick()
        {

        }
    }
}
