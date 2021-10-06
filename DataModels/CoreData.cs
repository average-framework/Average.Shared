using Average.Shared.DataModels;
using Average.Shared.Models;
using Newtonsoft.Json;

namespace Average.Shared.DataModels
{
    public class CoreData
    {
        public int Health { get; set; } = 100;
        public int Hunger { get; set; } = 100;
        public int Thirst { get; set; } = 100;
        public int Stamina { get; set; } = 100;
    }
}
