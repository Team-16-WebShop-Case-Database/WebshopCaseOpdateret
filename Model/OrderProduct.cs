using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopCase.Model
{
    public class OrderProduct
    {
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public OrderProduct(int orderID, Order order, int productID, Product product, int quantity, decimal price)
        {
            OrderID = orderID;
            Order = order;
            ProductID = productID;
            Product = product;
            Quantity = quantity;
            Price = price;
        }
    }
}
