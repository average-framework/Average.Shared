using System;

namespace Average.Shared.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class GetReplicatedAttribute : Attribute
    {
        public string Name { get; set; }

        public GetReplicatedAttribute(string name)
        {
            Name = name;
        }
    }
}
