using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckoutKata
{
    public class Checkout : ICheckout
    {
        private readonly List<Product> _products;

        public Checkout(List<Product> products)
        {
            _products = products;
            _cart = new List<string>();
        }

        public List<string> _cart { get; set; }
        public int _totalPrice { get; set; }

        public void Scan(string sku)
        {
            _cart.Add(sku);
            var item = _products.SingleOrDefault(x => x.Sku == sku);
            _totalPrice += item.UnitPrice;
        }

        public int GetTotalPrice()
        {
            return _totalPrice;
        }
    }
}