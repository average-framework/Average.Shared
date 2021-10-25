using Average.Shared.Enums;
using Average.Shared.Interfaces;
using Average.Shared.Models;
using System.Collections.Generic;

namespace Average.Shared.DataModels
{
    public class BankData : EntityBase, IDatabaseEntity
    {
        public string CharacterId { get; set; }
        public List<AccountData> Accounts { get; set; } = new();

        public bool CreateAccount(AccountData accountData)
        {
            if (!AccountExists(accountData))
            {
                Accounts.Add(accountData);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveAccount(AccountData accountData)
        {
            var index = Accounts.FindIndex(x => x.BankType == accountData.BankType);
            Accounts.RemoveAt(index);
        }

        public bool AccountExists(AccountData accountData)
        {
            return Accounts.Exists(x => x.BankType == accountData.BankType);
        }

        public class AccountData
        {
            public BankType BankType { get; set; }
            public int UpgradeLevel { get; set; }

            public AccountData(BankType bankType)
            {
                BankType = bankType;
            }

            public AccountData(BankType bankType, int upgradeLevel)
            {
                BankType = bankType;
                UpgradeLevel = upgradeLevel;
            }
        }
    }
}
