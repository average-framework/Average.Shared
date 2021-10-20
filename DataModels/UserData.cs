using Average.Shared.Interfaces;
using Average.Shared.Models;
using System;

namespace Average.Shared.DataModels
{
    public class UserData : EntityBase, IDatabaseEntity
    {
        /// <summary>
        /// Rockstar license of the player
        /// </summary>
        public string License { get; set; }
        /// <summary>
        /// Creation date time of user account
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// Last connection date time of user
        /// </summary>
        public DateTime LastConnection { get; set; }
        /// <summary>
        /// Represent the user account permission level
        /// </summary>
        public int PermissionLevel { get; set; }
        /// <summary>
        /// Ban state of the user
        /// </summary>
        public bool IsBanned { get; set; }
        /// <summary>
        /// Whitelist state of the user
        /// </summary>
        public bool IsWhitelisted { get; set; }
        /// <summary>
        /// Dertermine if the player is connected
        /// </summary>
        public bool IsConnected { get; set; }

        public string SelectedCharacterId { get; set; }
    }
}
