using System;
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
        public void GetCartValue_WhenNoOffer_ShouldReturnActualValue()
        {
            // Actors
            var salesOffice = new SalesOffice(this.store);
            salesOffice.SellItem("A", 1);
            salesOffice.SellItem("B", 1);
            salesOffice.SellItem("C", 1);

            // Activity
            var cartValue = salesOffice.GetCartValue();

            // Assertions 
            Assert.AreEqual(100, cartValue);
        }

        [TestMethod]
        public void GetCartValue_WhenNoClubbedOffer_ShouldReturnOfferValue()
        {
            // Actors
            var salesOffice = new SalesOffice(this.store);
            salesOffice.SellItem("A", 5);
            salesOffice.SellItem("B", 5);
            salesOffice.SellItem("C", 1);

            // Activity
            var cartValue = salesOffice.GetCartValue();

            // Assertions 
            Assert.AreEqual(370, cartValue);
        }

        [TestMethod]
        public void GetCartValue_WhenClubbedOffer_ShouldReturnOfferValue()
        {
            // Actors
            var salesOffice = new SalesOffice(this.store);
            salesOffice.SellItem("A", 3);
            salesOffice.SellItem("B", 5);
            salesOffice.SellItem("C", 1);
            salesOffice.SellItem("D", 1);

            // Activity
            var cartValue = salesOffice.GetCartValue();

            // Assertions 
            Assert.AreEqual(280, cartValue);
        }
    }
}
