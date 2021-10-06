using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Average.Shared.Interfaces
{
    public interface IDatabaseEntity
    {
        string Id { get; set; }
    }
}
