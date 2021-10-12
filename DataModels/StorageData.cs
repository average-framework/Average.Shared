﻿using Average.Shared.Interfaces;
using Average.Shared.Models;
using System.Collections.Generic;

namespace Average.Shared.DataModels
{
    public class StorageData : EntityBase, IDatabaseEntity
    {
        public string StorageId { get; set; }
        public double MaxWeight { get; set; }
        public List<StorageItemData> Items { get; set; } = new List<StorageItemData>();
    }
}