using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopCase.Model
{
    public class OrderStatus
    {
        public int StatusID { get; set; }
        public string StatusName { get; set; }

        public OrderStatus(int statusID, string statusName) 
        {
            StatusID = statusID;
            StatusName = statusName;
        }
    }
}
