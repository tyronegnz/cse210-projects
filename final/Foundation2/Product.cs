using System;

namespace Foundation2
{
    public class Product
    {
        private string name;
        private int productId;
        private decimal price;
        private int quantity;

        public Product(string name, int productId, decimal price, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
        }

        public decimal CalculatePrice()
        {
            return price * quantity;
        }

        public string GetName()
        {
            return name;
        }

        public int GetProductId()
        {
            return productId;
        }

        public int GetQuantity()
        {
            return quantity;
        }
    }

}
