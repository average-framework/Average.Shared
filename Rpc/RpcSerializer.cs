using Newtonsoft.Json;

namespace Average.Shared.Rpc
{
    public class RpcSerializer : IRpcSerializer
    {
        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
