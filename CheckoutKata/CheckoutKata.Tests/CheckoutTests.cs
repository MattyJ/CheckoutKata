using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CheckoutKata.Tests
{
    [TestClass]
    public class CheckOutTests
    {
        private ICheckout _checkout;
        private List<Product> _products;

        [TestInitialize]
        public void Initialize()
        {
            _products = new List<Product>
            {
                new Product
                {
                    Sku = "A",
                    UnitPrice = 50
                },
                new Product
                {
                    Sku = "B",
                    UnitPrice = 30
                },
                new Product
                {
                    Sku = "C",
                    UnitPrice = 20
                },
                new Product
                {
                    Sku = "D",
                    UnitPrice = 15
                },
            };

            _checkout = new Checkout(_products);
        }

        [TestMethod]
        [DataRow("A", 50)]
        [DataRow("B", 30)]
        [DataRow("C", 20)]
        [DataRow("D", 15)]
        public void Checkout_GetTotalPrice_ScanOneProductOnlyReturnsCorrectTotalPrice(string sku, int totalPrice)
        {
            // Arrange

            // Act
            _checkout.Scan(sku);

            // Assert
            Assert.AreEqual(totalPrice, _checkout.GetTotalPrice());
        }
    }
}
