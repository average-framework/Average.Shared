using Average.Shared.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Average.Shared.DataModels
{
    public class SkinData
    {
        public Gender Gender { get; set; }

        [BsonRepresentation(BsonType.Int64)]
        public uint Head { get; set; }

        [BsonRepresentation(BsonType.Int64)]
        public uint Body { get; set; }

        [BsonRepresentation(BsonType.Int64)]
        public uint Legs { get; set; }

        public int BodyType { get; set; }
        public int WaistType { get; set; }
        public float Scale { get; set; }

        // Face

        public float HeadWidth { get; set; }
        public float EyebrowHeight { get; set; }
        public float EyebrowWidth { get; set; }
        public float EyebrowDepth { get; set; }
        public float EarsWidth { get; set; }
        public float EarsAngle { get; set; }
        public float EarsHeight { get; set; }
        public float EarsLobeSize { get; set; }
        public float CheeckBonesHeight { get; set; }
        public float CheeckBonesWidth { get; set; }
        public float CheeckBonesDepth { get; set; }
        public float JawHeight { get; set; }
        public float JawWidth { get; set; }
        public float JawDepth { get; set; }
        public float ChinHeight { get; set; }
        public float ChinWidth { get; set; }
        public float ChinDepth { get; set; }
        public float EyeLidHeight { get; set; }
        public float EyeLidWidth { get; set; }
        public float EyesDepth { get; set; }
        public float EyesAngle { get; set; }
        public float EyesDistance { get; set; }
        public float EyesHeight { get; set; }
        public float NoseWidth { get; set; }
        public float NoseSize { get; set; }
        public float NoseHeight { get; set; }
        public float NoseAngle { get; set; }
        public float NoseCurvature { get; set; }
        public float NoStrilsDistance { get; set; }
        public float MouthWidth { get; set; }
        public float MouthDepth { get; set; }
        public float MouthXPos { get; set; }
        public float MouthYPos { get; set; }
        public float UpperLipHeight { get; set; }
        public float UpperLipWidth { get; set; }
        public float UpperLipDepth { get; set; }
        public float LowerLipHeight { get; set; }
        public float LowerLipWidth { get; set; }
        public float LowerLipDepth { get; set; }

        // Overlay

        public List<OverlayData> OverlaysData { get; set; } = new();

        // Texture

        public int Albedo { get; set; }
        public int Normal { get; set; }
        public int Material { get; set; }
    }
}
