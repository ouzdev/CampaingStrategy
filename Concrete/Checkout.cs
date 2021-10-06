using System;
using System.Collections.Generic;

namespace CampaingStrategy
{
    public class Checkout
    {
        public decimal ApplyCampaing(decimal Price)
        {
            throw new NotImplementedException();
        }

        public void Complete(List<Product> cart)
        {
            List<string> orderSummery = new List<string>();
            foreach (var item in cart)
            {
                if (item.CampaingType == Campaing.Book)
                {
                    IStrategy campaingStrategy = new BookCampaing();
                    var result = campaingStrategy.ApplyCampaing(item.Price);
                    orderSummery.Add(item.Name + " ürünü kitap kampanyası ile " + item.Price + " TL fiyatından " + result + " TL fiyatına düşmüştür.");
                }
                else if (item.CampaingType == Campaing.Cosmetic)
                {
                    IStrategy campaingStrategy = new CosmeticCampaing();
                    var result = campaingStrategy.ApplyCampaing(item.Price);
                    orderSummery.Add(item.Name + " ürünü kozmetik kampanyası ile " + item.Price + " TL fiyatından " + result + " TL fiyatına düşmüştür.");

                }
                else if (item.CampaingType == Campaing.Outdoor)
                {
                    IStrategy campaingStrategy = new OutdoorCampaing();
                    var result = campaingStrategy.ApplyCampaing(item.Price);
                    orderSummery.Add(item.Name + " ürünü outdoor spor kampanyası ile " + item.Price + " TL fiyatından " + result + " TL fiyatına düşmüştür.");

                }
                else if (item.CampaingType == Campaing.SuperMarket)
                {
                    IStrategy campaingStrategy = new SuperMarketCampaing();
                    var result = campaingStrategy.ApplyCampaing(item.Price);
                    orderSummery.Add(item.Name + " ürünü süper market kampanyası ile " + item.Price + " TL fiyatından " + result + " TL fiyatına düşmüştür.");

                }
            }

            OrderSummery(orderSummery);
        }

        public void OrderSummery(List<string> orderSummery)
        {
            foreach (var item in orderSummery)
            {
                Console.WriteLine(item);
                Console.WriteLine("*************************************************");
            }

            Console.ReadKey();
        }
    }
}
