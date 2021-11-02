using System;

namespace Average.Shared.Events
{
    public class WorldTimeEventArgs : EventArgs
    {
        public TimeSpan Time { get; set; }
        public int TransitionTime { get; set; }

        public WorldTimeEventArgs(TimeSpan time, int transitionTime)
        {
            Time = time;
            TransitionTime = transitionTime;
        }
    }
}
