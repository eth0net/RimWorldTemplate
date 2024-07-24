using HarmonyLib;
using Verse;

namespace ModTemplate;

/// <summary>
///     Patches the game using Harmony on startup.
/// </summary>
[StaticConstructorOnStartup]
public static class HarmonyPatcher
{
    /// <summary>
    ///     Initializes the Harmony patcher.
    /// </summary>
    static HarmonyPatcher()
    {
        new Harmony("ModTemplate").PatchAll();
    }
}
