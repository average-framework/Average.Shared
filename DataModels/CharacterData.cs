using Average.Shared.Interfaces;
using Average.Shared.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace Average.Shared.DataModels
{
    public class Test1
    {
        public string Name { get; set; }
    }

    public class Test2
    {
        [BsonId]
        public ObjectId Name { get; set; }
    }

    public class CharacterData : EntityBase, IDatabaseEntity
    {
        public string License { get; set; }

        public string CharacterId { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime LastUsing { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Nationality { get; set; }
        public string CityOfBirth { get; set; }
        public string DateOfBirth { get; set; }

        public EconomyData Economy { get; set; } = new();
        public PositionData Position { get; set; } = new();
        public CoreData Core { get; set; } = new();
        public JobData Job { get; set; } = new();
        public SkinData Skin { get; set; } = new();
        public OutfitData Outfit { get; set; } = new();
        public Dictionary<string, object> Data { get; set; } = new();
    }
}
