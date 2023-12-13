using System;
using System.Collections.Generic;
using System.Linq;


namespace Foundation2
{
    public class Order
    {
        private List<Product> products;
        private Customer customer;
        private const decimal USA_SHIPPING_COST = 5;
        private const decimal INTERNATIONAL_SHIPPING_COST = 35;

        public Order(Customer customer)
        {
            this.customer = customer;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public decimal CalculateTotalCost()
        {
            decimal total = products.Sum(product => product.CalculatePrice());
            decimal shippingCost = customer.IsInUSA() ? USA_SHIPPING_COST : INTERNATIONAL_SHIPPING_COST;
            return total + shippingCost;
        }

        public string GetPackingLabel()
        {
            string label = "Packing Label:\n";
            foreach (var product in products)
            {
                label += $"Name: {product.GetName()}, ID: {product.GetProductId()}\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            var customerAddress = customer.GetAddress().GetFullAddress();
            return $"Shipping Label for {customer.GetName()}:\n{customerAddress}";
        }
    }

}
