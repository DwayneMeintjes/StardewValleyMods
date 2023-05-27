using System;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace add100G
{
    public class add100G : Mod
    {
        public override void Entry(IModHelper helper)
        {
            helper.Events.Input.ButtonPressed += OnButtonPressed;
        }

        private void OnButtonPressed(object sender, ButtonPressedEventArgs e) 
        {
            if (!Context.IsWorldReady || !Context.IsPlayerFree)
            {
                return;
            }

            if (e.IsDown(SButton.NumPad0))
            {
                Game1.player.Money += 100;
                Monitor.Log("Added 100 coins to your money.");
            }
        }
    }
}
