using CitizenFX.Core;

namespace Average.Shared.Models
{
    public class NpcModel
    {
        public Vector3 Position { get; set; }
        public float Heading { get; set; }
        public string Model { get; set; }
        public int Variation { get; set; }
        public string Scenario { get; set; }
    }
}