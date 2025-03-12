using Godot.Interfaces;

namespace Godot.Components.UI;

public abstract partial class BaseTooltip : PanelContainer
{
    private RichTextLabel? ObjectDescriptionLabel { get; set; }
    private RichTextLabel? ObjectNameLabel        { get; set; }
    public  RichTextLabel? Content                { get; set; }
    public  RichTextLabel? Keywords               { get; set; }
    public  VBoxContainer? Container              { get; set; }
    public  HBoxContainer? Requirements           { get; set; }
    public  RichTextLabel? Effects                { get; set; }
    public  RichTextLabel? Boni                   { get; set; }
    public  Color          ColorRed               => new(0.86f, 0.09f, 0.09f);
    public  Color          ColorGreen             => new(0.02f, 0.7f, 0.08f);

    public virtual void Show(ITooltipObjectContainer? objectContainer)
    {
        if (objectContainer is null)
            return;

        FindUIComponents();
        SetDisplayedDataByItem(objectContainer.ContainedItem);
        SetPositionByNode(objectContainer);
    }

    public new virtual void Hide() => Position = new Vector2(-900, -900);

    private void SetDisplayedDataByItem(ITooltipObject tooltipObject)
    {
        if(ObjectNameLabel is null || ObjectDescriptionLabel is null)
            return;

        ObjectNameLabel.Text = ObjectNameLabel.Text.Replace("ItemName", $"[u]{tooltipObject.TooltipName}[/u]");

        ObjectDescriptionLabel.Text = $"{System.Environment.NewLine}" +
                                      $"{tooltipObject.GetTooltipDescription()}{System.Environment.NewLine}" +
                                      $"{System.Environment.NewLine}";
    }

    private void SetPositionByNode(ITooltipObjectContainer container)
    {
        var xPosition = container.Position.X - Size.X + 10;

        if (xPosition <= 0) xPosition = container.Position.X + container.Size.X + 20;

        Position = new Vector2(xPosition, 27);
    }

    // ReSharper disable once InconsistentNaming
    private void FindUIComponents()
    {
        Container              ??= GetNode<MarginContainer>("MarginContainer").GetNode<VBoxContainer>("VBoxContainer");
        Requirements           ??= Container.GetNode<HBoxContainer>("Requirements");
        Effects                ??= Container.GetNode<RichTextLabel>("%Effects");
        Boni                   ??= Container.GetNode<RichTextLabel>("%Boni");
        Content                ??= Container.GetNode<RichTextLabel>("%Content");
        Keywords               ??= Container.GetNode<RichTextLabel>("Keywords");
        ObjectDescriptionLabel ??= Container.GetNode<RichTextLabel>("ObjectDescriptionLabel");
        ObjectNameLabel        ??= Container.GetNode<RichTextLabel>("ObjectNameLabel");
    }
}