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

        public StorageItemData()
        {

        }

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
    }
}