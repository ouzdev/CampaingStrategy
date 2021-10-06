using System;
using System.Collections.Generic;

namespace CampaingStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> cart = new List<Product>
            {
                new Product{Id = 1, Name = "Alicanın Maceraları Kitabı", Price = 110, CampaingType= Campaing.Book},
                new Product{Id = 2, Name = "Arı Balı Yüz Güzellik Serumu", Price = 130, CampaingType=Campaing.Cosmetic},
                new Product{Id = 3, Name = "Su Geçiren Yağmurluk", Price = 150, CampaingType=Campaing.Outdoor},
                new Product{Id = 4, Name = "Donmaz Terayağı", Price = 200, CampaingType=Campaing.SuperMarket},
            };

            Checkout checkout = new Checkout();
            checkout.Complete(cart);

          

        }
    }
}
