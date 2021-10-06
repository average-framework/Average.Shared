namespace Average.Shared.Rpc
{
    public interface IRpcSerializer
    {
        string Serialize(object obj);
        T Deserialize<T>(string json);
    }
}
