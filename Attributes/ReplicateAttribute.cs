using System;

namespace Average.Shared.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ReplicateAttribute : Attribute
    {
        public string Name { get; }

        public ReplicateAttribute(string name)
        {
            Name = name;
        }
    }
}
