using CitizenFX.Core;

namespace Average.Shared.Models
{
    public class RaycastHit
    {
        public bool Hit { get; set; }
        public Vector3 EndCoords { get; set; }
        public Vector3 SurfaceNormal { get; set; }
        public int EntityHit { get; set; } = -1;
        public int EntityType { get; set; }

        public RaycastHit()
        {

        }

        public RaycastHit(bool hit, Vector3 endCoords, Vector3 surfaceNormal, int entityHit, int entityType)
        {
            Hit = hit;
            EndCoords = endCoords;
            SurfaceNormal = surfaceNormal;
            EntityHit = entityHit;
            EntityType = entityType;
        }
    }
}
