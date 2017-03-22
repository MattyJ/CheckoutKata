using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutKata.Tests
{
    [TestClass]
    public class CheckOutTests
    {
        private ICheckout _checkout;

        [TestInitialize]
        public void Initialize()
        {
            _checkout = new Checkout();
        }
        [TestMethod]
        public void Checkout_GetTotalPrice_ScanProductAReturnsTotalPriceOf50()
        {
            // Arrange

            // Act
            _checkout.Scan("A");

            // Assert
            Assert.AreEqual(50, _checkout.GetTotalPrice());


        }
    }
}
