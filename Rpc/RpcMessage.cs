using System;
using System.Collections.Generic;
using System.Linq;

namespace Average.Shared.Rpc
{
    public class RpcMessage
    {
        public string Id { get; } = Guid.NewGuid().ToString();
        public int TargetId { get; set; } = -1;
        public string Event { get; set; }
        public List<object> Args { get; set; } = new List<object>();
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public RpcMessage()
        {

        }

        public RpcMessage(string @event, params object[] args)
        {
            Event = @event;
            Args = args.ToList();
        }
    }
}
