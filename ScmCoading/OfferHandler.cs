using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScmCoading
{
    public class OfferHandler
    {
        private List<Offer> offers;
        public OfferHandler()
        {
            this.offers = new List<Offer>();
        }

        public IEnumerable<Offer> GetOffers()
        {
            return this.offers;
        }

        public void AddOffer(IEnumerable<string> offerItems, int quantity, int price)
        {
            var offer = new Offer(offerItems, quantity, price);
            this.offers.Add(offer);
        }

        public List<Offer> GetOffers()
        {
            return this.offers;
        }
    }
}
