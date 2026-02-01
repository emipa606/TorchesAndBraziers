using RimWorld;
using Verse;
using Verse.AI.Group;

namespace SlavExtension;

[StaticConstructorOnStartup]
public class CompSanguophageMeetingFire : CompFireOverlayBase
{
    private Building Building => parent as Building;

    private new CompProperties_SanguophageMeetingFire Props =>
        field ?? (field = props as CompProperties_SanguophageMeetingFire);

    public override void PostDraw()
    {
        base.PostDraw();
        var compGlower = parent.TryGetComp<CompGlower>();
        if (compGlower is { Glows: false })
        {
            return;
        }

        var drawPos = parent.DrawPos;
        drawPos.y += 3f / 74f;
        Props.GraphicData.Graphic.Draw(drawPos + Props.offset, Rot4.North, parent);
    }

    public override bool CompPreventClaimingBy(Faction faction)
    {
        return Building?.GetLord()?.CurLordToil is LordToil_SanguophageMeeting;
    }
}