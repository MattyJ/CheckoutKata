using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckoutKata
{
    public class Checkout : ICheckout
    {
        private readonly List<Product> _products;
        private readonly List<string> _cart;
        private int _totalPrice;

        public Checkout(List<Product> products)
        {
            _products = products;
            _cart = new List<string>();
            _totalPrice = 0;
        }

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