﻿using Average.Shared.Attributes;
using System.Reflection;

namespace Average.Shared.Sync
{
    public class GetReplicatedState
    {
        public GetReplicatedAttribute Attribute { get; }
        public PropertyInfo Property { get; }
        public object ClassObj { get; }

        public GetReplicatedState(GetReplicatedAttribute getSyncAttr, PropertyInfo property, object classObj)
        {
            Attribute = getSyncAttr;
            Property = property;
            ClassObj = classObj;
        }
    }
}
