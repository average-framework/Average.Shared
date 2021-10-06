using CitizenFX.Core;
using System;

namespace Average.Shared.Rpc
{
    public class RpcHandler
    {
        public EventHandlerDictionary EventHandlers { get; private set; }

        public RpcHandler(EventHandlerDictionary eventHandlers)
        {
            EventHandlers = eventHandlers;
        }

        public void Attach(string @event, Delegate callback)
        {
            EventHandlers[@event] += callback;
        }

        public void Detach(string @event, Delegate callback)
        {
            EventHandlers[@event] -= callback;
        }
    }
}
