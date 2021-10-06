namespace CampaingStrategy
{
    public class OutdoorCampaing : IStrategy
    {
        public decimal ApplyCampaing(decimal Price)
        {
            decimal result = Price - ((Price * 40) / 100);
            return result;
        }
    }
}
