using System;

namespace Average.Shared.Enums
{
    [Flags]
    public enum EntityType : int
    {
        Map,
        Ped,
        Vehicle,
        Prop
    }
}
