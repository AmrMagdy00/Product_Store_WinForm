using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore_BussinessLayer.Dtos
{
    public class ShowOrderDto
    {
        public string ProductName { get; set; }
        public string Status { get; set; }
        public int Quantity { get; set; }
        public DateTime DateRequested { get; set; }
        public decimal TotalPrice { get; set; }     
        public string ShippingAddress { get; set; }
    }
}
