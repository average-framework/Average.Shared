namespace Average.Shared.Rpc
{
    public interface IRpcTrigger
    {
        void Trigger(RpcMessage message);
    }
}
