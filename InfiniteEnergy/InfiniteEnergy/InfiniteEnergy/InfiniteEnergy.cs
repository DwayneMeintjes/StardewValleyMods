using System;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace InfiniteEnergy
{
    public class InfiniteEnergy : Mod
    {
        private bool _infiniteEnergyActive = false;

        public override void Entry(IModHelper helper)
        {
            helper.Events.Input.ButtonPressed += OnButtonPressed;
            helper.Events.GameLoop.UpdateTicked += OnUpdateTicked;
        }

        private void OnButtonPressed(object sender, ButtonPressedEventArgs e) {
            if (!Context.IsWorldReady)
            {
                return;
            }

            if (e.Button == SButton.NumPad2)
            {
                _infiniteEnergyActive = !_infiniteEnergyActive;
                Monitor.Log($"Infinite Energy has been {(_infiniteEnergyActive ? "activated" : "deactivated")}!");
            }
        }

        private void OnUpdateTicked(object sender, UpdateTickedEventArgs e)
        {
            if (_infiniteEnergyActive && Game1.player.maxStamina > Game1.player.stamina)
            {
                Game1.player.stamina = Game1.player.maxStamina;
            }
        }
    }
}
