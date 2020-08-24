using System;
using System.Threading.Tasks;
using PoliceFunctions_API.Functions;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using CitizenFX.Core.UI;

namespace Main
{
    public class Main : BaseScript
    {
        public static string Author = "Abel Gaming";
        public static string ModName = "Police Functions";
        public static string Version = "1.0";
        
        public Main()
        {
            Tick += OnTick;
            
            API.RegisterCommand("info", new Action(ShowInfo), false);
            API.RegisterCommand("chat-off", new Action(DisableChat), false);
        }
        
        private static void DisableChat()
        {
            API.SetTextChatEnabled(false);
        }
        
        private static void ShowInfo()
        {
            Screen.ShowNotification("Running");
        }

        private static async Task OnTick()
        {

        }
    }
}
