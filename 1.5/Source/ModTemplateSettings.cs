using Verse;

namespace ModTemplate;

/// <summary>
///     Mod settings for ModTemplate.
/// </summary>
public class ModTemplateSettings : ModSettings
{
    /// <summary>
    ///     An example setting.
    /// </summary>
    public static bool exampleSetting = false;

    /// <summary>
    ///     ExposeData saves and loads the settings.
    /// </summary>
    public override void ExposeData()
    {
        Scribe_Values.Look(ref exampleSetting, "exampleSetting", false);
        base.ExposeData();
    }
}
