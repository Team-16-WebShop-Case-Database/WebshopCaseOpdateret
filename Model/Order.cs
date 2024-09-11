using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WebshopCase.Model
{
    public class Order
    {
        public int OrderID { get; set; }
        public Customer Customer { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDateTime { get; set; }
        public OrderStatus Status { get; set; }

        public Order(int orderID, Customer customer, double totalPrice, DateTime orderDateTime, string statusName, int statusID, OrderStatus status)
        {
            OrderID = orderID;
            Customer = customer;
            TotalPrice = totalPrice;
            OrderDateTime = orderDateTime;
            Status = status;
        }
    }
}
