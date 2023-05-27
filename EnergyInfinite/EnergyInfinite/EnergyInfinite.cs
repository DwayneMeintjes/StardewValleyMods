using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace EnergyInfinite
{
    public class EnergyInfinite : Mod
    {
        public override void Entry(IModHelper helper)
        {
            helper.Events.Input.ButtonPressed += OnButtonPressed;
        }

        private void OnButtonPressed(object sender, ButtonPressedEventArgs e) {
            
            if (!Context.IsWorldReady)
            {
                return;
            }

            if (e.IsDown(SButton.NumPad2))
            {
                Monitor.Log("Infinite Energy has been activated!");
                while (!e.IsDown(SButton.NumPad2))
                {
                    if (Game1.player.maxStamina > Game1.player.Stamina)
                    {
                        Game1.player.stamina = Game1.player.maxStamina;
                    }
                }
            }
        }
    }
}
