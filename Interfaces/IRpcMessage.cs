using System;
using System.Collections.Generic;

namespace Average.Shared.Rpc
{
    public interface IRpcMessage
    {
        int Target { get; }
        string Event { get; }
        List<object> Args { get; }
        DateTime CreatedAt { get; }
    }
}
