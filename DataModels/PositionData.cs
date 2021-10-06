using Average.Shared.Models;
using Newtonsoft.Json;

namespace Average.Shared.DataModels
{
    public class PositionData
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float H { get; set; }

        public PositionData()
        {

        }

        public PositionData(float x, float y, float z, float heading)
        {
            X = x;
            Y = y;
            Z = z;
            H = heading;
        }
    }
}
