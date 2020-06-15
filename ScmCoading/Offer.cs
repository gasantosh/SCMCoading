using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScmCoading
{
    public class Offer
    {
        private List<string> offerItesms;
        public Offer()
        {
            this.offerItesms = new List<string>();
        }

        public List<string> OfferItems { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }
    }
}
