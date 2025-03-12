namespace Godot.Components.UI;

public abstract class DpsDisplay : PanelContainer
{
    private double captureTimer;
    private float  totalDamage;
    private double totalTime;

    [Export]
    public int DpsCaptureFrameTimeMilliseconds { get; set; } = 1000;

    public             float  DamageDealtInTimeFrame      { get; set; }
    public             int    TimeRangeToCaptureInSeconds { get; set; }
    protected abstract string NodeName                    { get; set; }

    public override void _Ready() => GetNode<Label>(NodeName).Text = "0,0";

    public override void _Process(double delta)
    {
        if ((captureTimer += delta) >= (float)DpsCaptureFrameTimeMilliseconds / 1000)
        {
            if (captureTimer == 0)
                return;

            totalDamage += DamageDealtInTimeFrame;
            totalTime   += captureTimer;

            if (totalTime >= TimeRangeToCaptureInSeconds) { }

            var dps = DamageDealtInTimeFrame / captureTimer;
            GetNode<Label>(NodeName).Text = dps.ToString("F1");

            captureTimer           = 0;
            DamageDealtInTimeFrame = 0;
        }
    }
}