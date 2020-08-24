using System;
using System.Threading.Tasks;
using PoliceFunctions_API.Functions;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using CitizenFX.Core.UI;
using NativeUI;

namespace PROJECTNAME
{
    public class MainMenu : BaseScript
    {
        private MenuPool _menuPool;
        private UIMenu mainMenu;
            
        public void PlayerOptions(UIMenu menu)
        {
            var playeroptionssub = _menuPool.AddSubMenu(menu, "Player Options");
            for (int i = 0; i < 1; i++) ;

            playeroptionssub.MouseEdgeEnabled = false;
            playeroptionssub.ControlDisablingEnabled = false;
                
            var heal = new UIMenuItem("Heal Player", "Regenerate health");
            playeroptionssub.AddItem(heal);
            playeroptionssub.OnItemSelect += (sender, item, index) =>
            {
                if (item == heal)
                {
                    Game.Player.Character.Health = 100;
                }
            };
        }
            
        public MainMenu()
        {
            _menuPool    = new MenuPool();
            var mainMenu = new UIMenu("Police Functions", "MultiSource Mod");
            _menuPool.Add(mainMenu);
                
            PlayerOptions(mainMenu);

            _menuPool.MouseEdgeEnabled = false;
            _menuPool.ControlDisablingEnabled = false;
            _menuPool.RefreshIndex();

            Tick += async () =>
            {
                _menuPool.ProcessMenus();
                if (API.IsControlJustPressed(0, 166) && !_menuPool.IsAnyMenuOpen()) // Our menu on/off switch
                   mainMenu.Visible = !mainMenu.Visible;
            };
        }
    }
}
