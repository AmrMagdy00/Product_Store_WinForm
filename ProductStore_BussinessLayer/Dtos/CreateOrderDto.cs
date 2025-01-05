using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore_BussinessLayer.Dtos
{
    public class CreateOrderDto
    {
        public int UserID;
        public int ProductID;
        public short StatusID;
        public int Quantity;
        public DateTime DateRequested;
        public decimal TotalPrice;
        public string ShippingAddress;
    }
}
