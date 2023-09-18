using Unity.Mathematics;
using UnityEngine;

[CreateAssetMenu(
    fileName = "NewNSpriteAnimation",
    menuName = "NSprites/Animation (frame sequence)"
)]
public class SpriteAnimation : ScriptableObject
{
    // Sprite here required because whe want to know UV of animation frame sequence on atlas
    public Sprite SpriteSheet;
    public int2 FrameCount = new(1);
    public float[] FrameDurations = new float[1] { 0.1f };
}
