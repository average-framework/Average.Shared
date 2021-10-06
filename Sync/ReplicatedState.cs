using Average.Shared.Attributes;
using System.Reflection;

namespace Average.Shared.Sync
{
    public class ReplicatedState
    {
        public ReplicateAttribute Attribute { get; }
        public PropertyInfo Property { get; }
        public object LastValue { get; set; }
        public object ClassObj { get; }

        public ReplicatedState(ReplicateAttribute attr, PropertyInfo property, object classObj)
        {
            Attribute = attr;
            Property = property;
            ClassObj = classObj;
        }
    }
}
