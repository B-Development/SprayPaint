using HarmonyLib;
using Rocket.Core.Plugins;

namespace SprayPaint
{
    public class Main : RocketPlugin<Configuration>
    {
        public static Main Instance;
        private Harmony Harmony { get; set; }

        protected override void Load()
        {
            Instance = this;

            Harmony = new Harmony("paint.vehicle");
            Harmony.PatchAll();
        }

        protected override void Unload()
        {
            Instance = null;

            Harmony.UnpatchAll("paint.vehicle");
        }
    }
}
