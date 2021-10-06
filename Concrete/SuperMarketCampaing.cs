namespace CampaingStrategy
{
    public class SuperMarketCampaing : IStrategy
    {
        public decimal ApplyCampaing(decimal Price)
        {
            decimal result = Price - ((Price * 20) / 100);
            return result;
        }
    }
}
