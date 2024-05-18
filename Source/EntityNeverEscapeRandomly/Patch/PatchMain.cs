using HarmonyLib;
using System.Reflection;
using Verse;

namespace EntityNeverEscapeRandomly.Patch
{
    [StaticConstructorOnStartup]
    public class PatchMain
    {
        public static Harmony instance;

        static PatchMain()
        {
            instance = new Harmony("EntityNeverEscapeRandomly.Patch");
            instance.PatchAll(Assembly.GetExecutingAssembly());

            Log.Message("EntityNeverEscapeRandomly Patched");
        }
    }
}
