using HarmonyLib;
using RimWorld;
using Verse;

namespace EntityNeverEscapeRandomly.Patch
{
    [HarmonyPatch(typeof(CompHoldingPlatformTarget), "CaptivityTick")]
    public class Patch_CompHoldingPlatformTarget_CaptivityTick
    {
        static bool Prefix(Pawn pawn, CompHoldingPlatformTarget __instance)
        {
            pawn.mindState.entityTicksInCaptivity++;
            if (__instance.targetHolder is Building_HoldingPlatform building_HoldingPlatform && building_HoldingPlatform != __instance.HeldPlatform && building_HoldingPlatform.Occupied)
            {
                __instance.targetHolder = null;
            }

            //if (__instance.parent.IsHashIntervalTick(2500))
            //{
            //    float num = ContainmentUtility.InitiateEscapeMtbDays(pawn);
            //    if (num >= 0f && Rand.MTBEventOccurs(num, 60000f, 2500f))
            //    {
            //        __instance.Escape(initiator: true);
            //    }
            //}

            return false;
        }
    }
}
