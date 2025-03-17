using Godot.Components.UI;

namespace Godot.Configurators;

public static class Extensions
{
    public static FloatingCombatText AsHeal(this FloatingCombatText floatingCombatText, int fontSize = 36)
    {
        floatingCombatText.SetFontColor(Colors.LimeGreen);
        floatingCombatText.SetFontSize(fontSize);

        return floatingCombatText;
    }

    public static FloatingCombatText AsHealCritical(this FloatingCombatText floatingCombatText, int fontSize = 42)
    {
        floatingCombatText.SetFontColor(Colors.DarkGreen);
        floatingCombatText.SetFontSize(fontSize);

        return floatingCombatText;
    }

    public static FloatingCombatText AsDamageDealt(this FloatingCombatText floatingCombatText, int fontSize = 36)
    {
        floatingCombatText.SetFontColor(Colors.White);
        floatingCombatText.SetFontSize(fontSize);

        return floatingCombatText;
    }

    public static FloatingCombatText AsDamageDealtCritical(this FloatingCombatText floatingCombatText, int fontSize = 42)
    {
        floatingCombatText.SetFontColor(Colors.DarkOrange);
        floatingCombatText.SetFontSize(fontSize);

        return floatingCombatText;
    }

    public static FloatingCombatText AsDamageReceived(this FloatingCombatText floatingCombatText, int fontSize = 36)
    {
        floatingCombatText.SetFontColor(Colors.Red);
        floatingCombatText.SetFontSize(fontSize);

        return floatingCombatText;
    }

    public static FloatingCombatText AsDamageReceivedCritical(this FloatingCombatText floatingCombatText, int fontSize = 42)
    {
        floatingCombatText.SetFontColor(Colors.DarkOrange);
        floatingCombatText.SetFontSize(fontSize);

        return floatingCombatText;
    }
}