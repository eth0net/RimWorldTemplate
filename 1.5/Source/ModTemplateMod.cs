using HarmonyLib;
using UnityEngine;
using Verse;

namespace ModTemplate;

/// <summary>
///     ModTemplate class to load up the mod and initialise everything.
/// </summary>
public class ModTemplate : Mod
{
    /// <summary>
    ///     ModTemplate settings reference.
    /// </summary>
    internal static ModTemplateSettings settings;

    /// <summary>
    ///     ModTemplate constructor to load the mod and settings.
    ///     Also applies patches using harmony.
    /// </summary>
    public ModTemplate(ModContentPack content) : base(content)
    {
        settings = GetSettings<ModTemplateSettings>();
        new Harmony("eth0net.ModTemplate").PatchAll();
    }

    /// <summary>
    ///     DoSettingsWindowContents configures the settings window.
    /// </summary>
    /// <param name="inRect"></param>
    public override void DoSettingsWindowContents(Rect inRect)
    {
        Listing_Standard listing = new();

        listing.Begin(inRect);

        listing.GapLine();
        listing.Label("Example Settings");
        listing.GapLine();

        listing.CheckboxLabeled("Example Setting", ref ModTemplateSettings.exampleSetting, "Example setting description");

        listing.End();

        base.DoSettingsWindowContents(inRect);
    }

    /// <summary>
    ///     SettingsCategory returns the name of the settings category.
    /// </summary>
    /// <returns></returns>
    public override string SettingsCategory()
    {
        return "ModTemplate".Translate();
    }
}
