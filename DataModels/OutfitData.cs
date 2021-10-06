using Average.Shared.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Average.Shared.DataModels
{
    public class OutfitData
    {
        [BsonRepresentation(BsonType.Int64)]
        public uint Accessory { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Apron { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Armor { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Badge { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Beltbuckle { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Belt { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Boot { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Bracelt { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Chap { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Cloak { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Coat { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint CoatClosed { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Eye { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Eyewear { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Gauntlet { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Glove { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Goatee { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Gunbelt { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Hair { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Hat { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Head { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Leg { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Loadout { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Mask { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Mustache { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint MustacheMP { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Necktie { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Neckwear { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Pant { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Poncho { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Satchel { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Sheath { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Shirt { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Skirt { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Spat { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Spur { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Suspender { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Teeth { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Torso { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint Vest { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint BeardChop { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint FemaleUnknow01 { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint HolsterCrossdraw { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint HolsterLeft { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint HolsterRight { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint LegAttachement { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint MaskLarge { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint TalismanBelt { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint TalismanHolster { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint TalismanSatchel { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint TalismanWrist { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint RingLeftHand { get; set; }
        [BsonRepresentation(BsonType.Int64)]
        public uint RingRightHand { get; set; }
    }
}
