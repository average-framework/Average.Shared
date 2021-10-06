using Average.Shared.Enums;
using Average.Shared.Interfaces;
using Average.Shared.Models;
using System;

namespace Average.Shared.DataModels
{
    public class WorldData : EntityBase, IDatabaseEntity
    {
        public int WorldId { get; set; }
        public Weather Weather { get; set; }
        public TimeSpan Time { get; set; }
    }
}
