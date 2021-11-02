using Average.Shared.Enums;
using System;

namespace Average.Shared.Events
{
    public class WorldWeatherEventArgs : EventArgs
    {
        public Weather Weather { get; set; }
        public float TransitionTime { get; set; }

        public WorldWeatherEventArgs(Weather weather, float transitionTime)
        {
            Weather = weather;
            TransitionTime = transitionTime;
        }
    }
}
