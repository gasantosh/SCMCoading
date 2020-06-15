﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScmCoading;

namespace SCMCodingTests
{
    [TestClass]
    public class SalesOfficeTests
    {
        private readonly Store store;
        public SalesOfficeTests()
        {
            this.store = new Store();
            this.store.CreateItemInStore("A", 50, 50);
            this.store.CreateItemInStore("B", 30, 50);
            this.store.CreateItemInStore("C", 20, 50);
            this.store.CreateItemInStore("D", 15, 50);
            this.store.CreateOffer(new[] { "A" }, 130, 3);
            this.store.CreateOffer(new[] { "B" }, 45, 2);
            this.store.CreateOffer(new[] { "C", "D" }, 30, 1);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
