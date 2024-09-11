﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopCase.Model
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int PointBalance { get; set; }

        public Customer(int customerID, string name, string address, string email, string phoneNumber, int pointBalance)
        {
            CustomerID = customerID;
            Name = name;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
            PointBalance = pointBalance;
        }
    }
}
