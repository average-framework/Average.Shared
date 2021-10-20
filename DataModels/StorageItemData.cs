using System;
using System.Collections.Generic;

namespace Average.Shared.DataModels
{
    public class StorageItemData
    {
        public int SlotId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        public Dictionary<string, object> Data { get; set; } = new Dictionary<string, object>();

        public StorageItemData(string itemName, int itemCount)
        {
            Name = itemName;
            Count = itemCount;
        }

        public StorageItemData(int slotId, string itemName, int itemCount)
        {
            SlotId = slotId;
            Name = itemName;
            Count = itemCount;
        }

        public StorageItemData(int slotId, string itemName, int itemCount, Dictionary<string, object> overrideData)
        {
            SlotId = slotId;
            Name = itemName;
            Count = itemCount;
            Data = overrideData;
        }

        public T GetData<T>(string key)
        {
            if (Data.ContainsKey(key))
            {
                return (T)Convert.ChangeType(Data[key], typeof(T));
            }
            else
            {
                return default;
            }
        }

        public void SetData(string key, object value)
        {
            if (Data.ContainsKey(key))
            {
                Data[key] = value;
            }
            else
            {
                Data.Add(key, value);
            }
        }
    }
}