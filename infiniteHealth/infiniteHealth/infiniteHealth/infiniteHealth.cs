using System;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace infiniteHealth
{
    public class infiniteHealth : Mod
    {
        private bool _infiniteHealthActive = false;
        public override void Entry(IModHelper helper)
        {
            helper.Events.Input.ButtonPressed += OnButtonPressed;
            helper.Events.GameLoop.UpdateTicked += OnUpdateTicked;
        }

        private void OnButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            if (!Context.IsWorldReady)
            {
                return;
            }
            
            if (e.Button == SButton.NumPad1)
            {
                _infiniteHealthActive = true;
                Monitor.Log($"Infinite Health has been {(_infiniteHealthActive ? "activated" : "deactivated")}!");
            }
        }

        private void OnUpdateTicked(object sender, UpdateTickedEventArgs e)
        {
            if (_infiniteHealthActive && Game1.player.maxHealth > Game1.player.health)
            {
                Game1.player.health = Game1.player.maxHealth;
            }
        }
    }
}
