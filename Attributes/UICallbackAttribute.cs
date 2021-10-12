using System;

namespace Average.Shared.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class UICallbackAttribute : Attribute
    {
        public string Name { get; }

        public UICallbackAttribute(string name)
        {
            Name = name;
        }
    }
}
