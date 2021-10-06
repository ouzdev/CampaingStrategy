namespace CampaingStrategy
{
    public class BookCampaing : IStrategy
    {

        public decimal ApplyCampaing(decimal Price)
        {
            decimal result = Price - ((Price * 18) / 100);
            return result;

        }
    }
}
