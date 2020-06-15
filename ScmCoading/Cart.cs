using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScmCoading
{
    public class Cart
    {
        private List<Item> cartItems;
        public Cart()
        {
            this.cartItems = new List<Item>();
        }

        public void AddItemToCart(string name, int quantity)
        { 
            this.cartItems.Add(new Item(name, quantity));
        }

        public IEnumerable<Item> GetCartItems()
        {
            return this.cartItems;
        }
    }
}
