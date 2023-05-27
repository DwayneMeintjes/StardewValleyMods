using System;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using HarmonyLib;

namespace NoHeartDecay
{
    public class NoHeartDecay : Mod
    {
        private Harmony harmony;

        public override void Entry(IModHelper helper)
        {
            harmony = new Harmony(ModManifest.UniqueID);
            harmony.Patch(
                original: AccessTools.Method(typeof(Game1), "newDay"),
                postfix: new HarmonyMethod(AccessTools.Method(typeof(NoHeartDecay), "DayUpdatePostfix"))
            );
        }

        private static void DayUpdatePostfix()
        {
            if (Game1.player == null || Game1.player.friendshipData == null)
            {
                return;
            }

            foreach (var friendshipDataEntry in Game1.player.friendshipData.Values)
            {
               friendshipDataEntry.Points = Math.Max(friendshipDataEntry.Points, )
            }
        }
    }
}
