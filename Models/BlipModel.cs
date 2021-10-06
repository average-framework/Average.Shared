using CitizenFX.Core;

namespace Average.Shared.Models
{
    public class BlipModel
    {
        public Vector3 Position { get; set; }
        public int Sprite { get; set; }
        public string Label { get; set; }
        public float Scale { get; set; }
        public bool Display { get; set; } = true;
    }
}