using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScmCoading
{
    public class Store
    {
        private List<Item> Items;
        private OfferHandler offerHandler;
        public Store()
        {
            this.Items = new List<Item>();
            this.offerHandler = new OfferHandler();
        }

        public void CreateOffer(IEnumerable<string> itmeNames, int price, int quanity)
        {
            this.offerHandler.AddOffer(itmeNames, price, quanity);
        }

        public void CreateItemInStore(string name, int price, int quanity)
        {
            this.Items.Add(new Item(name, price, quanity));
        }

        public IEnumerable<Offer> GetOffersInStore()
        {
            return this.offerHandler.GetOffers();
        }

        public int GetItemPrice(string name)
        {
            return this.Items.Single(s => s.Name == name).Price.Value;
        }
    }
}
