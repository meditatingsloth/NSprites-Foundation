using Unity.Entities;

public struct AnimationTimer : IComponentData
{
    public double value;
    public bool isOneTime;
    public bool isComplete;
}
