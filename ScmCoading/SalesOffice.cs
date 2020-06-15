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
            return 0;
        }
    }
}
