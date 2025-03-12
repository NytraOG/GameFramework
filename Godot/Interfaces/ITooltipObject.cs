namespace Godot.Interfaces;

public interface ITooltipObject
{
    [Export]
    public string TooltipName { get; set; }

    string GetTooltipDescription();
}