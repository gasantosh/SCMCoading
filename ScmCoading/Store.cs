﻿using System;
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

            CreateItemsInStore();
            this.offerHandler.AddOffer(new[] { "A" }, 3, 130);
            this.offerHandler.AddOffer(new[] { "B" }, 2, 45);
            this.offerHandler.AddOffer(new[] { "C", "D" }, 1, 30);
        }

        private void CreateItemsInStore()
        {
            this.Items.Add(new Item("A", 50));
            this.Items.Add(new Item("B", 30));
            this.Items.Add(new Item("C", 20));
            this.Items.Add(new Item("D", 10));
        }
    }
}
