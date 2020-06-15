using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScmCoading
{
    public class Offer
    {
        public Offer(IEnumerable<string> offerItesms, int quantity, int price)
        {
            this.OfferItems = new List<string>();
            this.OfferItems.AddRange(offerItesms);
            this.Quantity = quantity;
            this.Price = price;
        }

        public List<string> OfferItems { get; private set; }

        public int Quantity { get; private set; }

        public int Price { get; private set; }
    }
}
