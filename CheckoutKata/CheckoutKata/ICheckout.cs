using System.Collections.Generic;
using System.Text;

namespace CheckoutKata
{
    public interface ICheckout
    {
        void Scan(string sku);
        int GetTotalPrice();
    }
}
