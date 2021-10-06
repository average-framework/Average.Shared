namespace Average.Shared.DataModels
{
    public class EconomyData
    {
        public decimal Money { get; set; }
        public decimal Bank { get; set; }

        public EconomyData()
        {

        }

        public EconomyData(decimal money, decimal bank)
        {
            Money = money;
            Bank = bank;
        }
    }
}
