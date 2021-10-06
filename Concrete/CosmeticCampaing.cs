namespace CampaingStrategy
{
    public class CosmeticCampaing : IStrategy
    {
        public decimal ApplyCampaing(decimal Price)
        {
            decimal result = Price - ((Price * 30) / 100);
            return result;
        }
    }
}
