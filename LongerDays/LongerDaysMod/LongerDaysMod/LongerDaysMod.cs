using System;
using System.ComponentModel;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Menus;
using System.Threading;

namespace LongerDays
{
    public class LongerDaysMod : Mod
    {
        private int timeScaleFactor;

        public override void Entry(IModHelper helper)
        {
            //timeScaleFactor = 2;

            EventHandler<UpdateTickedEventArgs> onUpdateTicked = OnUpdateTicked;
            helper.Events.GameLoop.UpdateTicked += onUpdateTicked;
        }

        

        private void OnUpdateTicked(object sender, UpdateTickedEventArgs e)
        {
            if (!Context.IsWorldReady || !Context.IsPlayerFree)
                return;


            //if (e.Ticks >= 60)
            //{
            //Game1.timeOfDay = 100;
            //}
            var times = Game1.currentGameTime;

            while (true)
            {
                times = Game1.currentGameTime;
                Monitor.Log("The game time currently is: " + times.ToString());
                Thread.Sleep(20000);
            }


            //if (e.Ticks >= 30)
            //{
            //    for (int i = 0; i < 2; i++)
            //    {
            //        while (true) {
            //            if (t.NewTime >= 100)
            //            {
            //                Game1.timeOfDay = 0;
            //                break;
            //            }
            //        }

            //    }
            //}

            //if (e.IsMultipleOf((uint)(timeScaleFactor * 2)))
            //{
            //int newTime = Game1.timeOfDay + timeScaleFactor; 

            //if (newTime % 100 >= 60) 
            //{
            //newTime += 40;
            //}

            //Game1.timeOfDay = newTime;
            //}
        }
    }
}
