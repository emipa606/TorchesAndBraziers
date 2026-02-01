using RimWorld;
using Verse;

namespace SlavExtension;

public class CompProperties_SanguophageMeetingFire : CompProperties_FireOverlay
{
    public GraphicData GraphicData;

    public CompProperties_SanguophageMeetingFire()
    {
        compClass = typeof(CompSanguophageMeetingFire);
    }
}