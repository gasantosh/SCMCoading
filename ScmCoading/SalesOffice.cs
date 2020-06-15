using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScmCoading
{
    public class SalesOffice
    {
        private Cart cart;
        private Store store;
        public SalesOffice(Store store)
        {
            this.cart = new Cart();
            this.store = store;
        }

        public void SellItem(string name, int quantity)
        {
            this.cart.AddItemToCart(name, quantity);
        }

        public int GetCartValue()
        {
            var cartItems = this.cart.GetCartItems().ToList();
            var offers = this.store.GetOffersInStore();
            var value = this.GetValueForNotClubbedOffers(cartItems, offers);
            value = value + this.GetValueForClubbedOffers(cartItems, offers);
            value = value + this.GetValueCartItems(cartItems);
            return 0;
        }

        private int GetValueForNotClubbedOffers(List<Item> cartItems, IEnumerable<Offer> offers)
        {
            int cartValue = 0;
            var items = cartItems.ToArray();
            foreach (var item in items)
            {
                var offer = offers.FirstOrDefault(f => f.OfferItems.Contains(item.Name) && !f.IsClubedOffer);
                if (offer != null && offer.Quantity <= item.Quantity)
                {
                    var totalOfferAvailed = item.Quantity / offer.Quantity;
                    var leftItem = item.Quantity - totalOfferAvailed;
                    cartValue = cartValue + totalOfferAvailed * offer.Price + leftItem * this.store.GetItemPrice(item.Name);

                    cartItems.Remove(item);
                }
            }

            return cartValue;
        }

        private int GetValueForClubbedOffers(List<Item> cartItems, IEnumerable<Offer> offers)
        {
            int cartValue = 0;
            var items = cartItems.ToArray();
            foreach (var item in items)
            {
                var offer = offers.FirstOrDefault(f => f.OfferItems.Contains(item.Name) && f.IsClubedOffer);
                if (offer != null)
                {
                    var clubbedItem = cartItems.FirstOrDefault(f => f.Name != item.Name && offer.OfferItems.Contains(f.Name));
                    cartValue = cartValue + offer.Price;

                    cartItems.Remove(item);
                    cartItems.Remove(clubbedItem);
                }
            }

            return cartValue;
        }

        private int GetValueCartItems(List<Item> cartItems)
        {
            int cartValue = 0;
            foreach (var item in cartItems)
            {
                cartValue = cartValue + item.Quantity * this.store.GetItemPrice(item.Name);
            }

            return cartValue;
        }
    }
}
